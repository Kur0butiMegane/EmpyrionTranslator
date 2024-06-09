using System.Text.RegularExpressions;
using System.Web;
using System.Text.Json;
using System.Text;

namespace EmpyrionTranslator
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient WebClient = new();
        private Language? LanguageData = default;

        private static readonly Dictionary<string, string> LangListDict = new()
        {
            { "Bulgarian", "BG" },
            { "Czech", "CS" },
            { "Danish", "DA" },
            //{ "German", "DE" },
            { "Deutsch", "DE" },
            { "Greek", "EL" },
            { "English (British)", "EN-GB" },
            //{ "English (American)", "EN-US" },
            { "English", "EN-US" },
            { "Spanish", "ES" },
            { "Estonian", "ET" },
            { "Finnish", "FI" },
            { "Français", "FR" },
            { "Hungarian", "HU" },
            { "Indonesian", "ID" },
            { "Italiano", "IT" },
            { "Japanese", "JA" },
            { "Korean", "KO" },
            { "Lithuanian", "LT" },
            { "Latvian", "LV" },
            { "Norwegian (Bokmål)", "NB" },
            { "Dutch", "NL" },
            { "Polish", "PL" },
            { "Portuguese (Brazil)", "PT-BR" },
            { "Portuguese (Euro)", "PT-PT" },
            { "Romanian", "RO" },
            { "Russian", "RU" },
            { "Slovak", "SK" },
            { "Slovenian", "SL" },
            { "Swedish", "SV" },
            { "Turkish", "TR" },
            { "Ukrainian", "UK" },
            { "Chinese (simplified)", "ZH" },
            { "Chinese (traditional)", "EN"}, // DeepL未対応
            { "Vietnamese", "EN" } // DeepL未対応
        };

        enum FormMode
        {
            STAND_BY,
            ON_TRANSLATING
        }

        FormMode CurrentMode = FormMode.STAND_BY;

        int CurrentRow = 1;

        public MainForm()
        {
            InitializeComponent();
            SwitchMode( FormMode.STAND_BY );
            Init();

            OpenTargetFileDialog.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.Desktop );
            OpenTargetFileDialog.Filter = "Empyrion Dialgues, PDA, Localization file | *.csv";
            OpenTargetFileDialog.FileName = string.Empty;

            if ( File.Exists( "config.json" ) )
            {
                var json = File.ReadAllText( "config.json" );
                var settings = JsonSerializer.Deserialize<Settings>( json );
                APIKeyTextBox.Text = settings.DeepLAPIKey;
            }
            else
            {
                var json = JsonSerializer.Serialize( new Settings() );
                File.WriteAllText( "config.json", json, Encoding.UTF8 );
            }
        }

        private void Init()
        {
            FilePathTextBox.ResetText();
            RowTextBox.ResetText();
            TotalRowTextBox.ResetText();
            KeyTextBox.ResetText();
            SourceStringTextBox.ResetText();
            LanguageComboBox.ResetText();
            OriginTextBox.ResetText();
            TranslationTextBox.ResetText();

            LanguageComboBox.Items.Clear();
        }

        private void SwitchMode( FormMode mode )
        {
            CurrentMode = mode;
            switch ( mode )
            {
                case FormMode.STAND_BY:
                    SecondBox.Enabled = false;
                    ThirdBox.Enabled = false;
                    FourthBox.Enabled = false;
                    NoticeTextBox.Text = "翻訳を行うファイルを開いてください。";
                    break;
                case FormMode.ON_TRANSLATING:
                    SecondBox.Enabled = true;
                    ThirdBox.Enabled = true;
                    FourthBox.Enabled = true;
                    NoticeTextBox.Text = "PageUp : 前へ / PageDown : 次へ / Home : 先頭へ / End : 末尾へ";
                    break;
            }
        }

        private bool ReadCSVFile( string fpath )
        {
            if ( !File.Exists( fpath ) ) return false;

            try
            {
                LanguageData = new Language( fpath );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
                return false;
            }

            return true;
        }

        private void SetTranslator( int rowNum )
        {
            var lang = LanguageData.Rows[ rowNum - 1 ];
            var idx = GetIndex( LanguageData.LangNames, LanguageComboBox.SelectedItem );

            CurrentRow = rowNum;
            KeyTextBox.Text = lang.Key;
            SourceStringTextBox.Text = lang.Origin.Replace( @"\n", Environment.NewLine );
            OriginTextBox.Text = DeleteTags( lang.Origin ).Replace( @"\n", Environment.NewLine );
            TranslationTextBox.Text = lang.Literals[ idx ].Replace( @"\n", Environment.NewLine );

            TagListPanel.SuspendLayout();
            foreach ( var ctrl in TagListPanel.Controls )
            {
                if ( ctrl is IDisposable )
                {
                    ( ctrl as IDisposable ).Dispose();
                }
            }
            TagListPanel.Controls.Clear();
            foreach ( var tag in ExtractTags( lang.Origin ) )
            {
                Button btn = new()
                {
                    Text = tag,
                    AutoSize = true
                };
                btn.Click += ( o, e ) =>
                {
                    var b = o as Button;
                    var t = TranslationTextBox.Text;
                    var s = TranslationTextBox.SelectionStart;
                    TranslationTextBox.Text = t.Insert( s, b.Text );
                    TranslationTextBox.SelectionStart = s + b.Text.Length;
                };
                TagListPanel.Controls.Add( btn );
            }
            TagListPanel.ResumeLayout();
        }

        private static int GetIndex( object[] array, object word )
        {
            int idx = 0;

            if ( !array.Contains( word ) )
            {
                return -1;
            }

            foreach ( object item in array )
            {
                if ( item.Equals( word ) )
                {
                    break;
                }
                idx++;
            }

            return idx;
        }

        private void CommitData( int rowNum )
        {
            var lang = LanguageData.Rows[ rowNum - 1 ];
            var idx = GetIndex( LanguageData.LangNames, LanguageComboBox.SelectedItem );

            lang.Literals[ idx ] = TranslationTextBox.Text.Replace( Environment.NewLine, @"\n" );
        }

        private static string DeleteTags( string text )
        {
            Regex xmlTagRegex = new( @"(<.*?>|@..|\[.*?\])" );

            string retVal = xmlTagRegex.Replace( text, string.Empty );

            return retVal;
        }

        private static string[] ExtractTags( string text )
        {
            Regex xmlTagRegex = new( @"({.*?}|<.*?>|@..|\[.*?\])" );

            var tags = xmlTagRegex.Matches( text );

            return ( from s in tags select s.Value ).ToArray();
        }

        private void ReferButton_Click( object sender, EventArgs e )
        {
            SwitchMode( FormMode.STAND_BY );
            Init();

            if ( OpenTargetFileDialog.ShowDialog( this ).Equals( DialogResult.OK ) )
            {
                if ( ReadCSVFile( OpenTargetFileDialog.FileName ) )
                {
                    SwitchMode( FormMode.ON_TRANSLATING );

                    FilePathTextBox.Text = OpenTargetFileDialog.FileName;
                    RowTextBox.Text = "1";
                    TotalRowTextBox.Text = LanguageData.Count.ToString();
                    LanguageComboBox.Items.AddRange( LanguageData.LangNames.Skip( 1 ).ToArray() );

                    if ( LanguageComboBox.Items.Contains( "Japanese" ) )
                    {
                        LanguageComboBox.SelectedItem = "Japanese";
                    }
                    else
                    {
                        LanguageComboBox.SelectedIndex = 0;
                    }

                    SetTranslator( int.Parse( RowTextBox.Text ) );
                }
            }
        }

        private void ToFirstButton_Click( object sender, EventArgs e )
        {
            CommitData( CurrentRow );

            RowTextBox.Text = "1";
            SetTranslator( int.Parse( RowTextBox.Text ) );
        }

        private void PreviousButton_Click( object sender, EventArgs e )
        {
            var num = int.Parse( RowTextBox.Text );
            CommitData( CurrentRow );

            if ( num > 1 )
            {
                RowTextBox.Text = ( int.Parse( RowTextBox.Text ) - 1 ).ToString();
                SetTranslator( int.Parse( RowTextBox.Text ) );
            }
        }

        private void NextButton_Click( object sender, EventArgs e )
        {
            var num = int.Parse( RowTextBox.Text );
            var max = int.Parse( TotalRowTextBox.Text );
            CommitData( CurrentRow );

            if ( num < max )
            {
                RowTextBox.Text = ( int.Parse( RowTextBox.Text ) + 1 ).ToString();
                SetTranslator( int.Parse( RowTextBox.Text ) );
            }
        }

        private void ToLastButton_Click( object sender, EventArgs e )
        {
            CommitData( CurrentRow );

            RowTextBox.Text = TotalRowTextBox.Text;
            SetTranslator( int.Parse( RowTextBox.Text ) );
        }

        private void RowTextBox_Leave( object sender, EventArgs e )
        {
            CommitData( CurrentRow );

            if ( int.TryParse( RowTextBox.Text, out int i ) )
            {
                var max = int.Parse( TotalRowTextBox.Text );
                if ( 1 <= i && i < max )
                {
                    SetTranslator( i );
                }
                else
                {
                    RowTextBox.Text = CurrentRow.ToString();
                }
            }
            else
            {
                RowTextBox.Text = CurrentRow.ToString();
            }
        }

        private void LanguageComboBox_TextChanged( object sender, EventArgs e )
        {
            if ( CurrentMode.Equals( FormMode.ON_TRANSLATING ) )
            {
                SetTranslator( int.Parse( RowTextBox.Text ) );
            }
        }

        private void TranslateButton_Click( object sender, EventArgs e )
        {
            Cursor = Cursors.WaitCursor;

            var builder = new UriBuilder( "https://api-free.deepl.com/v2/translate" );
            var query = HttpUtility.ParseQueryString( builder.Query );
            query[ "auth_key" ] = APIKeyTextBox.Text;
            query[ "text" ] = OriginTextBox.Text;
            query[ "target_lang" ] = LangListDict[ LanguageComboBox.SelectedItem.ToString() ];
            builder.Query = query.ToString();
            string url = builder.ToString();

            using var get = WebClient.GetAsync( url );
            get.Wait();

            var response = get.Result;
            if ( response.IsSuccessStatusCode )
            {
                using var read = response.Content.ReadAsStringAsync();
                read.Wait();

                var deepl = JsonSerializer.Deserialize<DeepLResponse>( read.Result );

                TranslationTextBox.Text = deepl.translations[ 0 ].text;
            }
            else
            {
                TranslationTextBox.Text = $"DeepL翻訳に失敗しました。: {response.StatusCode}";
            }

            Cursor = Cursors.Default;
        }

        private void AllTranslateButton_Click( object sender, EventArgs e )
        {
            NoticeTextBox.Text = "一括翻訳を実行中";

            var row = int.Parse( RowTextBox.Text );
            var totalRow = int.Parse( TotalRowTextBox.Text );

            // 先頭へ
            ToFirstButton.PerformClick();

            for ( int i = row ; i <= totalRow ; i++ )
            {
                // 翻訳
                TranslateButton.PerformClick();

                if ( TranslationTextBox.Text.Contains( "DeepL翻訳に失敗しました。" ) )
                {
                    break;
                }

                // 次へ
                NextButton.PerformClick();

                // 100msの待機
                Task.Delay( 100 ).Wait();
            }

            CommitData( CurrentRow );

            NoticeTextBox.Text = "PageUp : 前へ / PageDown : 次へ / Home : 先頭へ / End : 末尾へ";
        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            CommitData( CurrentRow );

            var path = Path.GetFullPath( OpenTargetFileDialog.FileName );
            var name = Path.GetFileNameWithoutExtension( OpenTargetFileDialog.FileName );
            var ext = "csv";

            SaveLangFileDialog.InitialDirectory = path;
            SaveLangFileDialog.FileName = name;
            SaveLangFileDialog.DefaultExt = ext;

            if ( SaveLangFileDialog.ShowDialog().Equals( DialogResult.OK ) )
            {
                List<string> lines = new()
                {
                    "KEY," + string.Join( ",", LanguageData.LangNames )
                };

                foreach ( var lang in LanguageData.Rows )
                {
                    var line = string.Join(
                        ",",
                        lang.Key,
                        string.Join( ",", from s in lang.Literals select s.Contains( ',' ) ? $"\"{s}\"" : s )
                    );
                    lines.Add( line );
                }

                File.WriteAllLines( SaveLangFileDialog.FileName, lines );
            }
        }

        private void MainForm_FormClosed( object sender, FormClosedEventArgs e )
        {
            WebClient?.Dispose();

            var json = JsonSerializer.Serialize( new Settings() { DeepLAPIKey = APIKeyTextBox.Text } );
            File.WriteAllText( "config.json", json, Encoding.UTF8 );
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            switch ( keyData )
            {
                case Keys.PageUp:
                    PreviousButton.PerformClick();
                    return true;
                case Keys.PageDown:
                    NextButton.PerformClick();
                    return true;
                case Keys.Home:
                    ToFirstButton.PerformClick();
                    return true;
                case Keys.End:
                    ToLastButton.PerformClick();
                    return true;
            }
            return false;
        }

        private void DeleteXmlTagButton_Click( object sender, EventArgs e )
        {
            Regex xmlTagRegex = new( @"<.*?>" );

            TranslationTextBox.Text = xmlTagRegex.Replace( TranslationTextBox.Text, string.Empty );
        }

        private void DeleteAtMarkTagButton_Click( object sender, EventArgs e )
        {

            Regex atMarkTagRegex = new( @"@.." );

            TranslationTextBox.Text = atMarkTagRegex.Replace( TranslationTextBox.Text, string.Empty );

        }

        private void DeleteTextTagButton_Click( object sender, EventArgs e )
        {
            Regex textTagRegex = new( @"\[.*?\]" );

            TranslationTextBox.Text = textTagRegex.Replace( TranslationTextBox.Text, string.Empty );
        }

        private void DeleteCenterPointButton_Click( object sender, EventArgs e )
        {
            TranslationTextBox.Text = TranslationTextBox.Text.Replace( "・", string.Empty );
        }

        private void DeleteAllTagButton_Click( object sender, EventArgs e )
        {
            NoticeTextBox.Text = "一括削除を実行中";
            Cursor = Cursors.WaitCursor;

            var row = int.Parse( RowTextBox.Text );
            var totalRow = int.Parse( TotalRowTextBox.Text );

            // 先頭へ
            ToFirstButton.PerformClick();

            for ( int i = row ; i <= totalRow ; i++ )
            {
                DeleteXmlTagButton.PerformClick();
                DeleteAtMarkTagButton.PerformClick();
                DeleteTextTagButton.PerformClick();
                DeleteCenterPointButton.PerformClick();

                // 次へ
                NextButton.PerformClick();
            }

            CommitData( CurrentRow );

            Cursor = Cursors.Default;
            NoticeTextBox.Text = "PageUp : 前へ / PageDown : 次へ / Home : 先頭へ / End : 末尾へ";
        }
    }
}