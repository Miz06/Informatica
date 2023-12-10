using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preverifica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string frase = "Oggi la mamma di il vise";
            // Console.WriteLine(frase.Substring(5));
            string[] mioarray = new string[3] { "calcio", "rugby", "pugilato" };
            Console.WriteLine(String.Join("MIPIACELAPATATANAOLETANA", mioarray));

            Console.ReadLine(); 
        }
    }
}
