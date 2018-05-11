using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core
{
    public class Symbol
    {
        private string _symbols;
        public string Symbols
        {
            get { return _symbols; }
            private set { _symbols = value; }
        }
        public Symbol(string symbols)
        {
            _symbols = symbols;
        }
        public Symbol(char symbol)
        {
            _symbols = String.Format("{0}", symbol);
        }
    }
}
