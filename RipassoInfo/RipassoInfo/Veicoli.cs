using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    enum P
    { 
        two = 2,
        four = 4,
        six = 6, 
        eight = 8
    }
    internal class Veicoli
    {
        string marca;
        string targa;
        string modello;
        int codice;
        P posti;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Targa
        {
            get { return targa; }
            set { targa = value; }
        }
        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }
        public int Codice
        {
            get { return codice; }
            set { codice = value; }
        }

        public P Posti
        {
            get { return posti; }
            set { posti = value; }
        }


    }
}
