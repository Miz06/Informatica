using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoneStudenti
{
    internal class Studente : Persona
    {
        int matricola;
        static int n = 1;

        public Studente(string _nome, string _cognome, int _anni) : base(_nome, _cognome, _anni)
        {
            matricola = Matricola();
        }

        static int Matricola()
        {
            return n++;
        }

        override public string Scrivi()
        {
            return ($"STUDENTE => Nome: {nome} | Cognome: {cognome} | Anni: {anni} | Matricola: {matricola}");
        }
    }
}
