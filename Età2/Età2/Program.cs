using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Età2
{
    enum sesso
    {
        Maschio,
        Femmina,
    }
    enum statoCivile
    {
        Celibe,
        Nubile,
        Coniugato,
        Vedovo,
        Separato
    }

    struct persona
    {
        public string id; //codice fiscale
        public string nome;
        public string cognome;
        public string cittadinanza;
        public DateTime nascita;
        public statoCivile stato;
        public sesso genere;
    }

    internal class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon 4E
            string[] opzioni = new string[] { "Inserimento", "Età", "Rimuovi", "Visualizzazione" };
            int scelta, indice = 0, esci;

            persona[] p = new persona[3];

            do
            {
                Menu(opzioni, out scelta);

                switch (scelta)
                {
                    case (1):
                        if (indice < 3)
                        {
                            Inserimento(ref p, indice);
                            indice++;
                        }
                        else
                        {
                            Console.WriteLine("Anagrafe piena");
                        }
                        break;
                    case (2):
                        Console.WriteLine(Età(p));
                        Console.WriteLine(Età2(p));
                        break;
                    case (3):
                        Console.WriteLine(opzioni[2]);
                        break;
                    case (4):
                        Visualizzazione(p, indice);
                        break;
                }

                Console.WriteLine("Desideri uscire?");
                Console.WriteLine("[1] No");
                Console.WriteLine("[2] Sì");
                esci = Convert.ToInt32(Console.ReadLine());

            } while (esci == 1);


            Console.ReadLine();
        }

        static void Menu(string[] array, out int scelta)
        {
            Console.WriteLine("MENU':");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{array[i]} [{i + 1}]");
            }
            Console.WriteLine("-----------------");

            Console.WriteLine("Inserire un opzione:");
            int.TryParse(Console.ReadLine(), out scelta);

            while (scelta < 1 || scelta > array.Length)
            {
                Console.WriteLine("Scelta non valida, reinserire: ");
                int.TryParse(Console.ReadLine(), out scelta);
            }
        }

        static void Inserimento(ref persona[] p, int indice) //Inserimento
        {
            Console.WriteLine("Inserire nome:");
            p[indice].nome = Console.ReadLine();

            Console.WriteLine("Inserire cognome:");
            p[indice].cognome = Console.ReadLine();

            Console.WriteLine("Inserire cittadinanza:");
            p[indice].cittadinanza = Console.ReadLine();

            Console.WriteLine("Inserire il sesso:");
            Console.WriteLine("[1] Maschio");
            Console.WriteLine("[2] Femmina");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                p[indice].genere = sesso.Maschio;
            }
            else
            {
                p[indice].genere = sesso.Femmina;
            }

            Console.WriteLine("Inserire lo stato civile:");
            Console.WriteLine("[1] Celibe");
            Console.WriteLine("[2] Coniugato");
            Console.WriteLine("[3] Vedovo");
            Console.WriteLine("[4] Separato");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case (1):
                    p[indice].stato = statoCivile.Celibe;
                    break;

                case (2):
                    p[indice].stato = statoCivile.Coniugato;
                    break;

                case (3):
                    p[indice].stato = statoCivile.Vedovo;
                    break;

                case (4):
                    p[indice].stato = statoCivile.Separato;
                    break;
            }

            Console.WriteLine("Inserire la data di nascita: (formato:  dd/mm/yyyy)");
            p[indice].nascita = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Inserire il codice fiscale:");
            p[indice].id = Console.ReadLine();
        }

        static void Visualizzazione(persona[] p, int indice) //Visualizzazione
        {
            for (int i = 0; i < indice + 1; i++)
            {
                Console.WriteLine($"Persona {i + 1}");
                Console.WriteLine($"Nome: {p[i].nome}");
                Console.WriteLine($"Cognome: {p[i].cognome}");
                Console.WriteLine($"Cittadinanza: {p[i].cittadinanza}");
                Console.WriteLine($"Data di nascita: {p[i].nascita}");
                Console.WriteLine($"id: {p[i].id}");
                Console.WriteLine($"Genere: {p[i].genere}");
                Console.WriteLine($"Stato: {p[i].stato}");
            }
        }

        static int Età(persona[] p)
        {
            Console.WriteLine("CALCOLO ETA' CON DATA TIME");
            int età = 0;

            Console.WriteLine("Inserire il codice fiscale:");
            string cF = Console.ReadLine();

            for (int i = 0; i < p.Length; i++)
            {
                if (cF == p[i].id)
                {
                    DateTime oggi = DateTime.Now;
                    DateTime data = Convert.ToDateTime(p[i].nascita);
                    età = oggi.Year - data.Year;

                    if (oggi.Month < data.Month || (oggi.Month == data.Month && oggi.Day < data.Day))
                    {
                        età--;
                    }
                    break;
                }
            }
            Console.WriteLine("----------------------------");
            return età;
        }

        static int Età2(persona[] p)
        {
            Console.WriteLine("CALCOLO ETA' SENZA DATA TIME");
            int età = 0;

            Console.WriteLine("Inserire il codice fiscale:");
            string cF = Console.ReadLine();

            Console.WriteLine("Inserire che giorno è (formato:  dd/mm/yyyy)");
            string oggi = Console.ReadLine();

            string[] oggiA = new string[3];
            int[] data = new int[3];

            oggiA = oggi.Split('/');

            for (int i = 0; i < 3; i++)
            {
                if (p[i].id == cF)
                {
                    data[0] = p[i].nascita.Day;
                    data[1] = p[i].nascita.Month;
                    data[2] = p[i].nascita.Year;
                    età = Convert.ToInt32(oggiA[2]) - Convert.ToInt32(data[2]);

                    if (Convert.ToInt32(oggiA[1]) < data[1] || Convert.ToInt32(oggiA[1]) == data[1] && Convert.ToInt32(oggiA[0]) < data[0])
                    {
                        età--;
                    }
                    break;
                }
            }

            Console.WriteLine("----------------------------");
            return età;
        }
    }
}


