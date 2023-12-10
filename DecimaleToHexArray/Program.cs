using System;

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

            char[] convertitore = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

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

                risultato = convertitore[resto] + risultato;

                contabit--;
            } while (contabit != 0);

            Console.WriteLine("Il numero inserito in base sedici è:"); 
            Console.Write(risultato);
            Console.ReadLine();
        }
    }
}
