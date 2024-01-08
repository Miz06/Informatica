using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    internal class Flotte<>
    {
        string _nome;
        string _autorizzazione;
        List<Veicoli> _parcoVeicoli;

        public Flotte(string nome, string autorizzazione)
        {
            _nome = nome;
            _autorizzazione = autorizzazione;
            _parcoVeicoli = new List<Veicoli>();
        }

        /*
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
        */
        public void AggiungiAllaLista(Veicoli temp)
        {
            _parcoVeicoli.Add(temp);
        }
    }
}
