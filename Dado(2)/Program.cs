using System;
using System.Threading;
namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int var1 = -1;
            int facciaInserita; 

            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;

            Console.WriteLine("Inserire la faccia del dado desiderata:");
            facciaInserita = Convert.ToInt32(Console.ReadLine()); 

            for (int faccia = 1; faccia <= 7; faccia++)
            {
                if (faccia == 1 || faccia == 7 && facciaInserita == 1)
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

                if (faccia == 2 || faccia == 7 && facciaInserita == 2)
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
                }

                if (faccia == 3 || faccia == 7 && facciaInserita == 3)
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

                if (faccia == 4 || faccia == 7 && facciaInserita == 4)
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

                if (faccia == 5 || faccia == 7 && facciaInserita == 5)
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

                if (faccia == 6 || faccia == 7 && facciaInserita == 6)
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
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}
