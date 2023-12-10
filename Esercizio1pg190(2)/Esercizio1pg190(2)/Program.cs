using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1pg190_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUM;
            int somma = 0;

            Console.WriteLine("Inserire il numero di cui si desidera realizzare la somma dei numeri minori o uguali ad esso:"); 
            NUM = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= NUM; i++)
            {
                somma = somma + i;
            }

            Console.WriteLine($"La somma dei numeri minori o uguali al numero inserito è {somma}");
            Console.ReadLine(); 
        }
    }
}
