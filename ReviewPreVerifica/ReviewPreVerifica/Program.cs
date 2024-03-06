using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPreVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classe classe = new Classe("4E");
            string[] opzioni = new string[] { "Aggiungi", "Rimuovi", "Posizione stud", "Visualizza", "Leggi log" };
            bool esci = false;
            int scelta;
            string directory = Path.Combine(Environment.CurrentDirectory + "\\log.txt");


            do
            {
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {opzioni[i]}");
                }

                Console.Write("\nScelta: ");
                scelta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (scelta)
                {
                    case 1:
                        AddStud(classe);
                        Scrivi(directory, classe);
                        break;
                    case 2:
                        RemoveStud(classe);
                        Scrivi(directory, classe);
                        break;
                    case 3:
                        CercaStud(classe);
                        break;
                    case 4:
                        Visualizza(classe);
                        break;
                    case 5:
                        Leggi(directory);
                        break; 
                }

                Console.ReadLine();
                Console.Clear();
            } while (!esci);

            
        }

        static void AddStud(Classe c)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            int anni;
            bool good = false;

            do
            {
                Console.Write("Anni: ");
                good = int.TryParse(Console.ReadLine(), out anni);

                //if (!good)
                //{
                //    throw new Exception("Errore");
                //}
            } while (!good);

            Studente s = new Studente(anni, nome, cognome);

            c.AggiungiStudente(s);
        }

        static void RemoveStud(Classe c)
        {
            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            c.RimuoviStudente(cognome);
        }

        static void CercaStud(Classe c)
        {
            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            int posizione = c.Ricerca(cognome);

            if (posizione != -1)
            {
                Console.WriteLine($"Posizione: {posizione}");
            }
            else
            {
                Console.WriteLine("Studente non presente");
            }
        }

        static void Visualizza(Classe c)
        {
            (c.Visualizza()).ForEach(v => Console.WriteLine(v.ToString()));
        }

        static void Scrivi(string directory, Classe c)
        {
            StreamWriter sw = File.AppendText(directory);
            sw.WriteLine("^^^^^^^^^^^^^^^^^");
            sw.WriteLine(DateTime.Now.ToString());
            (c.Visualizza()).ForEach(v => sw.WriteLine(v.ToString()));
            sw.Close();
        }

        static void Leggi(string directory)
        {
            StreamReader sr = File.OpenText(directory);

            string linea = sr.ReadLine();

            if (linea != null)
            {
                do
                {
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();
                }while(linea != null);
            }

            sr.Close();
        }
    }
}