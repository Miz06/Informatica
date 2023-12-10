using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodiLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void GetFiles(string directory)
        {
            string[] files;
            files = Directory.GetFiles(Environment.CurrentDirectory);
        }
    }
}
