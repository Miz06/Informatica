using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class Program 
    {
        static void Main(string[] args)
        {//Alessandro Mizzon 
            ConsoleKey tasto;
            ConsoleKeyInfo cambiaPenna;

            char[,] screen = new char[Console.WindowHeight, Console.WindowWidth];
            char[,] undo = new char[Console.WindowHeight, Console.WindowWidth];

            int riga = 0, colonna = 0;
            char penna = '.';
            bool insert = false;
            bool delete = false;
            int[] cursore = new int[2];
            bool save = false;
            char nuovaPenna = '.';
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            do
            {
                Console.SetCursorPosition(0, 29);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write(" ");
                }

                Console.Write($"\rX: {colonna} Y: {riga}");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                if (save)
                {
                    colonna = cursore[0];
                    riga = cursore[1];
                    save = false;
                }

                Console.SetCursorPosition(colonna, riga);

                if (!insert)
                {
                    Console.Write(penna);
                    screen[riga, colonna] = penna;
                }

                if (delete)
                    penna = ' ';
                else
                    penna = nuovaPenna;

                tasto = Console.ReadKey(true).Key;

                switch (tasto)
                {
                    case ConsoleKey.LeftArrow:
                        if (colonna >= 1)
                            colonna--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (colonna < Console.WindowWidth - 2)
                            colonna++;
                        break;

                    case ConsoleKey.UpArrow:
                        if (riga >= 1)
                            riga--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (riga < Console.WindowHeight - 2)
                            riga++;
                        break;

                    case ConsoleKey.Insert:
                        if (!insert)
                            insert = true;
                        else
                            insert = false;
                        break;

                    case ConsoleKey.Delete:
                        if (!delete)
                            delete = true;
                        else
                            delete = false;
                        break;

                    case ConsoleKey.F1:
                        cambiaPenna = Console.ReadKey(true);
                        nuovaPenna = cambiaPenna.KeyChar;
                        penna = nuovaPenna;
                        break;

                    case ConsoleKey.F2:
                        cursore[0] = Console.CursorLeft;
                        cursore[1] = Console.CursorTop;
                        for (int i = 0; i < screen.GetLength(0); i++)
                        {
                            for (int j = 0; j < screen.GetLength(1); j++)
                            {
                                undo[i, j] = screen[i, j];
                                screen[i, j] = ' ';
                            }
                        }
                        break;
                }
            } while (tasto != ConsoleKey.Escape);
            Console.ReadLine();
        }
    }
}

