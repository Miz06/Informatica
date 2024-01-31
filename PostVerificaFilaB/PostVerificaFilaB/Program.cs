using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostVerificaFilaB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca banca = new Banca("La banca di Luigi");
            string[] arr = new string[] { "Aggiungi conto", "Visualizza conti", "Visualizza totale", "Aggiungi al conto", "Preleva", "Visualizza log.txt", "Esci" };
            bool esci = false;

            Write("^^^^^^^^^^^^^^^^");
            Write(banca.GetNome);

            do
            {
                Console.WriteLine("Menù:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {arr[i]}");
                }

                Console.WriteLine("------------");
                int scelta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (scelta)
                {
                    case 1:
                        AggiungiConto(banca);
                        break;
                    case 2:
                        Visualizza(banca);
                        break;
                    case 3:
                        Totale(banca);
                        break;
                    case 4:
                        AddToSaldo(banca);
                        break;
                    case 5:
                        RemoveToSaldo(banca);
                        break;
                    case 6:
                        Read();
                        break;
                    case 7:
                        esci = true;
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            } while (!esci);

        }

        static void AggiungiConto(Banca b)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Conto c = new Conto(nome, cognome, b.Numero());

            b.AggiungiContoBanca(c);

            Write($"{DateTime.Now.ToString()} - Aggiunto conto: {c.ToString()}");
        }

        static void Visualizza(Banca b)
        {
            Console.WriteLine(b.GetNome);
            Console.WriteLine("-----------------------");
            b.ListaConti().ForEach(elemento => Console.WriteLine(elemento.ToString()));
        }

        static void Totale(Banca b)
        {
            Console.WriteLine($"Saldo totale: {b.Totale()}");
        }

        static void AddToSaldo(Banca b)
        {
            Console.Write("Numero conto: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aggiungere: ");
            int add = Convert.ToInt32(Console.ReadLine());

            if (b.AddToSaldo(n, add))
            {
                Write($"{DateTime.Now.ToString()} >> Aggiunto al conto {n}: +{add}");
            }
        }
        static void RemoveToSaldo(Banca b)
        {
            Console.Write("Numero conto: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Prelevare: ");
            int add = Convert.ToInt32(Console.ReadLine());

            if (b.RemoveToSaldo(n, add))
            {
                Write($"{DateTime.Now.ToString()} >> Prelevato dal conto {n}: -{add}");
            }
        }

        static void Write(string stringa)
        {
            StreamWriter sw = File.AppendText(Path.Combine(Environment.CurrentDirectory + "\\log.txt"));
            sw.WriteLine(stringa);
            sw.Close();
        }

        static void Read()
        {
            StreamReader sr = File.OpenText(Path.Combine(Environment.CurrentDirectory + "\\log.txt"));
            string linea = sr.ReadLine();

            if (linea != null)
            {
                do
                {
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();
                } while (linea != null);
            }
        }
    }
}
