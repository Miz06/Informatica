using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1pg190
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUM;
            int numero;
            int somma = 0;    

            Console.WriteLine("Inserire il numero di numeri che si desidera sommare:");
            NUM = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NUM; i++)
            {
                Console.WriteLine("Inserire un numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                somma = somma + numero;
            }

            Console.WriteLine($"La somma dei {NUM} numeri inseriti è {somma}");
            Console.ReadLine();
        }
    }
}
