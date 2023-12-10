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
            //Dato un numero in base 10 nel range 0 - 255 convertirlo in base 2. 

            int indirizzo, i = 0;
            int[] binario;
            binario = new int[256];

            do
            {
                Console.WriteLine("Inserire un numero in base 10 nel range 0 - 255:");
                indirizzo = Convert.ToInt32(Console.ReadLine());
            } while (indirizzo < 0 || indirizzo > 255);

            do
            {
                if (indirizzo % 2 == 0)
                {
                    binario[i] = 0;
                    indirizzo = indirizzo / 2;
                }
                else
                {
                    binario[i] = 1;
                    indirizzo = (indirizzo - 1) / 2;
                }

                i = i + 1;
            } while (indirizzo >= 1);

            for (int t = 0; t < 8 - i; t++)
            {
                Console.Write(0);
            }

            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binario[i]);
            }

            Console.ReadLine();
        }
    }
}