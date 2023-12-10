using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random colore = new Random();

            do
            {
                Console.BackgroundColor = (ConsoleColor) colore.Next(0, 16);
                Console.ForegroundColor = (ConsoleColor)colore.Next(0, 16);
                Console.CursorTop = colore.Next(0, Console.WindowHeight);
                Console.CursorLeft = colore.Next(0, Console.WindowWidth - 1);
                Console.Write('°');
            } while (!Console.KeyAvailable);

        }
    }
}
