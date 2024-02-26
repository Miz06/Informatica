using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaForm2
{
    internal class Banca
    {
        string nomeBanca;
        List<Conto> conti;
        static int numero = 0;

        public Banca(string _nomeBanca)
        {
            nomeBanca = _nomeBanca;
            conti = new List<Conto>();
        }

        public int IncrementaNumero()
        {
            return numero++;
        }

        public void AddConto(Conto c)
        {
            conti.Add(c);
        }

        public List<Conto> Lista()
        {
            List<Conto> copia = new List<Conto>();
            copia.AddRange(conti);
            
            return copia;
        }
    }
}
