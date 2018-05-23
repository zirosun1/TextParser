using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Properties.Settings.Default.path;
            System.Console.WriteLine(FileIO.ReadFile(path));
            Console.ReadLine();
        }
    }
}
