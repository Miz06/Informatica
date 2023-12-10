using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace VerificaConListe
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
        { //Correzione verifica Alessandro Mizzon 4E
            List<studente> classe = new List<studente>();
            int scelta, indice = 0;
            bool continua = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Inserire un numero corrispondente ad una scelta:\n[1] Inserimento\n[2] Visualizzazione");
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
                    catch (Exception coca)
                    {
                        Console.WriteLine(coca.Message);
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
                doppio = false;
                doppio = Controllo(temp, lista, doppio);
            } while (doppio);
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
    }
}


