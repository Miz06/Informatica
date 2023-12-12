using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piloti
{
    internal class Program
    {//Alessandro Mizzon 4E
        static void Main(string[] args)
        {
            Gara gara1 = new Gara("Formula1", 3);

            Pilota p1 = new Pilota("Franco", "Rossi");
            Auto s1 = new Auto("Ferrari", p1);

            Pilota p2 = new Pilota("Beppe", "Menno");
            Auto s2 = new Auto("Mercedes", p2);

            Pilota p3 = new Pilota("Cusunilla", "Alti");
            Auto s3 = new Auto("Ferrari", p3);

            gara1.Aggiungi(s1);
            gara1.Aggiungi(s2);
            gara1.Aggiungi(s3);

            gara1.Stampa();

            Console.WriteLine("-------------------------");

            int num = gara1.GeneraVincitore();
            Console.WriteLine($"Vincitore: {gara1.Vincitore(num)}");

            Console.ReadLine();
        }
    }
}
