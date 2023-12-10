using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimale_to_hex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che permetta di convertire un valore decimale nel range 0-15
            //in un valore esadecimale.

            //Per risolvere l'esercizio bisogna considerare le cifre da 10 a 15 in esadecimale
            //corrispondono ai valori A B C D E F,
            //senza usare convert to hex.

            //Scrivere un programma che permetta di convertere un valore decimale nel range (0-255)
            //in esadecimale utilizzando una delle strategie viste in classe.

            int num, resto, contabit = 8;
            string risultato = "";

            do
            {
                Console.WriteLine("Inserire un numero esadecimale nel range 0 - 255:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 255)
                {
                    Console.WriteLine("Out of range");
                }
            } while (num < 0 || num > 255);

            do
            {
                resto = num % 16;
                num = num / 16;
                switch (resto)
                {
                    case (10):
                        risultato = 'A' + risultato;
                        break;

                    case (11):
                        risultato = 'B' + risultato;
                        break;

                    case (12):
                        risultato = 'C' + risultato;
                        break;

                    case (13):
                        risultato = 'D' + risultato;
                        break;
                    case (14):
                        risultato = 'E' + risultato;
                        break;

                    case (15):
                        risultato = 'F' + risultato;
                        break;

                    default:
                        risultato = resto + risultato;
                        break; 
                }
                contabit--;
            } while (contabit != 0);

            Console.Write(risultato);
            Console.ReadLine();
        }
    }
}
