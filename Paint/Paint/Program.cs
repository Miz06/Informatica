using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon 
            char matita = '.';
            int x = 0, y = 0;

            ConsoleKeyInfo tasto;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(x, y);
            Console.Clear();

            do
            {
                tasto = Console.ReadKey(true);
                switch (tasto.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                            x--;
                        Console.Write(matita);
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 1)
                            x++;
                        Console.Write(matita);
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                            y--;
                        Console.Write(matita);
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 2)
                            y++;
                        Console.Write(matita);
                        break;
                }
                Console.SetCursorPosition(x, y);
            }
            while (tasto.Key != ConsoleKey.Escape);
        }

    }
}