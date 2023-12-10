using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            ConsoleKey tasto;
            int riga = 0, colonna = 0, x = 0, y = 0, posizioneX, posizioneY;
            char puntino = '.';
            bool esci = false;

            Console.SetCursorPosition(riga, colonna);
            Console.Write(puntino);

            Console.SetCursorPosition(1, 29);
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = 0; i < Console.WindowWidth - 3; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(10, 29);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"x: {x} y: {y}");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            do
            {
                tasto = Console.ReadKey(true).Key;
                switch (tasto)
                {
                    case ConsoleKey.Escape:
                        esci = true;
                        break;

                    case ConsoleKey.RightArrow:
                        if (colonna < Console.WindowWidth - 2)
                        {
                            colonna++;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (colonna >= 1)
                        {
                            colonna--;
                        } 
                        break;

                    case ConsoleKey.UpArrow:
                        if (riga >= 1)
                        {
                            riga--;

                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (riga < Console.WindowHeight - 2)
                        {
                            riga++;
                        }
                        break;
                }

                Console.SetCursorPosition(colonna, riga);
                Console.Write(puntino);

                posizioneX = Console.CursorLeft;
                posizioneY = Console.CursorTop;

                Console.SetCursorPosition(10, 29);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write($"x: {posizioneX} y: {posizioneY}");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition(posizioneX, posizioneY);

            } while (!esci);

            Console.ReadLine();
        }
    }
}
