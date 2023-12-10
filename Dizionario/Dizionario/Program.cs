using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            string parola = "";
            char car;
            string[] dizionario = new string[4];

            Console.WriteLine("Inserisci le parole da inserire nel dizionario: ");
            do
            {
                car = Convert.ToChar(Console.Read());


                if (car != 13 && car != ' ')
                {
                    parola = parola + car;
                }
                else if (p < 4)
                {
                    dizionario[p] = parola;
                    parola = "";
                    p++;
                }

            } while (car != 13);

            for (int i = 0; i < p; i++)
            {
                Console.WriteLine(dizionario[i]);
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}