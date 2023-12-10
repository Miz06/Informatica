using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2_ripasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bas, altezza, x, y;

            do
            {
                Console.WriteLine("Inserire la base del rettangolo:");
                bas = Convert.ToInt32(Console.ReadLine());
                if (bas < 3 || bas >= 30)
                {
                    Console.WriteLine("Base inserita non valida.");
                }
            } while (bas < 3 || bas >= 30);

            do
            {
                Console.WriteLine("Inserire l'altezza del rettangolo:");
                altezza = Convert.ToInt32(Console.ReadLine());
                if (altezza < 3 || altezza >= 30)
                {
                    Console.WriteLine("Base inserita non valida.");
                }
            } while (altezza < 3 || altezza >= 30);

            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;

            for (int i = 0; i < bas; i++)
            {
                Console.SetCursorPosition(x + i, y);
                Console.WriteLine("*");
            }

            for (int i = 0; i < altezza; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.WriteLine("*");
            }

            for (int i = 0; i < bas; i++)
            {
                Console.SetCursorPosition(x + i , y + altezza -1);
                Console.WriteLine("*");
            }

            for (int i = 0; i < altezza; i++)
            {
                Console.SetCursorPosition(x + bas - 1, y + i);
                Console.WriteLine("*");
            }

            Console.ReadLine(); 
        }
    }
}
