using ReviewPreVerifica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPreVerifica
{
    internal class Classe
    {
        List<Studente> studenti;
        string identificativo;

        public Classe(string _identificativo)
        {
            studenti = new List<Studente>();
            identificativo = _identificativo;
        }

        public void AggiungiStudente(Studente s)
        {
            studenti.Add(s);
        }

        public void RimuoviStudente(string c)
        {
            if ((studenti.Find(s => s.cognome == c)) != null)
            {
                studenti.Remove(studenti.Find(s => s.cognome == c));
            }
            else
            {
                Console.WriteLine("Studente non trovato");
            }
        }

        public List<Studente> Visualizza()
        {
            List<Studente> copia = new List<Studente>();

            copia.AddRange(studenti);

            return copia;
        }

        public int Ricerca(string cognome)
        {
            return studenti.IndexOf(studenti.Find(s => s.cognome == cognome));
        }
    }
}