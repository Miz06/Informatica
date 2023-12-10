using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_decimale_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string indirizzo, str3 = "";
            int num, c = 7;
            int[] numero = new int[8]; 

            Console.WriteLine("Inserire un indirizzo IP:");
            num = Convert.ToInt32(Console.ReadLine()); 

            do
            {
                str3 = num % 2 + str3;
                num = num / 2; 

            } while (num >= 1);

            Console.WriteLine(str3); 
            Console.ReadLine();
        }
    }
}