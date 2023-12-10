using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eserciziopg180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tp;
            int numero; 

            Console.WriteLine("Inserire il numero di cui eseguire la tabellina pitagorica:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La tabellina del {numero} è: ");

            for (int i = 1; i <= 10; i++)
            {
                tp = numero * i;
                Console.WriteLine($"{tp}");
            }

            Console.ReadLine(); 
        }
    }
}
