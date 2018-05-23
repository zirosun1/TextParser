using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.core.Interfaces;

namespace TextParser.core.Classes
{
    class Text
    {
        ICollection<ISentence> _sentences;
        public ICollection<Interfaces.ISentence> Sentences
        {
            get { return _sentences; }
            set { _sentences = value; }
        }


       public Text()
        {
            _sentences = new List<ISentence>();
        }


    }
}
