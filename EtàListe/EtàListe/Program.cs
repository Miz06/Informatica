using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtàListe
{
    struct persona
    {
        public string id; 
        public string nome;
        public string cognome;
        public DateTime nascita;
    }
    internal class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon 4E
            List<persona> Anagrafe = new List<persona>
            {
                new persona {nome = "Alessandro", cognome = "Mizzon", id = "MZZLSN06T03F382Z", nascita = new DateTime(2006, 12, 03)},
                new persona {nome = "Davide", cognome = "Soave", id = "sv04", nascita = new DateTime(2004, 09, 12)},
                new persona {nome = "Edoardo", cognome = "Secchiero", id = "seco", nascita = new DateTime(2005, 06, 2)},
            };

            Console.WriteLine("Inserire il codice fiscale della persona di cui si vuole calcolare l'età:");
            string cF = Console.ReadLine(); 

            for (int i = 0; i<Anagrafe.Count; i++)
            {
                if (cF == Anagrafe[i].id)
                {
                    Console.WriteLine(Età(Anagrafe[i].nascita));
                    break;
                }
            }

            Console.ReadLine(); 
        }
        static int Età(DateTime nascita)
        {
            int età = 0;

            DateTime oggi = DateTime.Now;
            età = oggi.Year - nascita.Year; 

            if (oggi.Year < nascita.Year || (oggi.Month < nascita.Month && oggi.Day < nascita.Day))
            {
                età--; 
            }
            return età; 
        }
    }
}
