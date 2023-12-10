using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterischi_cadenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random colore = new Random();
            Random width = new Random();
            int height;
            height = 0;

            do
            {
                Console.BackgroundColor = (ConsoleColor)colore.Next(0, 16);
                Console.ForegroundColor = (ConsoleColor)colore.Next(0, 16);
                Console.SetCursorPosition(Console.WindowWidth / width.Next(1, 120), height);
                height = height + 1;
                Console.WriteLine('#');
            } while (!Console.KeyAvailable);
        }
    }
}
