using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextParser.core.Classes
{
    class Parser
    {
        string _text;
        public void ReadFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        _text = sr.ReadToEnd();
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ParseText(String text)
        {
            Sentence[] sentences = text.Split(new char[] { '.', '?', '!' });
        }


    }
}
