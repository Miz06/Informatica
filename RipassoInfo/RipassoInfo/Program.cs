using System;
using System.Collections.Generic;
using System.Data;
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
        {//Alessandro Mizzon 4E
            Flotte f = new Flotte("Flotta1");
            int scelta;
            string[] menu = new string[] { "Aggiungi veicolo", "Visualizza", "Rimuovi elemento", "Visualizza elemento","Leggi contenuto del file di log", "Ripulisci il file di log", "Visualizza veicoli per ogni marca", "Esci"};
            bool esci = false, ripeti = false;

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
                        AggiungiVeicolo(f);
                        ScriviFile(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"), f);
                        break;
                    case 2:
                        Visualizza(f);
                        break;
                    case 3:
                        f.RimuoviElemento();
                        ScriviFile(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"), f);
                        break;
                    case 4:
                        VisualizzaElemento(f);
                        break;
                    case 5:
                        LeggiFile(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"));
                        break;
                    case 6:
                        PulisciLog(Path.Combine(Environment.CurrentDirectory + $"\\logFile.txt"));
                        break;
                    case 7:
                        VisualizzaMarca(f);
                        break;
                    case 8:
                        esci = true;
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            } while (!esci);
        }
        static void AggiungiVeicolo(Flotte flotta)
        {
            int posti;
            Veicoli v = new Veicoli();

            try
            {
                v.CodiceVeicolo = Veicoli.Codice;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (Veicoli.Codice < 2)
            {
                v.CodiceVeicolo = Veicoli.Codice;

                v.Targa = Governo.GeneraTarga();

                Console.Write("Marca: ");
                v.Marca = Console.ReadLine();

                Console.Write("Modello: ");
                v.Modello = Console.ReadLine();

                Console.Write("Posti veicolo:\n[1] Due\n[2] Quattro\n[3] Sei\n[4] Otto\nScelta:");

                bool ripeti = false;
                do
                {
                    ripeti = int.TryParse(Console.ReadLine(), out posti);

                    if (!ripeti)
                    {
                        Console.Write("Valore inserito non valido. Reinserirlo:");
                    }
                } while (!ripeti || posti < 1 || posti > 4);

                switch (posti)
                {
                    case 1:
                        v.Posti = P.due;
                        break;
                    case 2:
                        v.Posti = P.quattro;
                        break;
                    case 3:
                        v.Posti = P.sei;
                        break;
                    case 4:
                        v.Posti = P.otto;
                        break;
                }
                flotta.AggiungiAllaLista(v);
            }
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
                Console.WriteLine(list[i].ToString());
            }
        }
        static void VisualizzaElemento(Flotte flotta) 
        {
            List<Veicoli> list = new List<Veicoli>();
            list = flotta.Lista();

            Console.Write("Inserire la targa dell'elemento da visualizzare: ");
            string targa = Console.ReadLine();
            int i = flotta.Ricerca(targa);

            if (i != -1)
            {
                Console.WriteLine($"Nome flotta: {flotta.Nome}");
                Console.WriteLine($"Autorizzazione: {flotta.Autorizzazione}");

                Console.WriteLine();
                Console.WriteLine(list[i].ToString());
            }
            else
                Console.WriteLine("Elemento non trovato");
        }
        static void ScriviFile(string directory, Flotte flotta)
        {
            StreamWriter sw = File.AppendText(directory);
            sw.WriteLine();
            sw.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");
            sw.WriteLine($"{DateTime.Now.ToString()}");
            sw.WriteLine($"Nome flotta: {flotta.Nome}");
            sw.WriteLine($"Autorizzazione: {flotta.Autorizzazione}");

            List<Veicoli> list = new List<Veicoli>();
            list = flotta.Lista();

            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine();
                sw.WriteLine(list[i].ToString());
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
        static void VisualizzaMarca(Flotte f)
        {
            List<Veicoli> listaVeicoli = new List<Veicoli>();
            listaVeicoli = f.Lista();

            List<string> marche = new List<string>();

            bool doppio = false;

            for (int j = 0; j < listaVeicoli.Count; j++)
            {
                doppio = false;

                for (int i = 0; i < marche.Count; i++)
                {
                    if (listaVeicoli[j].Marca == marche[i])
                    {
                        doppio = true;
                        break;
                    }
                }

                if (!doppio)
                    marche.Add(listaVeicoli[j].Marca);
            }

            int[] contaMarche = new int[marche.Count];

            for (int i = 0; i<marche.Count; i++)
            {
                for (int j = 0; j < listaVeicoli.Count; j++)
                {
                    if (marche[i] == listaVeicoli[j].Marca)
                    {
                        contaMarche[i]++;
                    }
                }

                Console.WriteLine($"{marche[i]}: {contaMarche[i]}");
            }
        }
    }
}
