using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laMaestraVaInGita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bambini, P = 0, S;
            string classe, bambino;

            Console.WriteLine("Inserire il numero e la sezione della classe");
            classe = Console.ReadLine();

            Console.WriteLine("Quanti bambini ci sono?");
            bambini = Convert.ToInt32(Console.ReadLine()); 

            string[] nome = new string[bambini];

            for (int i=0; i<bambini; i++)
            {
                Console.WriteLine($"Inserire il nome del {i+1}° bambino");
                nome[i] = Console.ReadLine(); 
            }
            //REGISTRO DI CLASSE
            Console.WriteLine($"CLASSE {classe}");
            for (int i = 0; i < bambini; i++)
            {
                Console.WriteLine($"{i+1}) {nome[i]}");
            }

            //APPELLO
            do
            {
                Console.WriteLine("Come ti chiami?");
                bambino = Console.ReadLine();

                S = 0; 

                for(int i = 0; i < bambini; i++)
                {
                    if (bambino == nome[i])
                    {
                        P++;
                    }
                    else
                    {
                        S++; 
                    }

                    if (S==3)
                    {
                        Console.WriteLine($"Non fai parte della classe {classe}"); 
                    }
                }
            } while (P!=bambini);

            Console.WriteLine("Tutti i bambini sono saliti sull'autobus");
            Console.ReadLine(); 
        }
    }
}
