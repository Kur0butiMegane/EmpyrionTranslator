namespace EmpyrionTranslator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstBox =  new GroupBox() ;
            panel1 =  new Panel() ;
            FilePathTextBox =  new TextBox() ;
            ReferButton =  new Button() ;
            SecondBox =  new GroupBox() ;
            panel3 =  new Panel() ;
            SourceStringTextBox =  new TextBox() ;
            panel2 =  new Panel() ;
            KeyTextBox =  new TextBox() ;
            KeyLabel =  new Label() ;
            TotalRowTextBox =  new TextBox() ;
            SlashLabel =  new Label() ;
            ToFirstButton =  new Button() ;
            PreviousButton =  new Button() ;
            NextButton =  new Button() ;
            ToLastButton =  new Button() ;
            RowTextBox =  new TextBox() ;
            RowLabel =  new Label() ;
            ThirdBox =  new GroupBox() ;
            groupBox1 =  new GroupBox() ;
            TagListPanel =  new FlowLayoutPanel() ;
            panel6 =  new Panel() ;
            TranslationTextBox =  new TextBox() ;
            panel5 =  new Panel() ;
            APIKeyLabel =  new Label() ;
            APIKeyTextBox =  new TextBox() ;
            TranslateButton =  new Button() ;
            label2 =  new Label() ;
            DeleteAllTagButton =  new Button() ;
            label1 =  new Label() ;
            DeleteCenterPointButton =  new Button() ;
            DeleteTextTagButton =  new Button() ;
            DeleteAtMarkTagButton =  new Button() ;
            DeleteXmlTagButton =  new Button() ;
            LanguageComboBox =  new ComboBox() ;
            LanguageLabel =  new Label() ;
            AllTranslateButton =  new Button() ;
            panel4 =  new Panel() ;
            OriginTextBox =  new TextBox() ;
            FourthBox =  new GroupBox() ;
            panel7 =  new Panel() ;
            NoticeTextBox =  new TextBox() ;
            SaveButton =  new Button() ;
            OpenTargetFileDialog =  new OpenFileDialog() ;
            SaveLangFileDialog =  new SaveFileDialog() ;
            FirstBox.SuspendLayout();
            panel1.SuspendLayout();
            SecondBox.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ThirdBox.SuspendLayout();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            FourthBox.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // FirstBox
            // 
            FirstBox.Controls.Add( panel1 );
            FirstBox.Dock =  DockStyle.Top ;
            FirstBox.Location =  new Point( 8, 8 ) ;
            FirstBox.Name =  "FirstBox" ;
            FirstBox.Padding =  new Padding( 4 ) ;
            FirstBox.Size =  new Size( 1248, 49 ) ;
            FirstBox.TabIndex =  0 ;
            FirstBox.TabStop =  false ;
            FirstBox.Text =  "1. 翻訳するファイルを選択する。 / Select a file." ;
            // 
            // panel1
            // 
            panel1.Controls.Add( FilePathTextBox );
            panel1.Controls.Add( ReferButton );
            panel1.Dock =  DockStyle.Fill ;
            panel1.Location =  new Point( 4, 16 ) ;
            panel1.Name =  "panel1" ;
            panel1.Padding =  new Padding( 4 ) ;
            panel1.Size =  new Size( 1240, 29 ) ;
            panel1.TabIndex =  0 ;
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Dock =  DockStyle.Fill ;
            FilePathTextBox.Location =  new Point( 4, 4 ) ;
            FilePathTextBox.Name =  "FilePathTextBox" ;
            FilePathTextBox.ReadOnly =  true ;
            FilePathTextBox.Size =  new Size( 1184, 19 ) ;
            FilePathTextBox.TabIndex =  0 ;
            FilePathTextBox.Text =  "C:/ABC/123/XYZ/abc.csv" ;
            // 
            // ReferButton
            // 
            ReferButton.Dock =  DockStyle.Right ;
            ReferButton.Location =  new Point( 1188, 4 ) ;
            ReferButton.Name =  "ReferButton" ;
            ReferButton.Size =  new Size( 48, 21 ) ;
            ReferButton.TabIndex =  1 ;
            ReferButton.Text =  "参照" ;
            ReferButton.UseVisualStyleBackColor =  true ;
            ReferButton.Click +=  ReferButton_Click ;
            // 
            // SecondBox
            // 
            SecondBox.Controls.Add( panel3 );
            SecondBox.Controls.Add( panel2 );
            SecondBox.Dock =  DockStyle.Top ;
            SecondBox.Location =  new Point( 8, 57 ) ;
            SecondBox.Name =  "SecondBox" ;
            SecondBox.Padding =  new Padding( 4 ) ;
            SecondBox.Size =  new Size( 1248, 165 ) ;
            SecondBox.TabIndex =  1 ;
            SecondBox.TabStop =  false ;
            SecondBox.Text =  "2. 翻訳する対象原文を選択する。 / Select the source text to be translated." ;
            // 
            // panel3
            // 
            panel3.Controls.Add( SourceStringTextBox );
            panel3.Dock =  DockStyle.Fill ;
            panel3.Location =  new Point( 4, 45 ) ;
            panel3.Name =  "panel3" ;
            panel3.Padding =  new Padding( 4 ) ;
            panel3.Size =  new Size( 1240, 116 ) ;
            panel3.TabIndex =  1 ;
            // 
            // SourceStringTextBox
            // 
            SourceStringTextBox.Dock =  DockStyle.Fill ;
            SourceStringTextBox.Location =  new Point( 4, 4 ) ;
            SourceStringTextBox.Multiline =  true ;
            SourceStringTextBox.Name =  "SourceStringTextBox" ;
            SourceStringTextBox.ReadOnly =  true ;
            SourceStringTextBox.ScrollBars =  ScrollBars.Vertical ;
            SourceStringTextBox.Size =  new Size( 1232, 108 ) ;
            SourceStringTextBox.TabIndex =  0 ;
            SourceStringTextBox.Text =  "abcXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXabcXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\ndef\r\nghi\r\njkl\r\nmno" ;
            // 
            // panel2
            // 
            panel2.Controls.Add( KeyTextBox );
            panel2.Controls.Add( KeyLabel );
            panel2.Controls.Add( TotalRowTextBox );
            panel2.Controls.Add( SlashLabel );
            panel2.Controls.Add( ToFirstButton );
            panel2.Controls.Add( PreviousButton );
            panel2.Controls.Add( NextButton );
            panel2.Controls.Add( ToLastButton );
            panel2.Controls.Add( RowTextBox );
            panel2.Controls.Add( RowLabel );
            panel2.Dock =  DockStyle.Top ;
            panel2.Location =  new Point( 4, 16 ) ;
            panel2.Name =  "panel2" ;
            panel2.Padding =  new Padding( 4 ) ;
            panel2.Size =  new Size( 1240, 29 ) ;
            panel2.TabIndex =  0 ;
            // 
            // KeyTextBox
            // 
            KeyTextBox.Dock =  DockStyle.Left ;
            KeyTextBox.Location =  new Point( 169, 4 ) ;
            KeyTextBox.Name =  "KeyTextBox" ;
            KeyTextBox.ReadOnly =  true ;
            KeyTextBox.Size =  new Size( 200, 19 ) ;
            KeyTextBox.TabIndex =  5 ;
            KeyTextBox.Text =  "dialogue_traderSplit2b" ;
            KeyTextBox.TextAlign =  HorizontalAlignment.Center ;
            // 
            // KeyLabel
            // 
            KeyLabel.Dock =  DockStyle.Left ;
            KeyLabel.Location =  new Point( 140, 4 ) ;
            KeyLabel.Name =  "KeyLabel" ;
            KeyLabel.Size =  new Size( 29, 21 ) ;
            KeyLabel.TabIndex =  4 ;
            KeyLabel.Text =  "KEY:" ;
            KeyLabel.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // TotalRowTextBox
            // 
            TotalRowTextBox.Dock =  DockStyle.Left ;
            TotalRowTextBox.Location =  new Point( 92, 4 ) ;
            TotalRowTextBox.Name =  "TotalRowTextBox" ;
            TotalRowTextBox.ReadOnly =  true ;
            TotalRowTextBox.Size =  new Size( 48, 19 ) ;
            TotalRowTextBox.TabIndex =  3 ;
            TotalRowTextBox.Text =  "123456" ;
            TotalRowTextBox.TextAlign =  HorizontalAlignment.Center ;
            // 
            // SlashLabel
            // 
            SlashLabel.Dock =  DockStyle.Left ;
            SlashLabel.Location =  new Point( 81, 4 ) ;
            SlashLabel.Name =  "SlashLabel" ;
            SlashLabel.Size =  new Size( 11, 21 ) ;
            SlashLabel.TabIndex =  2 ;
            SlashLabel.Text =  "/" ;
            SlashLabel.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // ToFirstButton
            // 
            ToFirstButton.Dock =  DockStyle.Right ;
            ToFirstButton.Location =  new Point( 1044, 4 ) ;
            ToFirstButton.Name =  "ToFirstButton" ;
            ToFirstButton.Size =  new Size( 48, 21 ) ;
            ToFirstButton.TabIndex =  6 ;
            ToFirstButton.Text =  "<<" ;
            ToFirstButton.UseVisualStyleBackColor =  true ;
            ToFirstButton.Click +=  ToFirstButton_Click ;
            // 
            // PreviousButton
            // 
            PreviousButton.Dock =  DockStyle.Right ;
            PreviousButton.Location =  new Point( 1092, 4 ) ;
            PreviousButton.Name =  "PreviousButton" ;
            PreviousButton.Size =  new Size( 48, 21 ) ;
            PreviousButton.TabIndex =  7 ;
            PreviousButton.Text =  "<" ;
            PreviousButton.UseVisualStyleBackColor =  true ;
            PreviousButton.Click +=  PreviousButton_Click ;
            // 
            // NextButton
            // 
            NextButton.Dock =  DockStyle.Right ;
            NextButton.Location =  new Point( 1140, 4 ) ;
            NextButton.Name =  "NextButton" ;
            NextButton.Size =  new Size( 48, 21 ) ;
            NextButton.TabIndex =  8 ;
            NextButton.Text =  ">" ;
            NextButton.UseVisualStyleBackColor =  true ;
            NextButton.Click +=  NextButton_Click ;
            // 
            // ToLastButton
            // 
            ToLastButton.Dock =  DockStyle.Right ;
            ToLastButton.Location =  new Point( 1188, 4 ) ;
            ToLastButton.Name =  "ToLastButton" ;
            ToLastButton.Size =  new Size( 48, 21 ) ;
            ToLastButton.TabIndex =  9 ;
            ToLastButton.Text =  ">>" ;
            ToLastButton.UseVisualStyleBackColor =  true ;
            ToLastButton.Click +=  ToLastButton_Click ;
            // 
            // RowTextBox
            // 
            RowTextBox.Dock =  DockStyle.Left ;
            RowTextBox.Location =  new Point( 33, 4 ) ;
            RowTextBox.Name =  "RowTextBox" ;
            RowTextBox.Size =  new Size( 48, 19 ) ;
            RowTextBox.TabIndex =  1 ;
            RowTextBox.Text =  "123456" ;
            RowTextBox.TextAlign =  HorizontalAlignment.Center ;
            RowTextBox.Leave +=  RowTextBox_Leave ;
            // 
            // RowLabel
            // 
            RowLabel.Dock =  DockStyle.Left ;
            RowLabel.Location =  new Point( 4, 4 ) ;
            RowLabel.Name =  "RowLabel" ;
            RowLabel.Size =  new Size( 29, 21 ) ;
            RowLabel.TabIndex =  0 ;
            RowLabel.Text =  "ROW:" ;
            RowLabel.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // ThirdBox
            // 
            ThirdBox.Controls.Add( groupBox1 );
            ThirdBox.Controls.Add( panel6 );
            ThirdBox.Controls.Add( panel5 );
            ThirdBox.Controls.Add( panel4 );
            ThirdBox.Dock =  DockStyle.Fill ;
            ThirdBox.Location =  new Point( 8, 222 ) ;
            ThirdBox.Name =  "ThirdBox" ;
            ThirdBox.Padding =  new Padding( 4 ) ;
            ThirdBox.Size =  new Size( 1248, 402 ) ;
            ThirdBox.TabIndex =  2 ;
            ThirdBox.TabStop =  false ;
            ThirdBox.Text =  "3. 翻訳する。 / Translation." ;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add( TagListPanel );
            groupBox1.Dock =  DockStyle.Fill ;
            groupBox1.Location =  new Point( 4, 277 ) ;
            groupBox1.Name =  "groupBox1" ;
            groupBox1.Padding =  new Padding( 4 ) ;
            groupBox1.Size =  new Size( 1240, 121 ) ;
            groupBox1.TabIndex =  4 ;
            groupBox1.TabStop =  false ;
            groupBox1.Text =  "タグリスト / Tag list" ;
            // 
            // TagListPanel
            // 
            TagListPanel.Dock =  DockStyle.Fill ;
            TagListPanel.Location =  new Point( 4, 16 ) ;
            TagListPanel.Name =  "TagListPanel" ;
            TagListPanel.Size =  new Size( 1232, 101 ) ;
            TagListPanel.TabIndex =  3 ;
            // 
            // panel6
            // 
            panel6.Controls.Add( TranslationTextBox );
            panel6.Dock =  DockStyle.Top ;
            panel6.Location =  new Point( 4, 161 ) ;
            panel6.Name =  "panel6" ;
            panel6.Padding =  new Padding( 4 ) ;
            panel6.Size =  new Size( 1240, 116 ) ;
            panel6.TabIndex =  2 ;
            // 
            // TranslationTextBox
            // 
            TranslationTextBox.Dock =  DockStyle.Fill ;
            TranslationTextBox.Location =  new Point( 4, 4 ) ;
            TranslationTextBox.Multiline =  true ;
            TranslationTextBox.Name =  "TranslationTextBox" ;
            TranslationTextBox.ScrollBars =  ScrollBars.Vertical ;
            TranslationTextBox.Size =  new Size( 1232, 108 ) ;
            TranslationTextBox.TabIndex =  0 ;
            TranslationTextBox.Text =  "aaa\r\nbbb\r\nccc\r\nddd\r\neee" ;
            // 
            // panel5
            // 
            panel5.Controls.Add( APIKeyLabel );
            panel5.Controls.Add( APIKeyTextBox );
            panel5.Controls.Add( TranslateButton );
            panel5.Controls.Add( label2 );
            panel5.Controls.Add( DeleteAllTagButton );
            panel5.Controls.Add( label1 );
            panel5.Controls.Add( DeleteCenterPointButton );
            panel5.Controls.Add( DeleteTextTagButton );
            panel5.Controls.Add( DeleteAtMarkTagButton );
            panel5.Controls.Add( DeleteXmlTagButton );
            panel5.Controls.Add( LanguageComboBox );
            panel5.Controls.Add( LanguageLabel );
            panel5.Controls.Add( AllTranslateButton );
            panel5.Dock =  DockStyle.Top ;
            panel5.Location =  new Point( 4, 132 ) ;
            panel5.Name =  "panel5" ;
            panel5.Padding =  new Padding( 4 ) ;
            panel5.Size =  new Size( 1240, 29 ) ;
            panel5.TabIndex =  1 ;
            // 
            // APIKeyLabel
            // 
            APIKeyLabel.Dock =  DockStyle.Right ;
            APIKeyLabel.Location =  new Point( 851, 4 ) ;
            APIKeyLabel.Name =  "APIKeyLabel" ;
            APIKeyLabel.Size =  new Size( 53, 21 ) ;
            APIKeyLabel.TabIndex =  100 ;
            APIKeyLabel.Text =  "API Key:" ;
            APIKeyLabel.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // APIKeyTextBox
            // 
            APIKeyTextBox.Dock =  DockStyle.Right ;
            APIKeyTextBox.Location =  new Point( 904, 4 ) ;
            APIKeyTextBox.Name =  "APIKeyTextBox" ;
            APIKeyTextBox.PasswordChar =  '*' ;
            APIKeyTextBox.Size =  new Size( 160, 19 ) ;
            APIKeyTextBox.TabIndex =  101 ;
            APIKeyTextBox.TextAlign =  HorizontalAlignment.Center ;
            // 
            // TranslateButton
            // 
            TranslateButton.Dock =  DockStyle.Right ;
            TranslateButton.Location =  new Point( 1064, 4 ) ;
            TranslateButton.Name =  "TranslateButton" ;
            TranslateButton.Size =  new Size( 72, 21 ) ;
            TranslateButton.TabIndex =  102 ;
            TranslateButton.Text =  "DeepL翻訳" ;
            TranslateButton.UseVisualStyleBackColor =  true ;
            TranslateButton.Click +=  TranslateButton_Click ;
            // 
            // label2
            // 
            label2.Dock =  DockStyle.Right ;
            label2.Location =  new Point( 1136, 4 ) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size( 11, 21 ) ;
            label2.TabIndex =  103 ;
            label2.Text =  ":" ;
            label2.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // DeleteAllTagButton
            // 
            DeleteAllTagButton.AutoSize =  true ;
            DeleteAllTagButton.AutoSizeMode =  AutoSizeMode.GrowAndShrink ;
            DeleteAllTagButton.Dock =  DockStyle.Left ;
            DeleteAllTagButton.Location =  new Point( 528, 4 ) ;
            DeleteAllTagButton.Name =  "DeleteAllTagButton" ;
            DeleteAllTagButton.Size =  new Size( 87, 21 ) ;
            DeleteAllTagButton.TabIndex =  99 ;
            DeleteAllTagButton.Text =  "削除一括適用" ;
            DeleteAllTagButton.UseVisualStyleBackColor =  true ;
            DeleteAllTagButton.Click +=  DeleteAllTagButton_Click ;
            // 
            // label1
            // 
            label1.Dock =  DockStyle.Left ;
            label1.Location =  new Point( 517, 4 ) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size( 11, 21 ) ;
            label1.TabIndex =  98 ;
            label1.Text =  ":" ;
            label1.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // DeleteCenterPointButton
            // 
            DeleteCenterPointButton.AutoSize =  true ;
            DeleteCenterPointButton.AutoSizeMode =  AutoSizeMode.GrowAndShrink ;
            DeleteCenterPointButton.Dock =  DockStyle.Left ;
            DeleteCenterPointButton.Location =  new Point( 454, 4 ) ;
            DeleteCenterPointButton.Name =  "DeleteCenterPointButton" ;
            DeleteCenterPointButton.Size =  new Size( 63, 21 ) ;
            DeleteCenterPointButton.TabIndex =  13 ;
            DeleteCenterPointButton.Text =  "削除: ・" ;
            DeleteCenterPointButton.UseVisualStyleBackColor =  true ;
            DeleteCenterPointButton.Click +=  DeleteCenterPointButton_Click ;
            // 
            // DeleteTextTagButton
            // 
            DeleteTextTagButton.AutoSize =  true ;
            DeleteTextTagButton.AutoSizeMode =  AutoSizeMode.GrowAndShrink ;
            DeleteTextTagButton.Dock =  DockStyle.Left ;
            DeleteTextTagButton.Location =  new Point( 373, 4 ) ;
            DeleteTextTagButton.Name =  "DeleteTextTagButton" ;
            DeleteTextTagButton.Size =  new Size( 81, 21 ) ;
            DeleteTextTagButton.TabIndex =  12 ;
            DeleteTextTagButton.Text =  "削除: [.*?]" ;
            DeleteTextTagButton.UseVisualStyleBackColor =  true ;
            DeleteTextTagButton.Click +=  DeleteTextTagButton_Click ;
            // 
            // DeleteAtMarkTagButton
            // 
            DeleteAtMarkTagButton.AutoSize =  true ;
            DeleteAtMarkTagButton.AutoSizeMode =  AutoSizeMode.GrowAndShrink ;
            DeleteAtMarkTagButton.Dock =  DockStyle.Left ;
            DeleteAtMarkTagButton.Location =  new Point( 304, 4 ) ;
            DeleteAtMarkTagButton.Name =  "DeleteAtMarkTagButton" ;
            DeleteAtMarkTagButton.Size =  new Size( 69, 21 ) ;
            DeleteAtMarkTagButton.TabIndex =  11 ;
            DeleteAtMarkTagButton.Text =  "削除: @.." ;
            DeleteAtMarkTagButton.UseVisualStyleBackColor =  true ;
            DeleteAtMarkTagButton.Click +=  DeleteAtMarkTagButton_Click ;
            // 
            // DeleteXmlTagButton
            // 
            DeleteXmlTagButton.AutoSize =  true ;
            DeleteXmlTagButton.AutoSizeMode =  AutoSizeMode.GrowAndShrink ;
            DeleteXmlTagButton.Dock =  DockStyle.Left ;
            DeleteXmlTagButton.Location =  new Point( 223, 4 ) ;
            DeleteXmlTagButton.Name =  "DeleteXmlTagButton" ;
            DeleteXmlTagButton.Size =  new Size( 81, 21 ) ;
            DeleteXmlTagButton.TabIndex =  10 ;
            DeleteXmlTagButton.Text =  "削除: <.*?>" ;
            DeleteXmlTagButton.UseVisualStyleBackColor =  true ;
            DeleteXmlTagButton.Click +=  DeleteXmlTagButton_Click ;
            // 
            // LanguageComboBox
            // 
            LanguageComboBox.Dock =  DockStyle.Left ;
            LanguageComboBox.FormattingEnabled =  true ;
            LanguageComboBox.Location =  new Point( 63, 4 ) ;
            LanguageComboBox.Name =  "LanguageComboBox" ;
            LanguageComboBox.Size =  new Size( 160, 20 ) ;
            LanguageComboBox.TabIndex =  1 ;
            LanguageComboBox.Text =  "Japanese" ;
            LanguageComboBox.TextChanged +=  LanguageComboBox_TextChanged ;
            // 
            // LanguageLabel
            // 
            LanguageLabel.Dock =  DockStyle.Left ;
            LanguageLabel.Location =  new Point( 4, 4 ) ;
            LanguageLabel.Name =  "LanguageLabel" ;
            LanguageLabel.Size =  new Size( 59, 21 ) ;
            LanguageLabel.TabIndex =  0 ;
            LanguageLabel.Text =  "Language:" ;
            LanguageLabel.TextAlign =  ContentAlignment.MiddleLeft ;
            // 
            // AllTranslateButton
            // 
            AllTranslateButton.AutoSize =  true ;
            AllTranslateButton.Dock =  DockStyle.Right ;
            AllTranslateButton.Location =  new Point( 1147, 4 ) ;
            AllTranslateButton.Name =  "AllTranslateButton" ;
            AllTranslateButton.Size =  new Size( 89, 21 ) ;
            AllTranslateButton.TabIndex =  104 ;
            AllTranslateButton.Text =  "全行一括翻訳" ;
            AllTranslateButton.UseVisualStyleBackColor =  true ;
            AllTranslateButton.Click +=  AllTranslateButton_Click ;
            // 
            // panel4
            // 
            panel4.Controls.Add( OriginTextBox );
            panel4.Dock =  DockStyle.Top ;
            panel4.Location =  new Point( 4, 16 ) ;
            panel4.Name =  "panel4" ;
            panel4.Padding =  new Padding( 4 ) ;
            panel4.Size =  new Size( 1240, 116 ) ;
            panel4.TabIndex =  0 ;
            // 
            // OriginTextBox
            // 
            OriginTextBox.Dock =  DockStyle.Fill ;
            OriginTextBox.Location =  new Point( 4, 4 ) ;
            OriginTextBox.Multiline =  true ;
            OriginTextBox.Name =  "OriginTextBox" ;
            OriginTextBox.ReadOnly =  true ;
            OriginTextBox.ScrollBars =  ScrollBars.Vertical ;
            OriginTextBox.Size =  new Size( 1232, 108 ) ;
            OriginTextBox.TabIndex =  0 ;
            OriginTextBox.Text =  "aaa\r\nbbb\r\nccc\r\nddd\r\neee" ;
            // 
            // FourthBox
            // 
            FourthBox.Controls.Add( panel7 );
            FourthBox.Dock =  DockStyle.Bottom ;
            FourthBox.Location =  new Point( 8, 624 ) ;
            FourthBox.Name =  "FourthBox" ;
            FourthBox.Padding =  new Padding( 4 ) ;
            FourthBox.Size =  new Size( 1248, 49 ) ;
            FourthBox.TabIndex =  3 ;
            FourthBox.TabStop =  false ;
            FourthBox.Text =  "4. 保存する。 / Save file." ;
            // 
            // panel7
            // 
            panel7.Controls.Add( NoticeTextBox );
            panel7.Controls.Add( SaveButton );
            panel7.Dock =  DockStyle.Fill ;
            panel7.Location =  new Point( 4, 16 ) ;
            panel7.Name =  "panel7" ;
            panel7.Padding =  new Padding( 4 ) ;
            panel7.Size =  new Size( 1240, 29 ) ;
            panel7.TabIndex =  0 ;
            // 
            // NoticeTextBox
            // 
            NoticeTextBox.Dock =  DockStyle.Fill ;
            NoticeTextBox.Location =  new Point( 4, 4 ) ;
            NoticeTextBox.Name =  "NoticeTextBox" ;
            NoticeTextBox.ReadOnly =  true ;
            NoticeTextBox.Size =  new Size( 1184, 19 ) ;
            NoticeTextBox.TabIndex =  1 ;
            // 
            // SaveButton
            // 
            SaveButton.Dock =  DockStyle.Right ;
            SaveButton.Location =  new Point( 1188, 4 ) ;
            SaveButton.Name =  "SaveButton" ;
            SaveButton.Size =  new Size( 48, 21 ) ;
            SaveButton.TabIndex =  99 ;
            SaveButton.Text =  "保存" ;
            SaveButton.UseVisualStyleBackColor =  true ;
            SaveButton.Click +=  SaveButton_Click ;
            // 
            // OpenTargetFileDialog
            // 
            OpenTargetFileDialog.FileName =  "openFileDialog1" ;
            // 
            // MainForm
            // 
            AutoScaleMode =  AutoScaleMode.None ;
            ClientSize =  new Size( 1264, 681 ) ;
            Controls.Add( ThirdBox );
            Controls.Add( FourthBox );
            Controls.Add( SecondBox );
            Controls.Add( FirstBox );
            Font =  new Font( "BIZ UDゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point ) ;
            Margin =  new Padding( 3, 2, 3, 2 ) ;
            Name =  "MainForm" ;
            Padding =  new Padding( 8 ) ;
            Text =  "EmpyrionTranslator" ;
            FormClosed +=  MainForm_FormClosed ;
            FirstBox.ResumeLayout( false );
            panel1.ResumeLayout( false );
            panel1.PerformLayout();
            SecondBox.ResumeLayout( false );
            panel3.ResumeLayout( false );
            panel3.PerformLayout();
            panel2.ResumeLayout( false );
            panel2.PerformLayout();
            ThirdBox.ResumeLayout( false );
            groupBox1.ResumeLayout( false );
            panel6.ResumeLayout( false );
            panel6.PerformLayout();
            panel5.ResumeLayout( false );
            panel5.PerformLayout();
            panel4.ResumeLayout( false );
            panel4.PerformLayout();
            FourthBox.ResumeLayout( false );
            panel7.ResumeLayout( false );
            panel7.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private GroupBox FirstBox;
        private Panel panel1;
        private TextBox FilePathTextBox;
        private Button ReferButton;
        private GroupBox SecondBox;
        private Panel panel3;
        private TextBox SourceStringTextBox;
        private Panel panel2;
        private TextBox KeyTextBox;
        private Label KeyLabel;
        private TextBox TotalRowTextBox;
        private Label SlashLabel;
        private Button ToFirstButton;
        private Button PreviousButton;
        private Button NextButton;
        private Button ToLastButton;
        private TextBox RowTextBox;
        private Label RowLabel;
        private GroupBox ThirdBox;
        private Panel panel6;
        private TextBox TranslationTextBox;
        private Panel panel5;
        private Label APIKeyLabel;
        private TextBox APIKeyTextBox;
        private Button TranslateButton;
        private ComboBox LanguageComboBox;
        private Label LanguageLabel;
        private Panel panel4;
        private TextBox OriginTextBox;
        private GroupBox FourthBox;
        private Panel panel7;
        private Button SaveButton;
        private OpenFileDialog OpenTargetFileDialog;
        private FlowLayoutPanel TagListPanel;
        private SaveFileDialog SaveLangFileDialog;
        private GroupBox groupBox1;
        private Button AllTranslateButton;
        private TextBox NoticeTextBox;
        private Button DeleteXmlTagButton;
        private Button DeleteAtMarkTagButton;
        private Button DeleteTextTagButton;
        private Button DeleteCenterPointButton;
        private Button DeleteAllTagButton;
        private Label label2;
        private Label label1;
    }
}