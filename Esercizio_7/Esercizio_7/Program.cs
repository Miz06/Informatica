using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esercizio 7

            string veicolo;
            double cilindrataAtautovettura;
            double cilindrataCamion; 

            Console.WriteLine("Il veicolo è un'autovettura o un camion? ");
            veicolo = Console.ReadLine();

            if (veicolo == "Autovettura")
            {
                Console.WriteLine("Inserire la cilindrata dell'autovettura");
                cilindrataAtautovettura = Convert.ToInt32(Console.ReadLine());

                if (cilindrataAtautovettura <= 1000)
                {
                    Console.WriteLine("Il costo del biglietto è di 20$");
                }
                else
                {
                    if (cilindrataAtautovettura > 1000 && cilindrataAtautovettura <= 2000)
                    {
                        Console.WriteLine("Il costo del biglietto è di 30$");
                    }
                    else
                    {
                        Console.WriteLine("Il costo del biglietto è di 33$"); ;
                    }
                }
            }
            else 
            {
                if (veicolo == "Camion")
                {
                    Console.WriteLine("Inserire la cilindrata del camion");
                    cilindrataCamion = Convert.ToInt32(Console.ReadLine());

                    if (cilindrataCamion <= 2000)
                    {
                        Console.WriteLine("Il costo del biglietto è di 40$");
                    }
                    else
                    {
                        if (cilindrataCamion > 2000 && cilindrataCamion <= 3000)
                        {
                            Console.WriteLine("Il costo del biglietto è di 50$");
                        }
                        else
                        {
                            Console.WriteLine("Il costo del biglietto è di 100$"); ;
                        }
                    }
                }

            }

        }
    }
}
