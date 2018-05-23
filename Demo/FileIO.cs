using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo
{
    static class FileIO
    {
        public static string ReadFile(string path)
        {
            try
            {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        return  sr.ReadToEnd();
                    }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
