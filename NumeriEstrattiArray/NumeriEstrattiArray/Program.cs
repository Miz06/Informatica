using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeriEstrattiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Alessandro Mizzon
            Estrarre 10 numeri casuali nel range 0-9 e:
            1 - stampare i valori che non sono usciti.
            2 - stampare i valori usciti e non usciti(in modo che l'utente capisca quali sono le due tipologia)*/

            int numEstratto;
            string numeriNonEstratti = "";
            char[] array = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random randomico = new Random();

            Console.WriteLine("Premere invio per avviare l'estrazione dei numeri");
            Console.ReadLine();
            Console.Write("Numeri estratti: ");

            for (int i = 0; i < 10; i++)
            {
                numEstratto = randomico.Next(0, 9);
                Console.Write(numEstratto);
                array[numEstratto] = 'a';
            }

            Console.WriteLine();
            
            for (int e = 0; e < 10; e++)
            {
                if (array[e] != 'a')
                {
                    numeriNonEstratti = array[e] + numeriNonEstratti;
                }
            }

            if (numeriNonEstratti == "")
            {
                Console.WriteLine("Sono stati estratti tutti i numeri");
            }
            else
            {
                Console.WriteLine($"Numeri non estratti: {numeriNonEstratti}");
            }

            Console.ReadLine();
        }
    }
}
