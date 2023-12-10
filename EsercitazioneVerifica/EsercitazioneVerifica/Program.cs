using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paroleInserite = 0, lung, e = 0; 
            char car;
            string parola = "", confronto;

            Console.WriteLine("Quale vuoi che sia la lunghezza massima del dizionario?");
            lung = Convert.ToInt32(Console.ReadLine());

            string[] dizionario = new string[lung]; 

            Console.WriteLine("Inserire le parole oppure la frase:"); 
            do
            {
                car = Convert.ToChar(Console.Read());
                if (car != 13 && car != ' ')
                {
                    parola = parola + car;
                }
                else
                {
                    dizionario[paroleInserite] = parola;
                    paroleInserite++;
                    parola = ""; 
                } 
            } while (car != 13);

            Console.WriteLine("Dizionario iniziale"); 
            for (int i = 0; i<paroleInserite; i++)
            {
                Console.WriteLine(dizionario[i]); 
            }

            Console.WriteLine("**********");

            for (int i = 0; i < paroleInserite; i++)
            {
                confronto = dizionario[i];
                for (int j = i+1; j<paroleInserite; j++)
                {
                    if (confronto == dizionario[j])
                    {
                        for (int t = j; t<paroleInserite-1; t++)
                        {
                            dizionario[j] = dizionario[j + 1]; 
                        }
                    }
                }
            }

            Console.WriteLine("Dizionario finale");
            for (int i = 0; i < paroleInserite-1; i++)
            {
                Console.WriteLine(dizionario[i]);
            }

            Console.ReadLine();
            Console.ReadLine(); 
        }
    }
}
