using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    internal class Flotte
    {
        string _nome;
        string _autorizzazione;
        List<Veicoli> _parcoVeicoli;

        public Flotte(string nome)
        {
            _nome = nome;
            _autorizzazione = GeneraAutorizzazione();
            _parcoVeicoli = new List<Veicoli>();
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Autorizzazione
        {
            get { return _autorizzazione; }
            set { _autorizzazione = value; }
        }

        public List<Veicoli> Lista()
        {
            List<Veicoli> lista = new List<Veicoli>();
            lista.AddRange(_parcoVeicoli);
            
            return lista;
        }

        public void AggiungiAllaLista(Veicoli temp)
        {
            _parcoVeicoli.Add(temp);
        }
        static string GeneraAutorizzazione()
        {
            string autorizzazione;
            Random randomico = new Random();
            autorizzazione = Convert.ToString(randomico.Next(10000, 100000));
            autorizzazione += Convert.ToChar(randomico.Next(65, 91));
            return autorizzazione;
        }

        public int Ricerca(string elemento)
        {
            int indice;

            indice = _parcoVeicoli.FindIndex(Veicoli => Veicoli.Targa == elemento);

            return indice;
        }

        public void RimuoviElemento()
        {
            Console.Write("Inserire la targa dell'elemento da eliminare: ");
            string targa = Console.ReadLine();
            int i = Ricerca(targa);

            if (i != -1)
            {
                _parcoVeicoli.RemoveAt(i);
                Console.WriteLine("Elemento rimosso con successo");
            }
            else
            {
                Console.WriteLine("Elemento non trovato");
            }
        }
    }
}
