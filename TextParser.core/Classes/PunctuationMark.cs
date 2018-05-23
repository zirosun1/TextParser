using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core
{
    class PunctuationMark : Interfaces.IPunctuationMark
    {
        private Symbol _mark;
        public Symbol Mark
        {
            get { return _mark; }
        }

        public string Value { get { return _mark.Symbols; } }

        public PunctuationMark(string symbols)
        {
            _mark = new Symbol(symbols);
        }
    }
}
