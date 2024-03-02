using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoneStudenti
{
    internal class Persona
    {
        protected string nome, cognome;
        protected int anni;

        public Persona(string _nome, string _cognome, int _anni)
        {
            nome = _nome;
            cognome = _cognome;
            anni = _anni;
        }

        virtual public string Scrivi()
        {
            return ($"PERSONA => Nome: {nome} | Cognome: {cognome} | Anni: {anni}");
        }

        public string GetName
        {
            get { return nome; }
        }

        public string GetSurname
        {
            get { return cognome; }
        }

        public int GetAge
        {
            get { return anni; }
        }
    }
}
