using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flotte f = new Flotte("Flotta1");
            int scelta;
            int codice = 1;
            string[] menu = new string[] { "Aggiungi veicolo", "Visualizza", "Rimuovi elemento", "Visualizza elemento", "Scrivere la flotta in un file di log", "Leggi contenuto del file di log", "Ripulisci il file di log", "Esci"};
            bool esci = false, ripeti = false;
            List<Autonoleggio> autonoleggios = new List<Autonoleggio>();//<-----lista per macchine con autonoleggio

            do
            {
                Console.WriteLine("-------------------------");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menu[i]}");
                }
                Console.WriteLine("-------------------------");

                do
                {
                    Console.Write("Scelta: ");
                    ripeti = int.TryParse(Console.ReadLine(), out scelta);

                    if (!ripeti || scelta < 1 || scelta > menu.Length)
                        Console.WriteLine("Si prega di reinserire una tra le opzioni di scelta proposte  ");

                } while (!ripeti || scelta < 1 || scelta > menu.Length);

                Console.WriteLine("-------------------------");

                switch (scelta)
                {
                    case 1:
                        AggiungiVeicolo(ref codice, ref f);
                        break;
                    case 2:
                        Visualizza(f);
                        break;
                    case 3:
                        f.RimuoviElemento();
                        break;
                    case 4:
                        VisualizzaElemento(f);
                        break;
                    case 5:
                        ScriviFile(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"), f);
                        break;
                    case 6:
                        LeggiFile(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"));
                        break;
                    case 7:
                        PulisciLog(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"));
                        break;
                    case 8:
                        esci = true;
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            } while (!esci);
        }
        static void AggiungiVeicolo(ref int codice, ref Flotte flotta)
        {
            int posti;
            Veicoli v = new Veicoli();

            Governo targa = new Governo();
            v.Targa = targa.GeneraTarga();

            v.Codice = codice;
            codice++;

            Console.Write("Marca: ");
            v.Marca = Console.ReadLine();

            Console.Write("Modello: ");
            v.Modello = Console.ReadLine();

            Console.Write("Posti veicolo:\n[1] Due\n[2] Quattro\n[3] Sei\n[4] Otto\nScelta:");
            posti = Convert.ToInt32(Console.ReadLine());

            switch (posti)
            {
                case 1:
                    v.Posti = P.two;
                    break;
                case 2:
                    v.Posti = P.four;
                    break;
                case 3:
                    v.Posti = P.six;
                    break;
                case 4:
                    v.Posti = P.eight;
                    break;
            }
            flotta.AggiungiAllaLista(v);
        }
        static void Visualizza(Flotte flotta)
        {
            Console.WriteLine($"Nome flotta: {flotta.Nome}");
            Console.WriteLine($"Autorizzazione: {flotta.Autorizzazione}");

            List<Veicoli> list = new List<Veicoli>();
            list = flotta.Lista();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"[Veicolo n°{i + 1}]");
                Console.WriteLine($"Marca: {list[i].Marca}");
                Console.WriteLine($"Targa: {list[i].Targa}");
                Console.WriteLine($"Modello: {list[i].Modello}");
                Console.WriteLine($"Codice: {list[i].Codice}");
                Console.WriteLine($"Posti: {list[i].Posti}");
            }
        }
        static void VisualizzaElemento(Flotte f)
        {
            List<Veicoli> list = new List<Veicoli>();
            list = f.Lista();

            Console.Write("Inserire la targa dell'elemento da visualizzare: ");
            string targa = Console.ReadLine();
            int i = f.Ricerca(targa);

            if (i != -1)
            {
                Console.WriteLine($"Nome flotta: {f.Nome}");
                Console.WriteLine($"Autorizzazione: {f.Autorizzazione}");

                Console.WriteLine();
                Console.WriteLine($"[Veicolo n°{i + 1}]");
                Console.WriteLine($"Marca: {list[i].Marca}");
                Console.WriteLine($"Targa: {list[i].Targa}");
                Console.WriteLine($"Modello: {list[i].Modello}");
                Console.WriteLine($"Codice: {list[i].Codice}");
                Console.WriteLine($"Posti: {list[i].Posti}");
            }
            else
                Console.WriteLine("Elemento non trovato");
        }
        static void ScriviFile(string directory, Flotte flotta)
        {
            StreamWriter sw = File.AppendText(directory);
            sw.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");
            sw.WriteLine($"{DateTime.Now.ToString()}");
            sw.WriteLine($"Nome flotta: {flotta.Nome}");
            sw.WriteLine($"Autorizzazione: {flotta.Autorizzazione}");
            sw.WriteLine("");

            List<Veicoli> list = new List<Veicoli>();
            list = flotta.Lista();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine();
                sw.WriteLine($"[Veicolo n°{i + 1}]");
                sw.WriteLine($"Marca: {list[i].Marca}");
                sw.WriteLine($"Targa: {list[i].Targa}");
                sw.WriteLine($"Modello: {list[i].Modello}");
                sw.WriteLine($"Codice: {list[i].Codice}");
                sw.WriteLine($"Posti: {list[i].Posti}");
            }
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
        }
        
        static void PulisciLog(string directory)
        {
            File.WriteAllText(directory, string.Empty);
        }
    }
}
