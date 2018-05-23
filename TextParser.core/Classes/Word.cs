using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core
{
    class Word : Interfaces.IWord
    {
        private Symbol[] _symbols;
        public Symbol[] Symbols
        {
            get { return _symbols; }
        }

        public Word(string symbols)
        {
            if (symbols != null)
            {
                _symbols = symbols.Select(x => new Symbol(x)).ToArray();
            }
            else
            {
                _symbols = null;
            }
        }

        public Word(IEnumerable<Symbol> symbols)
        {
            _symbols = symbols.ToArray();
        }

        public int Lenght
        {
            get { return (_symbols != null) ? _symbols.Length : 0; }
        }

        public string Value { get {
                StringBuilder sb = new StringBuilder();
                foreach (var s in this._symbols)
                {
                    sb.Append(s.Symbols);
                }
                return sb.ToString();
            }
        }

        public IEnumerator<Symbol> GetEnumerator()
        {
            return _symbols.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._symbols.GetEnumerator();
        }
    }
}
