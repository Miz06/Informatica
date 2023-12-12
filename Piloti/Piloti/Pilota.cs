using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piloti
{
    internal class Pilota
    {
        string nome;
        string auto;

        public Pilota(string _nome, string _auto)
        {
            SetNome(_nome);
            SetAuto(_auto);
        }

        private void SetNome(string _nome)
        {
            nome = _nome;
        }

        private string GetNome()
        {
            return nome;
        }

        private void SetAuto(string _auto)
        {
            auto = _auto;
        }

        private string GetAuto()
        {
            return auto;
        }

        public override string ToString()
        {
            return String.Format($"nome: {GetNome()}, auto: {GetAuto()}");
        }
    }
}
