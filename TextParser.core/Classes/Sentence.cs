using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core
{
    class Sentence : Interfaces.ISentence
    {
        private Word[] _words;
        private PunctuationMark[] _punctuations;

        public Sentence(IEnumerable<Word> words, IEnumerable<PunctuationMark> punctuations)
        {
            _words = words.ToArray();
            _punctuations = punctuations.ToArray();
        }

        public Word[] Words
        {
            get { return _words; }
        }

        public PunctuationMark[] Punctuations
        {
            get { return _punctuations; }
        }

        public int Count
        {
            get
            {
                if (_words != null && _punctuations != null)
                {
                    return _words.Count() + _punctuations.Count();
                }
                else return 0;
            }
        }

        public IEnumerator<Word> GetEnumerator()
        {
            return _words.AsEnumerable().GetEnumerator();
        }

        IEnumerator<PunctuationMark> IEnumerable<PunctuationMark>.GetEnumerator()
        {
            return _punctuations.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._words.GetEnumerator();
        }
    }
}
