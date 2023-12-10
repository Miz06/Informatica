using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuoteVenezianeComplete
{
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon 
            Random random = new Random();
            bool doppia = false;
            int randomico, inseriti;
            int[,] matrice = new int[11, 5];
            string[] nomiCittà = new string[11] { "Venezia", "Bari", "Cagliari", "Firenze", "Genova", "Milano", "Napoli", "Palermo", "Roma", "Torino", "Nazionale" };

            Console.Write("Premere invio per avviare l'estrazione");
            Console.ReadLine();

            for (int i = 0; i < 11; i++)
            {
                inseriti = 0;
                for (int j = 0; j < 5; j++)
                {
                    do
                    {
                        doppia = false;
                        randomico = random.Next(1, 91);

                        for (int z = 0; z < inseriti; z++)
                        {
                            if (randomico == matrice[i, z])
                            {
                                doppia = true;
                            }
                        }
                    } while (doppia);
                    matrice[i, j] = randomico;
                    inseriti++;
                }
            }

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("");
                Console.Write($"{nomiCittà[i]}: ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrice[i, j]} ");
                }
            }

            Console.ReadLine();
        }
    }
}
