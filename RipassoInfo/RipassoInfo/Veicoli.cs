using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    enum P
    {
        due = 2,
        quattro = 4,
        sei = 6,
        otto = 8
    }
    internal class Veicoli
    {
        string marca;
        string targa;
        string modello;
        int codiceVeicolo;
        static int codice;
        P posti;

        public override string ToString()
        {
            return String.Format($"Marca: {marca}\nModello: {modello}\nTarga: {targa}\nCodice: {codice}\nPosti: {posti}");
        }

        public Veicoli()
        {
            codice++;
        }
        public int CodiceVeicolo
        {
            get { return codiceVeicolo; }
            set
            {
                codiceVeicolo = value;
                if (codiceVeicolo > 1)
                {
                    throw new Exception("Limite 1000 auto raggiunto");
                }
            }
        }

        static public int Codice
        {
            get { return codice; }
            set { codice = value; }
        }

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

        public P Posti
        {
            get { return posti; }
            set { posti = value; }
        }


    }
}
