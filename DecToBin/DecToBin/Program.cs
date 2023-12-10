using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string indirizzo, str3;
            int num, c = 7;
            int[] numero = new int[8];

            Console.WriteLine("Inserire un indirizzo IP:");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (num % 2 == 0)
                {
                    numero[c] = 0;
                    num = num / 2;
                }
                else
                {
                    numero[c] = 1;
                    num = (num - 1) / 2;
                }
                c--;
            } while (num >= 1);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numero[i]);
            }
            Console.ReadLine();
        }
    }
}
