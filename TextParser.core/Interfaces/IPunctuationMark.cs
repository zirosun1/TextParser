﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core.Interfaces
{
    interface IPunctuationMark: ISentenceItem
    {
        Symbol Mark { get; }
    }
}
