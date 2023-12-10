using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PostVerficaCsvMetodi
{
    public enum MM
    {
        maggiorenne,
        minorenne,
    }

    public struct studente
    {
        public string nome;
        public string cognome;
        public int voto;
        public DateTime nascita;
        public MM stato;

        public override string ToString()
        {
            return String.Format($"Nome: {nome}, Cognome: {cognome}, Voto: {voto}, Nascita: {nascita}, Stato: {stato}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon 4E
            List<studente> classe = new List<studente>();
            int scelta, indice = 0;
            bool continua = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Inserire un numero corrispondente ad una scelta:\n[1] Inserimento\n[2] Visualizzazione\n[3] csv\n[4] Rimuovi\n[5] Vedi maggiorenni");
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case (1):
                        if (classe.Count < 4)
                        {
                            Inserimento(classe, indice);
                            indice++;
                        }
                        else
                        {
                            Console.WriteLine("Classe piena");
                        }
                        break;

                    case (2):
                        Visualizzazione(classe);
                        break;

                    case (3):
                        ScriviCsv(Path.Combine(Environment.CurrentDirectory + "\\FileCsv" + "\\logcsv"), classe);
                        LeggiCsv(Path.Combine(Environment.CurrentDirectory + "\\FileCsv" + "\\logcsv"), classe);
                        break;

                    case (4):
                        Rimuovi(classe);
                        break;

                    case (5):
                        string[] array = Maggiorenni(classe);

                        Console.WriteLine("Maggiorenni:");
                        foreach (string nome in array)
                        {
                            Console.WriteLine(nome);
                        }
                        break;
                }

                Console.WriteLine("Desideri uscire?\n[1] No\n[2] Sì");
                int s = Convert.ToInt32(Console.ReadLine());

                if (s == 1)
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }
            } while (continua);

        }

        static void Inserimento(List<studente> lista, int indice)
        {
            bool doppio, valido;
            studente temp = new studente();

            do
            {
                Console.WriteLine("Inserire il nome:");
                temp.nome = Console.ReadLine();
                Console.WriteLine("Inserire il cognome");
                temp.cognome = Console.ReadLine();

                doppio = VerificaPresenza(lista, temp.nome, temp.cognome);

                if (doppio)
                {
                    Console.WriteLine("Studente già presente");
                }
            } while (doppio);

            do
            {
                valido = true;
                Console.WriteLine("Inserire il voto");
                try
                {
                    temp.voto = Convert.ToInt32(Console.ReadLine());
                    if (temp.voto < 0 || temp.voto > 10)
                    {
                        valido = false;
                        throw new Exception("Voto non nel range adeguato");
                    }

                }
                catch (Exception nonValido)
                {
                    Console.WriteLine(nonValido.Message);
                }
            } while (!valido);


            Console.WriteLine("Inserire la data di nascita (formato: dd/mm//yy)");
            temp.nascita = Convert.ToDateTime(Console.ReadLine());

            int età = Età(temp.nascita, indice);

            if (età >= 18)
            {
                temp.stato = MM.maggiorenne;
            }
            else
            {
                temp.stato = MM.minorenne;
            }

            lista.Add(temp);
            //doppio = false
            //doppio = Controllo(temp, lista, doppio);
        }

        static bool Controllo(studente temp, List<studente> classe, bool doppio)
        {
            for (int i = 0; i < classe.Count; i++)
            {
                if (temp.nome == classe[i].nome && temp.cognome == classe[i].cognome)
                {
                    Console.WriteLine("Studente già presente, reinserirlo");
                    doppio = true;
                    break;
                }
            }

            if (!doppio)
            {
                classe.Add(temp);
            }

            return doppio;
        }

        static void Visualizzazione(List<studente> classe)
        {
            for (int i = 0; i < classe.Count; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(classe[i]);
                Console.WriteLine("-----------------------");
            }
        }

        static int Età(DateTime temp, int indice)
        {
            DateTime Dataodierna = DateTime.Now;
            int età;

            età = Dataodierna.Year - temp.Year;

            if (Dataodierna.Month < temp.Month || Dataodierna.Month == temp.Month && Dataodierna.Day < temp.Day)
            {
                età--;
            }

            return età;
        }

        static void ScriviCsv(string directory, List<studente> a)
        {
            StreamWriter sw = File.AppendText(directory);
            string scrivi;

            for (int i = 0; i < a.Count; i++)
            {
                scrivi = String.Format($"{a[i].nome}, {a[i].cognome}, {a[i].voto}, {a[i].nascita}, {a[i].stato}");
                sw.WriteLine(scrivi);
            }

            sw.Close();
        }

        static void LeggiCsv(string directory, List<studente> a)
        {
            StreamReader sr = File.OpenText(directory);
            string leggi = sr.ReadLine().ToString();
            studente supporto = new studente();

            while (leggi != null)
            {
                string[] vettore = leggi.Split(',');
                supporto.nome = vettore[0];
                supporto.cognome = vettore[1]; ;
                supporto.voto = Convert.ToInt32(vettore[2]);
                supporto.nascita = DateTime.Parse(vettore[3]);
                if (vettore[4] == "Maggiorenne")
                    supporto.stato = MM.maggiorenne;
                else
                    supporto.stato = MM.minorenne;

                Console.WriteLine(supporto.ToString());
                leggi = sr.ReadLine();
            }

            sr.Close();
        }

        static bool VerificaPresenza(List<studente> a, string nome, string cognome)
        {
            bool doppio = false;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].nome.Contains(nome) && a[i].cognome.Contains(cognome))
                {
                    doppio = true;
                    break;
                }
            }

            return doppio;
        }

        static void Rimuovi(List <studente> lista)
        {
            string nome, cognome;
            bool trovato = false;
            Console.WriteLine("Inserire il nome dello studente da rimuovere:");
            nome = Console.ReadLine();
            Console.WriteLine("Inserire il cognome dello studente da rimuovere:");
            cognome = Console.ReadLine();

            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].nome == nome && lista[i].cognome == cognome)
                {
                    lista.RemoveAt(i);
                    trovato = true;
                }
            }

            if (!trovato)
            {
                Console.WriteLine("Studente non trovato");
            }
        }

        static string[] Maggiorenni(List <studente> lista)//metodo che trovi i maggiorenni all interno della lista e li inserisca in un array
        {
            List <studente> maggiorenni = new List<studente>();

            maggiorenni = lista.FindAll(s => s.stato == MM.maggiorenne);

            string[] array = new string[maggiorenni.Count];

            for (int i = 0; i< maggiorenni.Count; i++)
            {
                array[i] = maggiorenni[i].nome;
            }

            return array;
        }
    }
}

