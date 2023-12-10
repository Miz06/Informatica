using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laScuolaElementare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine($"Inserire il nome del {i + 1}° bambino");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Premere invio per tornare al menu principale"); 
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("CLASSE 3E");
                for (int e = 0; e < i + 1; e++)
                {
                    Console.WriteLine($"{e + 1} {nome[e]}");
                }
                if (i != 2)
                {
                    Console.WriteLine("Premere invio per tornare ad inserire i nomi dei bambini della classe");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadLine(); 
        }
    }
}
