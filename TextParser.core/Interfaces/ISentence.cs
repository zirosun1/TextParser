using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core.Interfaces
{
    interface ISentence: IEnumerable<Word>, IEnumerable<PunctuationMark>
    {
        Word[] Words { get; }
        int Count { get; }
    }
}
