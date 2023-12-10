using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraTarga
{
    internal class Program
    {//Alessandro Mizzon 
        static void Main(string[] args)
        {
            string targa=""; 
            Console.WriteLine("Premere invio per generare una targa");
            Console.ReadLine();

            GeneraTarga(targa);
            Console.ReadLine(); 
        }

        static void GeneraTarga(string targa)
        {
            int randomico;
            char[] alfabeto = new char[26];
            Random random = new Random();

            for (int i = 0; i<26; i++)
            {
                alfabeto[i] = Convert.ToChar(65 + i); 
            }

            for (int i = 0; i<7; i++)
            {
                if (i < 2)
                {
                    randomico = random.Next(0, 26);
                    targa += alfabeto[randomico];
                }
                else if (i > 1 && i < 5)
                {
                    randomico = random.Next(1, 10);
                    targa += randomico;
                }
                else
                {
                    randomico = random.Next(0, 26);
                    targa += alfabeto[randomico];
                }
            }
            Console.WriteLine(targa); 
        }
    }
}
