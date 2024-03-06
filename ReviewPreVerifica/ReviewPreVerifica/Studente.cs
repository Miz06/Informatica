using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewPreVerifica
{
    internal class Studente
    {
        int anni;
        public string nome, cognome;
        int media;

        public override string ToString()
        {
            return String.Format($"nome: {nome} - cognome: {cognome} - anni: {anni} - media: {media}");
        }

        public Studente(int _anni, string _nome, string _cognome)
        {
            anni = _anni;
            nome = _nome;
            cognome = _cognome;
            media = GeneraMedia();
        }

        public int GeneraMedia()
        {
            Random r = new Random();
            return r.Next(3, 11);
        }
    }
}