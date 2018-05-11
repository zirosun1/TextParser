using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core.Interfaces
{
    interface IWord: IEnumerable<Symbol>
    {
        Symbol[] Symbols { get; }
        int Lenght { get; }
    }
}
