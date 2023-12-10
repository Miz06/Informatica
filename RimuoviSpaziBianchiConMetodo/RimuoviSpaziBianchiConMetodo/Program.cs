using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaziBianchi
{
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon
            string frase, fraseFinale;

            Console.WriteLine("Inserire una frase:");
            frase = Console.ReadLine();

            fraseFinale = Spazi(frase);

            Console.WriteLine(fraseFinale);

            Console.ReadLine();
        }

        static string Spazi(string fraseInserita)
        {
            string parola = "", fraseCorretta = "";
            bool spazio = false;

            for (int i = 0; i < fraseInserita.Length; i++)
            {
                if (fraseInserita[i] == ' ')
                {
                    fraseCorretta += parola;
                    parola = "";
                    spazio = true;
                }
                else
                {
                    if (spazio)
                    {
                        fraseCorretta += " ";
                    }
                    spazio = false;
                    parola += fraseInserita[i];

                    if (fraseInserita[i] == '.')
                    {
                        fraseCorretta += parola;
                    }
                }
            }

            return fraseCorretta;
        }
    }
}
