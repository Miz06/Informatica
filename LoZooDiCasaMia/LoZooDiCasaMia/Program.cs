using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoZooDiCasaMia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<animali> zoo = new List<animali>();
            animali z = new animali();
            string[] menù = new string[] { "[1] Inserisci", "[2] Visualizzazione", "[3] Esci" };
            int scelta;
            bool esci = false;

            do
            {
                foreach (string n in menù)
                {
                    Console.WriteLine(n);
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("Inserire una scelta");
                scelta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------");

                switch (scelta)
                {
                    case 1:
                        Inserimento(zoo, z);
                        break;

                    case 2:
                        Visualizzazione(zoo);
                            break;
                        
                    case 3:
                        esci = true;
                        break;
                }
            } while (!esci);

        }

        static void Inserimento(List<animali> zoo, animali z)
        {
            Console.WriteLine("Inserire la specie:");
            z.SetSpecie(Console.ReadLine());

            Console.WriteLine("Inserire la razza:");
            z.SetRazza(Console.ReadLine());

            Console.WriteLine("Inserire il cibo:");
            z.SetCibo(Console.ReadLine());

            Console.WriteLine("Inserire la quantità:");
            z.SetQuantità(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Inserire il verso:");
            z.SetVerso(Console.ReadLine());

            Console.WriteLine("Inserire lo stato mangiare:\n[1] Deve mangiare\n[2] Ha mangiato\n[3] Non può mangiare");
            int scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    z.SetStatoMangiare(mangiato.deveMangiare);
                    break;

                case 2:
                    z.SetStatoMangiare(mangiato.haMangiato);
                    break;

                case 3:
                    z.SetStatoMangiare(mangiato.nonPuòMangiare);
                    break;
            }

            zoo.Add(z);
        }

        static void Visualizzazione(List <animali> zoo)
        {
            for (int i = 0; i< zoo.Count; i++)
            {
                Console.WriteLine($"Specie: {zoo[i].GetSpecie()}");
                Console.WriteLine($"Razza: {zoo[i].GetRazza()}");
                Console.WriteLine($"Cibo: {zoo[i].GetCibo()}");
                Console.WriteLine($"Quantità: {zoo[i].GetQuantita()}");
                Console.WriteLine($"Verso: {zoo[i].GetVerso()}");
                Console.WriteLine($"Stato mangiare: {zoo[i].GetStatoMangiare()}");

                if (zoo[i].Mangiare())
                {
                    Console.WriteLine("L'animale deve mangiare");
                }
                else
                {
                    Console.WriteLine("L'animale non deve mangiare o gli manca il cibo");
                }
            }
        }

    }
}
