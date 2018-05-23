using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser.core.Classes
{
   public class Parser
    {
        public static void ParseText(String source)
        {
            if(source!=null)
            {
                Text text = new Text();
                var strings = from str in source.Split(new Char [] {'.','?','!'})
                              select str;

                var words = from word in source.Split(new Char[] { ' ', ',', '.', ':', '\t' })
                            select word;

                //text.Sentences = (ICollection<Interfaces.ISentence>)strings;
                foreach (var i in strings) Console.WriteLine(i);
                foreach (var i in words) Console.WriteLine(i);
                //"{0}.\n", strings
            }
        }
    }
}
