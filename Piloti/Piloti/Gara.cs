using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Piloti
{
    internal class Gara
    {
        string nomeGara;
        int numScuderie;
        List<Auto> grigliaPartenza;
        string risultato;

        public Gara(string _nomegara, int numscuderie)
        {
            SetGara(_nomegara);
            SetNumScuderie(numscuderie);
            grigliaPartenza = new List<Auto>();
            risultato = "inizio gara";
        }

        private void SetGara(string _nomeGara)
        {
            nomeGara = _nomeGara;
        }

        private string GetGara()
        {
            return nomeGara;
        }
        private void SetNumScuderie(int _numScuderie)
        {
            numScuderie = _numScuderie;
        }

        private int GetNumScuderie()
        {
            return numScuderie;
        }

        public void Aggiungi(Auto a)
        {
            if (grigliaPartenza.Count < 3) 
                grigliaPartenza.Add(a);
            else
                Console.WriteLine("Griglia piena");
        }

        public void Stampa()
        {
            Console.WriteLine("***************************");
            Console.WriteLine($"Gara: {GetGara()}, Scuderie partecipanti: {GetNumScuderie()}, Stato gara: {risultato}");
            Console.WriteLine("***************************");
            Console.WriteLine("Partecipanti:");
            foreach (Auto a in grigliaPartenza)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public int GeneraVincitore()
        {
            Random r = new Random();
            int num = r.Next(0, grigliaPartenza.Count);
            return num;
        }

        public string Vincitore(int num)
        {
            return grigliaPartenza[num].ToString();
        }
    }
}
