using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    internal class Veicoli
    {
        string marca;
        Targa targa;
        string modello;
        int codice;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Targa Targa
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


    }
}
