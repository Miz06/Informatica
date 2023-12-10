using System;

namespace MorraCinese
{
    class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon
            string giocatore1, giocatore2;
            char tiro1, tiro2;
            int vittoria1 = 0, vittoria2 = 0;
            bool esci = false;

            Console.Write("Giocatore 1 inserisci il tuo nome: ");
            giocatore1 = Console.ReadLine();
            Console.Write("Giocatore 2 inserisci il tuo nome: ");
            giocatore2 = Console.ReadLine();

            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Turno di {giocatore1}:");
                    Console.ForegroundColor = ConsoleColor.Black;
                    tiro1 = Convert.ToChar(Console.ReadLine());
                } while (tiro1 != 'A' && tiro1 != 'S' && tiro1 != 'D' && tiro1 != 'x');
                if (tiro1 == 'x')
                {
                    esci = true;
                }

                if (!esci)
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Turno di {giocatore2}:");
                        Console.ForegroundColor = ConsoleColor.Black;
                        tiro2 = Convert.ToChar(Console.ReadLine());
                    } while (tiro2 != 'J' && tiro2 != 'K' && tiro2 != 'L' && tiro2 != 'x');
                    if (tiro2 == 'x')
                    {
                        esci = true;
                    }

                    if (tiro1 == 'A' && tiro2 == 'K' || tiro1 == 'S' && tiro2 == 'L' || tiro1 == 'D' && tiro2 == 'J')
                    {
                        vittoria1++;
                    }
                    else if (tiro1 == 'A' && tiro2 == 'L' || tiro1 == 'S' && tiro2 == 'J' || tiro1 == 'D' && tiro2 == 'K')
                    {
                        vittoria2++;
                    }
                }
            } while (!esci);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************");

            if (vittoria1 == vittoria2)
            {
                Console.WriteLine("Pareggio");
            }
            else if (vittoria1 > vittoria2)
            {
                Console.WriteLine($"Ha vinto {giocatore1}");
            }
            else if (vittoria1 < vittoria2)
            {
                Console.WriteLine($"Ha vinto {giocatore2}");
            }

            Console.ReadLine();
        }
    }
}
