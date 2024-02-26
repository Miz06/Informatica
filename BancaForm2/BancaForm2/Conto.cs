using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BancaForm2
{
    internal class Conto
    {
        string nome, cognome;
        double saldo;
        int numero;

        public Conto(string _nome, string _cognome, double _saldo, int _numero)
        {
            nome = _nome;
            cognome = _cognome;
            saldo = _saldo;
            numero = _numero;
        }

        public Conto(string _nome, string _cognome, int _numero):this(_nome, _cognome, 10, _numero)
        {
        }

        public void AddToConto(int aggiungi)
        {
            saldo += aggiungi;
        }

        public bool RemoveToConto(int rimuovi)
        {
            if (saldo < rimuovi)
            {
                return false;
            }
            else
            {
                saldo -= rimuovi;
                return true;
            }
        }

        public string StringaConto()
        {
            return ($"nome: {nome} | cognome: {cognome} | saldo: {saldo} | numero: {numero}");
        }
    }
}
