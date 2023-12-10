using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficaListeCSV
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

    enum stato
    {
        libero,
        occupato,
        cancellato
    }

    struct persona
    {
        public string id; //codice fiscale
        public string nome;
        public string cognome;
        public string cittadinanza;
        public DateTime nascita;
        public statoCivile statoCivile;
        public sesso genere;
        public stato stato;

        public override string ToString()
        {
            return String.Format($"Nome: {nome}, Cognome: {cognome}, Cittadinanza: {cittadinanza}, id: {id}, Genere: {genere}, Stato: {statoCivile}, Stato elemento: {stato}, Nascita: {nascita}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon 4E
            List<persona> anagrafica = new List<persona>();

            string[] opzioni = new string[] { "Inserimento", "Visualizzazione", "Età", "Cancella", "Modifica", "Menù Log", "Scrivi nel file CSV", "Stampa contenuto del file CSV" };
            int indice = 0, esci = 0, scelta = 0;
            string[] files = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory + "\\FileLog"));

            do
            {
                Menù(opzioni, ref scelta);

                switch (scelta)
                {
                    case (1):
                        Inserimento(anagrafica);
                        ScriviFile(Path.Combine(Environment.CurrentDirectory + "\\FileLog" + $"\\log{files.Length + 1}"), anagrafica[indice].ToString());
                        indice++;
                        break;

                    case (2):
                        Visualizzazione(anagrafica, indice);
                        break;

                    case (3):
                        Età(anagrafica);
                        Età2(anagrafica);
                        break;

                    case (4):
                        Cancella(anagrafica);
                        break;

                    case (5):
                        Modifica(anagrafica);
                        break;

                    case (6):
                        getFiles();
                        break;

                    case (7):
                        ScriviCSV(anagrafica);
                        break;

                    case (8):
                        LeggiCSV();
                        break;
                }

                do
                {

                    Console.WriteLine("Desideri uscire?\n[0] No\n[1] Sì");
                    esci = Convert.ToInt32(Console.ReadLine());

                    if (esci != 0 && esci != 1)
                    {
                        Console.WriteLine("Numero inserito non valido. Reinserirlo");
                    }
                } while (esci != 0 && esci != 1);

            } while (esci == 0);
        }

        static void Menù(string[] array, ref int scelta)
        {
            Console.WriteLine("----------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {array[i]}");
            }
            Console.WriteLine("----------------");

            Console.WriteLine("Inserire la scelta:");
            int.TryParse(Console.ReadLine(), out scelta);
            Console.WriteLine("----------------");

            while (scelta < 1 || scelta > array.Length)
            {
                Console.WriteLine("Scelta non valida, reinserirla: ");
                int.TryParse(Console.ReadLine(), out scelta);
                Console.WriteLine("----------------");
            }
        }

        static void Inserimento(List<persona> a)
        {
            bool doppio = false;
            persona supporto = new persona();

            Console.WriteLine("Inserire nome:");
            supporto.nome = Console.ReadLine();

            Console.WriteLine("Inserire cognome:");
            supporto.cognome = Console.ReadLine();

            Console.WriteLine("Inserire cittadinanza:");
            supporto.cittadinanza = Console.ReadLine();

            Console.WriteLine("Inserire il sesso:");
            Console.WriteLine("[1] Maschio");
            Console.WriteLine("[2] Femmina");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                supporto.genere = sesso.Maschio;
            }
            else
            {
                supporto.genere = sesso.Femmina;
            }

            Console.WriteLine("Inserire lo stato civile:");
            Console.WriteLine("[1] Celibe");
            Console.WriteLine("[2] Coniugato");
            Console.WriteLine("[3] Vedovo");
            Console.WriteLine("[4] Separato");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case (1):
                    supporto.statoCivile = statoCivile.Celibe;
                    break;

                case (2):
                    supporto.statoCivile = statoCivile.Coniugato;
                    break;

                case (3):
                    supporto.statoCivile = statoCivile.Vedovo;
                    break;

                case (4):
                    supporto.statoCivile = statoCivile.Separato;
                    break;
            }

            Console.WriteLine("Inserire la data di nascita: (formato:  dd/mm/yyyy)");
            supporto.nascita = DateTime.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Inserire l'id:");
                supporto.id = Console.ReadLine();

                doppio = ControlloCF(a, ref supporto.id);
            } while (supporto.id == "" || doppio);
            Console.WriteLine("----------------");

            supporto.stato = stato.occupato;

            a.Add(supporto);
        }

        static bool ControlloCF(List<persona> a, ref string CF)
        {
            bool doppio = false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].id == CF)
                {
                    doppio = true;
                    break;
                }
            }

            return doppio;
        }

        static void Visualizzazione(List<persona> a, int indice)
        {
            if (indice == 0)
            {
                Console.WriteLine("Nessuna persona presente nell'anagrafica.");
            }
            else
            {
                for (int i = 0; i < indice; i++)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"PERSONA {i + 1} {a[i]}");
                    Console.WriteLine("-----------------------");
                }
            }
        }

        static void Età(List<persona> a)
        {
            Console.WriteLine("ETA' CON DATETIME");
            Console.WriteLine("Inserire il codice fiscale della persona di cui si vuole calcolare l'età:");
            string CF = Console.ReadLine();

            DateTime oggi = DateTime.Now;
            int età = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (CF == a[i].id)
                {
                    età = oggi.Year - a[i].nascita.Year;

                    if (oggi.Month < a[i].nascita.Month || (oggi.Month == a[i].nascita.Month && oggi.Day < a[i].nascita.Day))
                    {
                        età--;
                    }
                    break;
                }
            }

            Console.WriteLine($"Età con DateTime: {età}");
        }

        static void Età2(List<persona> a)
        {
            Console.WriteLine("ETA' SENZA DATETIME");
            Console.WriteLine("Inserire il codice fiscale della persona di cui si vuole calcolare l'età:");
            string CF = Console.ReadLine();

            Console.WriteLine("Inserire la data di oggi:");
            string dataOggi = Console.ReadLine();

            string[] oggi = new string[3];
            oggi = dataOggi.Split('/');

            int età = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (CF == a[i].id)
                {
                    int[] nascita = new int[3];
                    nascita[0] = Convert.ToInt32(a[i].nascita.Day);
                    nascita[1] = Convert.ToInt32(a[i].nascita.Month);
                    nascita[2] = Convert.ToInt32(a[i].nascita.Year);


                    età = Convert.ToInt32(oggi[2]) - nascita[2];

                    if (Convert.ToInt32(oggi[1]) < nascita[1] || (Convert.ToInt32(oggi[1]) == nascita[1] && Convert.ToInt32(oggi[0]) < nascita[0]))
                    {
                        età--;
                    }
                    break;
                }
            }

            Console.WriteLine($"Età senza DateTime: {età}");
        }

        static void Cancella(List<persona> a)
        {
            persona supporto = new persona();
            bool presente = false;

            Console.WriteLine("Inserire il codice fiscale della persona da cancellare:");
            string CF = Console.ReadLine();

            for (int i = 0; i < a.Count; i++)
            {
                if (CF == a[i].id)
                {
                    presente = true;
                    supporto = a[i];
                    supporto.id = "";
                    supporto.stato = stato.cancellato;
                    a[i] = supporto;
                }
                break;
            }

            if (!presente)
            {
                Console.WriteLine("Persona non presente nella lista");
            }
        }

        static void Modifica(List<persona> a)
        {
            persona supporto = new persona();
            bool presente = false;

            Console.WriteLine("Inserire il codice fiscale della persona da modificare:");
            string CF = Console.ReadLine();

            for (int i = 0; i < a.Count; i++)
            {
                if (CF == a[i].id)
                {
                    presente = true;
                    supporto = a[i];

                    Console.WriteLine("Inserire lo stato civile desiderato:");
                    Console.WriteLine("[1] Celibe");
                    Console.WriteLine("[2] Coniugato");
                    Console.WriteLine("[3] Vedovo");
                    Console.WriteLine("[4] Separato");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case (1):
                            supporto.statoCivile = statoCivile.Celibe;
                            break;

                        case (2):
                            supporto.statoCivile = statoCivile.Coniugato;
                            break;

                        case (3):
                            supporto.statoCivile = statoCivile.Vedovo;
                            break;

                        case (4):
                            supporto.statoCivile = statoCivile.Separato;
                            break;
                    }

                    a[i] = supporto;
                }
                break;
            }

            if (!presente)
            {
                Console.WriteLine("Persona non presente nella lista");
            }
        }

        static void getFiles()
        {
            string[] files = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory + "\\FileLog"));
            if (files.Length != 0)
            {
                int i = 1;
                foreach (string file in files)
                {
                    Console.WriteLine($"[{i}] {Path.GetFileName(file)}");
                    i++;
                }

                int scelta;

                do
                {
                    Console.WriteLine("Inserire il numero del file che si vuole visualizzare:");
                    scelta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------");

                    if (scelta < 0 || scelta > files.Length)
                    {
                        Console.WriteLine("Scelta non valida");
                    }
                } while (scelta < 0 || scelta > files.Length);

                LeggiFile(Path.Combine(Environment.CurrentDirectory + "\\FileLog" + $"\\log{scelta}"));
            }
            else
            {
                Console.WriteLine("Cartella Log vuota.");
                Console.WriteLine("----------------");
            }
        }

        static void ScriviFile(string directory, string contenuto)
        {
            StreamWriter sw = File.AppendText(directory);
            sw.WriteLine($"{DateTime.Now.ToString()} {contenuto}");
            sw.Close();
        }

        static void LeggiFile(string directory)
        {
            StreamReader sr = File.OpenText(directory);
            string linea;

            linea = sr.ReadLine();

            while (linea != null)
            {
                Console.WriteLine(linea);
                linea = sr.ReadLine();
            }

            sr.Close();
            Console.WriteLine("----------------");
        }

        static void ScriviCSV(List<persona> a)
        {
            StreamWriter swcsv = File.AppendText(Environment.CurrentDirectory + "\\FileLog" + "\\Log.csv");
            string scrivi;

            for (int i = 0; i < a.Count; i++)
            {
                scrivi = String.Format($"{a[i].nome}, {a[i].cognome}, {a[i].cittadinanza}, {a[i].id}, {a[i].genere}, {a[i].statoCivile}, {a[i].stato}, {a[i].nascita}");
                swcsv.WriteLine(scrivi);
            }
            swcsv.Close();
        }

        static void LeggiCSV()
        {
            StreamReader srcsv = File.OpenText(Environment.CurrentDirectory + "\\FileLog" + "\\Log.csv");
            persona supporto = new persona();

            List<persona> listaTemp = new List<persona>();

            while (!srcsv.EndOfStream)
            {
                string[] vettore = srcsv.ReadLine().Split(',');

                supporto.nome = vettore[0];
                supporto.cognome = vettore[1];
                supporto.cittadinanza = vettore[2];
                supporto.id = vettore[3];

                if (vettore[4] == "Maschio")
                    supporto.genere = sesso.Maschio;
                else
                    supporto.genere = sesso.Femmina;

                switch (vettore[5])
                {
                    case "Celibe":
                        supporto.statoCivile = statoCivile.Celibe;
                        break;
                    case "Nubile":
                        supporto.statoCivile = statoCivile.Nubile;
                        break;
                    case "Coniugato":
                        supporto.statoCivile = statoCivile.Coniugato;
                        break;
                    case "Vedovo":
                        supporto.statoCivile = statoCivile.Vedovo;
                        break;
                    case "Separato":
                        supporto.statoCivile = statoCivile.Separato;
                        break;
                }

                switch (vettore[6])
                {
                    case "libero":
                        supporto.stato = stato.libero;
                        break;

                    case "occupato":
                        supporto.stato = stato.occupato;
                        break;

                    case "cancelllato":
                        supporto.stato = stato.cancellato;
                        break;
                }

                supporto.nascita = DateTime.Parse(vettore[7]);

                listaTemp.Add(supporto);
            }

            foreach (persona p in listaTemp)
            {
                Console.WriteLine(p);
            }
        }
    }
}
