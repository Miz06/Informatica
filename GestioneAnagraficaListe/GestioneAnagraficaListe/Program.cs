using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrafica
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

        public override string ToString()
        {
            return String.Format($"Nome: {nome}, Cognome: {cognome}, Cittadinanza: {cittadinanza}, id: {id}, Genere: {genere}, Stato: {stato}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon 4E
            string[] opzioni = new string[] { "Inserimento", "Visualizzazione", "MenùLog" };
            int scelta, indice = 0, esci;

            List<persona> Anagrafica = new List<persona>();

            do
            {
                Menu(opzioni, out scelta);

                switch (scelta)
                {
                    case (1):
                        if (indice < 3)
                        {
                            Inserimento(Anagrafica, indice);
                            ScriviFile(Path.Combine(Environment.CurrentDirectory) + $@"\log{Anagrafica.Count+1}.txt", Anagrafica[indice].ToString()); //vado a creare e scrivere o direttamente scrivere nel file logn
                                                                                                                                                      //dove n è uguale alla lunghezza dell'array contenente i file.txt nella directory corrente
                            indice++;
                        }
                        else
                        {
                            Console.WriteLine("Anagrafe piena");
                        }
                        break;
                    case (2):
                        Visualizzazione(Anagrafica, indice);
                        break;
                    case (3):
                        getFiles(Environment.CurrentDirectory); //Dando al metodo la directory corrente, questo mi va a stampare i file.txt numerati

                        Console.WriteLine("Inserire un file da visualizzare");
                        int opzione = Convert.ToInt32(Console.ReadLine());

                        LeggiFile(Path.Combine(Environment.CurrentDirectory) + $@"\log{opzione}.txt"); //leggo il contenuto del file desiederato dall'Utente
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
            Console.WriteLine("-----------------");
            Console.WriteLine("MENU':");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} [{i + 1}]");
            }
            Console.WriteLine("-----------------");

            Console.WriteLine("Inserire un opzione:");
            int.TryParse(Console.ReadLine(), out scelta);
            Console.WriteLine("-----------------");

            while (scelta < 1 || scelta > array.Length)
            {
                Console.WriteLine("Scelta non valida, reinserire: ");
                Console.WriteLine("-----------------");
                int.TryParse(Console.ReadLine(), out scelta);
            }
        }

        static void Inserimento(List<persona> p, int indice) //Inserimento
        {
            persona var = new persona();

            Console.WriteLine("Inserire nome:");
            var.nome = Console.ReadLine();

            Console.WriteLine("Inserire cognome:");
            var.cognome = Console.ReadLine();

            Console.WriteLine("Inserire cittadinanza:");
            var.cittadinanza = Console.ReadLine();

            Console.WriteLine("Inserire il sesso:");
            Console.WriteLine("[1] Maschio");
            Console.WriteLine("[2] Femmina");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                var.genere = sesso.Maschio;
            }
            else
            {
                var.genere = sesso.Femmina;
            }

            Console.WriteLine("Inserire lo stato civile:");
            Console.WriteLine("[1] Celibe");
            Console.WriteLine("[2] Coniugato");
            Console.WriteLine("[3] Vedovo");
            Console.WriteLine("[4] Separato");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case (1):
                    var.stato = statoCivile.Celibe;
                    break;

                case (2):
                    var.stato = statoCivile.Coniugato;
                    break;

                case (3):
                    var.stato = statoCivile.Vedovo;
                    break;

                case (4):
                    var.stato = statoCivile.Separato;
                    break;
            }

            Console.WriteLine("Inserire la data di nascita: (formato:  dd/mm/yyyy)");
            var.nascita = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Inserire l'id:");
            var.id = Console.ReadLine();

            p.Add(var);
        }

        static void Visualizzazione(List<persona> p, int indice)
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
                    Console.WriteLine($"PERSONA {i + 1}");
                    Console.WriteLine(p[i]);
                    Console.WriteLine("-----------------------");
                }
            }
        }

        static void getFiles(string directory)
        {
            string[] files;
            files = Directory.GetFiles(Environment.CurrentDirectory, "*.txt"); //vado a mettere nell'array i percorsi dei file.txt
            int i = 0; 
            foreach (string file in files)
            {
                Console.WriteLine($"{i+1} {Path.GetFileName(file)}"); //stampo il contenuto dell'array ma convertendo i percorsi nel nome del file corrispondente
                i++;
            }
        }

        static void ScriviFile(string percorso, string contenuto)
        {
            StreamWriter sw = File.AppendText(percorso); //apro il percorso in sw
            sw.WriteLine($"{DateTime.Now.ToString()}  {contenuto}"); //scrivo nel percorso il contenuto 
            sw.Close();
        }

        static void LeggiFile(string percorso)
        {
            StreamReader sr = File.OpenText(percorso); //apro il percorso in sr
            string linea;
            linea = sr.ReadLine();
            while (linea != null) //finchè non arrivo al termine del file continuo il ciclo
            {
                Console.WriteLine(linea); //stampo il contenuto della linea di sr
                linea = sr.ReadLine(); //assegno a linea la linea successiva del file
            }

        }
    }
}  