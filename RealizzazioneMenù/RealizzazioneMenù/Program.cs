using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealizzazioneMenù
{
    internal class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon
            string[] opzioni = new string[4] { "Elimina", "Sostituisci", "Inserisci", "Aggiungi" };
            int scelta;

            Menu(opzioni, out scelta); 

            switch (scelta)
            {
                case (1):
                    Console.WriteLine(opzioni[0]);
                    break;
                case (2):
                    Console.WriteLine(opzioni[1]);
                    break;
                case (3):
                    Console.WriteLine(opzioni[2]);
                    break;
                case (4):
                    Console.WriteLine(opzioni[3]);
                    break;
            }

            Console.ReadLine();
        }

        static void Menu(string[] array, out int scelta)
        {
            Console.WriteLine("MENU':");
            for (int i = 0; i< 4; i++)
            {
                Console.WriteLine($"{array[i]} [{i + 1}]");
            }
            Console.WriteLine("-----------------");

            Console.WriteLine("Inserire un opzione:");
            int.TryParse(Console.ReadLine(), out scelta);

            while (scelta< 1 || scelta > array.Length)
            {
                Console.WriteLine("Scelta non valida, reinserire: ");
                int.TryParse(Console.ReadLine(), out scelta);
            }           
        }
    }
}
