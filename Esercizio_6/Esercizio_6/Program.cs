using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esercizio 6 

            double costoSpesa;
            double costoSpesaFinale; 

            Console.WriteLine("Inserire l'importo della spesa: ");
            costoSpesa = Convert.ToInt32(Console.ReadLine());

            if (costoSpesa < 50)
            {
                costoSpesaFinale = costoSpesa - (costoSpesa / 100) * 5;
                Console.WriteLine($"L'importo iniziale era di {costoSpesa}$ ma con lo sconto del 5% ora è {costoSpesaFinale}$.");
            }
            else 
            {
                if (costoSpesa >= 50 && costoSpesa < 65)
                { 
                    costoSpesaFinale = costoSpesa - (costoSpesa / 100) * 6;
                    Console.WriteLine($"L'importo iniziale era di {costoSpesa}$ ma con lo sconto del 6% ora è {costoSpesaFinale}$.");
                }
                else
                {
                    if (costoSpesa >= 65 && costoSpesa < 80) 
                    {
                        costoSpesaFinale = costoSpesa - (costoSpesa / 100) * 7;
                        Console.WriteLine($"L'importo iniziale era di {costoSpesa}$ ma con lo sconto del 7% ora è {costoSpesaFinale}$.");
                    }
                    else
                    {
                        costoSpesaFinale = costoSpesa - (costoSpesa /100) * 10;
                        Console.WriteLine($"L'importo iniziale era di {costoSpesa}$ ma con lo sconto del 10% ora è {costoSpesaFinale}$.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
