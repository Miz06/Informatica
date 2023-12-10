using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Reparto
    {
        string _nomeReparto;
        List<Paziente> Pazienti;
        Termometro termometro;
        public Reparto(string nomeReparto)
        {
            string _nomeReparto;
            Pazienti = new List<Paziente>();
            termometro = new Termometro();
        }
        public Reparto(string nomeReparto, int nPazienti)
        {
            _nomeReparto = nomeReparto;
            Pazienti = new List<Paziente>(nPazienti);
            termometro = new Termometro();
        }
        public void AggiungiPaziente(Paziente p)
        {
            Pazienti.Add(p);
        }
        public void StampaPazienti()
        {
            foreach (Paziente p in Pazienti)
            {
                Console.WriteLine(p.Anagrafica());
            }
        }
        public Paziente Ricerca(string nome, string cognome)
        {
            return Pazienti.Find(p => p.GetNome() == nome && p.GetCognome() == cognome);
        }
        public void ModificaTemperatura(string nome, string cognome, double temperatura)
        {
            Paziente pazienteDaRicercare = Ricerca(nome, cognome);
            if (pazienteDaRicercare != null)
            {
                termometro.ResetTemperatura();
                termometro.CambiaTemperatura(temperatura);
                pazienteDaRicercare.SetTemperatura(termometro.GetTemperatura());
            }
            else
            {
                throw new Exception("Il paziente non è presente");
            }
        }
        public List<Paziente> GetList()
        {
            List<Paziente> nuovaLista = new List<Paziente>();
            foreach (Paziente p in Pazienti)
            {
                nuovaLista.Add(p);
            }
            return nuovaLista;
        }
        public void PazientiFebbre()
        {
            foreach (Paziente p in Pazienti)
            {
                if (p.GetTemperatura() > 36)
                {
                    Console.WriteLine(p.Anagrafica());
                }
            }
        }
    }
}