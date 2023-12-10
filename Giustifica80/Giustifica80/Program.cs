using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Giustifica
{
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon 
            string frase, fraseFinale = "";
            int p = 0, divisione;

            Console.WriteLine("Inserire una frase");
            frase = Console.ReadLine();

            string[] parole = new string[frase.Length];

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ' && frase[i] != '.')
                {
                    parole[p] += frase[i];
                }
                else
                {
                    p++;
                }
            }

            divisione = 80 / p + 1;

            for (int i = 0; i < parole.Length - 1; i++)
            {
                fraseFinale += parole[i];
                for (int j = 0; j < divisione; j++)
                {
                    fraseFinale += ' ';
                }
            }

            fraseFinale += parole[parole.Length - 1];

            Console.WriteLine(fraseFinale);

            Console.ReadLine();

        }
    }
}
