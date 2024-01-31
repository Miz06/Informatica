using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostVerificaFilaB
{
    internal class Conto
    {
        string nome;
        string cognome;
        int saldo;
        int numero;

        public override string ToString()
        {
            return String.Format($"Nome: {nome} - Cognome: {cognome} - Numero conto: {numero} - Saldo: {saldo}");
        }

        public Conto(string _nome, string _cognome, int _numero)
        {
            nome = _nome;
            cognome = _cognome;
            saldo = 10;
            numero = _numero;
        }

        public int GetSaldo
        {
            get { return saldo; }
        }

        public void AddToSaldo(int add)
        {
            saldo += add;
        }

        public void RemoveToSaldo(int remove)
        { 
            if (saldo < remove)
            {
                throw new Exception("Saldo insufficiente");
            }
            else
            {
                saldo -= remove;
            }
        }
    }
}
