using System;
using System.Threading;
namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, faccia1 = 0, faccia2 = 0, numero;
            char risposta;
            bool var;
            bool var2 = true;
            string giocatore1, giocatore2;
            Random valore = new Random();

            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;

            Console.WriteLine("Inserire il nome del giocatore 1:");
            giocatore1 = Console.ReadLine();
            Console.WriteLine("Inserire il nome del giocatore 2:");
            giocatore2 = Console.ReadLine();
            Console.WriteLine($"Giocatore 1: {giocatore1}");
            Console.WriteLine($"Giocatore 2: {giocatore2}");

            for (int i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"Turno di {giocatore1}, premere invio per tirare");
                    Console.ReadLine();
                }
                else if (i == 2)
                {
                    Console.WriteLine($"Turno di {giocatore2}, premere invio per tirare");
                    Console.ReadLine();
                }
                do
                {
                    Console.WriteLine("Il dado è stato lanciato");
                    numero = valore.Next(1, 7);
                    Console.WriteLine($"Il valore uscito è {numero}");

                    if (i == 1)
                    {
                        faccia1 = numero;
                    }
                    else
                    {
                        faccia2 = numero;
                    }
                    do
                    {
                        Console.WriteLine("Si vuole rilanciare il dado?");
                        risposta = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (risposta == 'N')
                        {
                            var = false;
                            var2 = false;
                        }
                        else
                        {
                            if (risposta == 'S')
                            {
                                var = false;
                                var2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Valore inserito non valido, rispondere nuovamente:");
                                var = true;
                            }
                        }

                    } while (var == true);

                } while (var2 == true);

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                for (int faccia = 1; faccia <= 7; faccia++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    if (faccia == 1 || faccia == 7 && numero == 1)
                    {
                        //faccia 1
                        Console.SetCursorPosition(x, y + 1);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(x, y + 2);
                        Console.WriteLine("=  *  =");
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("=     =");
                    }

                    if (faccia == 2 || faccia == 7 && numero == 2)
                    {
                        //faccia 2
                        Console.SetCursorPosition(x, y + 1);
                        Console.WriteLine("=  *  =");
                        Console.SetCursorPosition(x, y + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("=  *  =");
                    }

                    if (faccia == 3 || faccia == 7 && numero == 3)
                    {
                        //faccia 3
                        Console.SetCursorPosition(x, y + 1);
                        Console.WriteLine("=  *  =");
                        Console.SetCursorPosition(x, y + 2);
                        Console.WriteLine("=  *  =");
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("=  *  =");
                    }

                    if (faccia == 4 || faccia == 7 && numero == 4)
                    {
                        //faccia 4
                        Console.SetCursorPosition(x, y + 1);
                        Console.WriteLine("= * * =");
                        Console.SetCursorPosition(x, y + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("= * * =");
                    }

                    if (faccia == 5 || faccia == 7 && numero == 5)
                    {
                        //faccia 5
                        Console.SetCursorPosition(x, y + 1);
                        Console.WriteLine("= * * =");
                        Console.SetCursorPosition(x, y + 2);
                        Console.WriteLine("=  *  =");
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("= * * =");
                    }

                    if (faccia == 6 || faccia == 7 && numero == 6)
                    {
                        //faccia 6
                        Console.SetCursorPosition(x, y + 1);
                        Console.WriteLine("= * * =");
                        Console.SetCursorPosition(x, y + 2);
                        Console.WriteLine("= * * =");
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("= * * =");
                    }
                    Thread.Sleep(1000);
                }
                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }

            Console.SetCursorPosition(x, y);
            if (faccia1 > faccia2)
            {
                Console.WriteLine($"Ha vinto {giocatore1}");
            }
            else
            {
                if (faccia1 < faccia2)
                {
                    Console.WriteLine($"Ha vinto {giocatore2}");
                }
                else
                {
                    Console.WriteLine("Pareggio");
                }
            }
            Console.ReadLine();
        }
    }
}
