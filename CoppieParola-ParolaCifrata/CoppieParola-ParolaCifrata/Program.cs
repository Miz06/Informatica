using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoppieParola_ParolaCifrata
{
    internal class Program
    {
        struct stringa
        {
            public string parola;
            public string cifrata;
        }
        static void Main(string[] args)
        { //Alessandro Mizzon 
            char car; 
            int paroleInserite = 0;
            stringa[] parole = new stringa[10];
            string p = "", pC = "";

            Console.WriteLine("Inserire una stringa di massimo 10 parole:");

            do
            {
                car = Convert.ToChar(Console.Read());
                if (car == ' ' || car == 13)
                {
                    parole[paroleInserite].parola = p;
                    parole[paroleInserite].cifrata = pC;
                    paroleInserite++;
                    p = "";
                    pC = ""; 
                }
                else
                {
                    pC += Convert.ToChar(car+3); 
                    p += car;
                }
            } while (car != 13 && paroleInserite != 10);

            Console.WriteLine(); 

            for (int i = 0; i<paroleInserite; i++)
            {
                Console.WriteLine($"{parole[i].parola}: {parole[i].cifrata}");
                Console.WriteLine(); 
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
