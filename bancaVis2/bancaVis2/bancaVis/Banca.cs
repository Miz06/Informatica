using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bancaVis
{
    class Banca
    {
        List<Conto> contiCorrenti;
        static int id;
        private string name;

        public Banca(string _name)
        {
            name = _name;
            contiCorrenti = new List<Conto>();
        }

        static public int Id
        {
            get { return ++id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AggiungiConti(Conto c)
        {
            contiCorrenti.Add(c);
        }

        public List<Conto> CopyCorrentisti()
        {
            List<Conto> newCorrentisti = new List<Conto>();
            newCorrentisti.AddRange(contiCorrenti);
            return newCorrentisti;
        }
    }
}
