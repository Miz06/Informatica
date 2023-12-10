using System;
using System.Threading;
namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, faccia;

            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;
            
            for (int i = 0; i <= 0; i++)
            {
                    //faccia 1
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    Thread.Sleep(1000);
                    Console.Clear();

                    //faccia 2
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    Thread.Sleep(1000);
                    Console.Clear();

                    //faccia 3
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    Thread.Sleep(1000);
                    Console.Clear();

                    //faccia 4
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    Thread.Sleep(1000);
                    Console.Clear();

                    //faccia 5
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("=  *  =");
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    Thread.Sleep(1000);
                    Console.Clear();

                    //faccia 6
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("=======");
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 3);
                    Console.WriteLine("= * * =");
                    Console.SetCursorPosition(x, y + 4);
                    Console.WriteLine("=======");
                    Thread.Sleep(1000);
                    Console.Clear();
            }

            Console.WriteLine("Inserire la faccia del dado uscita al momento del tiro: "); 
            faccia = Convert.ToInt32(Console.ReadLine());

            if (faccia == 1)
            {
                //faccia 1
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=======");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("=     =");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("=     =");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("=======");
            }

            if (faccia == 2)
            {
                //faccia 2
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=======");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("=     =");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("=======");
                Thread.Sleep(1000);
                Console.Clear();
            }

            if (faccia == 3)
            {
                //faccia 3
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=======");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("=======");
            }

            if (faccia == 4)
            {
                //faccia 4
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=======");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("=     =");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("=======");
            }

            if (faccia == 5)
            {
                //faccia 5
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=======");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("=  *  =");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("=======");
            }

            if (faccia == 6)
            {
                //faccia 6
                Console.SetCursorPosition(x, y);
                Console.WriteLine("=======");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("= * * =");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("=======");
            }

            Console.ReadLine();
        }
    }
}
