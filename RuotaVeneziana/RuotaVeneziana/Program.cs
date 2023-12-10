using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RuotaVeneziana
{
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon
            int[] estrazioni = new int[5];
            int randomico, inseriti=0; 
            Random random = new Random();
            bool doppia = false;

            Console.Write("Premere invio per avviare l'estrazione");
            Console.ReadLine(); 

            for (int i = 0; i<5; i++)
            {
                do
                {
                    randomico = random.Next(1, 91);

                    for (int j = 0; j<inseriti; j++)
                    {
                        if (randomico == estrazioni[j])
                        {
                            doppia = true;
                        }
                    }
                } while (doppia);
                estrazioni[i] = randomico; 
                doppia = false; 
                inseriti++;
            }

            Console.WriteLine(""); 
            Console.WriteLine("Numeri estratti:"); 

            foreach (int var1 in estrazioni)
            {
                Console.WriteLine(var1);
                Thread.Sleep(1000);
            }
            Console.ReadLine(); 

        }
    }
}
