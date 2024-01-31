using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostVerificaFilaA
{
    internal class Banca
    {
        string nome;
        List<Conto> conti;
        static int numero = 0;

        public Banca(string _nome)
        {
            nome = _nome;
            conti = new List<Conto>();
        }

        public int Numero()
        {
            return numero++;
        }

        public string GetNome
        {
            get { return nome; }
        }

        public void AggiungiContoBanca(Conto c)
        {
            conti.Add(c);
        }

        public List<Conto> ListaConti()
        {
            List<Conto> c = new List<Conto>();
            c.AddRange(conti);
            return c;
        }

        public int Totale()
        {
            int tot = 0;

            conti.ForEach(elemento => tot += elemento.GetSaldo);
            return tot;
        }

        public bool AddToSaldo(int n, int add)
        {
            try
            {
                conti[n].AddToSaldo(add);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool RemoveToSaldo(int n, int remove)
        {
            try
            {
                conti[n].RemoveToSaldo(remove);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
