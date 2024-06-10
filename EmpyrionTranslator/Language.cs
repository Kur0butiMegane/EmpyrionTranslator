using System.Security.Cryptography;

namespace EmpyrionTranslator
{
    internal class Language
    {
        internal class Row
        {
            private int _RowNum = -1;

            private string _Key = string.Empty;

            private string[] _Literals = Array.Empty<string>();

            internal int RowNum => _RowNum;

            internal string Key => _Key;

            internal string[] Literals => _Literals;

            internal string Origin => _Literals[0];

            internal Row(int rowNum, string[] literals)
            {
                _RowNum = rowNum;

                _Key = literals[0];

                _Literals = literals.Skip(1).ToArray();
            }
        }

        private List<Row> _Rows = new();

        private string[] _LangNames = Array.Empty<string>();

        internal List<Row> Rows => _Rows;

        internal int Count => Rows.Count;

        internal string[] LangNames => _LangNames;

        internal Language(string fpath)
        {
            var rowNum = 1;
            foreach ( var line in File.ReadAllLines( fpath ) )
            {
                var items = ParseCSV( line );

                if ( rowNum == 1 )
                {
                    _LangNames = items.Skip( 1 ).ToArray();
                }
                else
                {
                    var fields = new string[ _LangNames.Length + 1 ];

                    for ( int i = 0 ; i < fields.Length ; i++ )
                    {
                        fields[ i ] = string.Empty;
                    }

                    for ( int i = 0 ; i < fields.Length ; i++ )
                    {
                        if ( items.Length <= i )
                        {
                            break;
                        }
                        fields[ i ] = items[ i ];
                    }

                    _Rows.Add( new Row( rowNum, fields ) );
                }

                rowNum++;
            }
        }

        private static string[] ParseCSV(string csv)
        {
            var delimPosList = new List<int>();
            var inquote = false;
            var pos = 0;
            var retValList = new List<string>();

            foreach ( var c in csv )
            {
                if ( c.Equals(',') )
                {
                    if ( !inquote )
                    {
                        delimPosList.Add( pos );
                    }
                }
                else if ( c.Equals('"') )
                {
                    inquote = !inquote;
                }
                pos++;
            }
            delimPosList.Add ( pos );

            var curPos = 0;
            foreach( var p in delimPosList )
            {
                var len = p - curPos;
                retValList.Add( csv.Substring( curPos, len ).TrimStart(',').Trim('"') );
                curPos = p;
            }

            return retValList.ToArray();
        }
    }
}
