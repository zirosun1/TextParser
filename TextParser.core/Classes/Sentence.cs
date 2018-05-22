using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.core.Classes;
using TextParser.core.Interfaces;

namespace TextParser.core
{
    class Sentence : Interfaces.ISentence
    {
  
        private ICollection<Interfaces.ISentenceItem> _sentenceItems;
        public Sentence(IEnumerable<ISentenceItem> items)
        {
            foreach (var i in items)
                _sentenceItems.Add(i);
        }

        public ICollection<ISentenceItem> SentenceItems
        {
            get { return _sentenceItems;  }
        }

        public int Count => _sentenceItems.Count();

        public bool IsReadOnly => _sentenceItems.IsReadOnly;

        public void Add(ISentenceItem item)
        {
            _sentenceItems.Add(item);
        }

        public void Clear()
        {
            _sentenceItems.Clear();
        }

        public bool Contains(ISentenceItem item)
        {
            return _sentenceItems.Contains(item);
        }

        public void CopyTo(ISentenceItem[] array, int arrayIndex)
        {
            _sentenceItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ISentenceItem> GetEnumerator()
        {
            return _sentenceItems.GetEnumerator();
        }

        public bool Remove(ISentenceItem item)
        {
            return _sentenceItems.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sentenceItems.GetEnumerator();
        }
    }
}
