using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneCodice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, frase2; 
            string parolaCodificata = "", parolaDecodificata = ""; 

            Console.WriteLine("Inserire la stringa da codificare:");
            frase = Console.ReadLine();

            char[] parolaC = new char[frase.Length];

            Console.WriteLine(); 

            for(int i = 0; i<frase.Length; i++)
            {
                parolaC[i] = frase[i]; 
                if (parolaC[i] >= 32 && parolaC[i] <= 125)
                {
                    parolaCodificata = parolaCodificata + Convert.ToChar(parolaC[i] + 1);
                }
                else if (parolaC[i] == 126)
                {
                    parolaCodificata = parolaCodificata + Convert.ToChar(32);
                }
            }

            Console.WriteLine($"La stringa codificata è {parolaCodificata}");

            Console.WriteLine("Inserire a stringa da decodificare:"); 
            frase2 = Console.ReadLine();

            char[] parolaD = new char[frase2.Length];

            for (int i = 0; i < frase2.Length; i++)
            {
                parolaD[i] = frase2[i];

                if (parolaD[i] >= 33 && parolaC[i] <= 126)
                {
                    parolaDecodificata = parolaDecodificata + Convert.ToChar(parolaD[i] - 1);
                }
                else if (parolaD[i] == 32)
                {
                    parolaDecodificata = parolaDecodificata + Convert.ToChar(126);
                }
            }

            Console.WriteLine($"La stringa decodificata è {parolaDecodificata}");

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
