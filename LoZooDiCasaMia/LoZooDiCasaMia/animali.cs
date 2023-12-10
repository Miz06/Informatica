using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoZooDiCasaMia
{
    internal class animali
    {
        string specie;
        string razza;
        string cibo;
        int quantità;
        string verso;
        mangiato statoMangiare;

        //Specie
        public void SetSpecie(string specie)
        {
            this.specie = specie;
        }

        public string GetSpecie()
        {
            return this.specie;
        }

        //Razza
        public void SetRazza(string razza)
        {
            this.razza = razza;
        }

        public string GetRazza()
        {
            return this.razza;
        }

        //Cibo
        public void SetCibo(string cibo)
        {
            this.cibo = cibo;
        }

        public string GetCibo()
        {
            return this.cibo;
        }

        //Quantità
        public void SetQuantità(int quantità)
        {
            this.quantità = quantità;
        }

        public int GetQuantita()
        {
            return this.quantità;
        }

        //Verso
        public void SetVerso(string verso)
        {
            this.verso = verso;
        }

        public string GetVerso()
        {
            return this.verso;
        }

        //statoMangiare
        public void SetStatoMangiare(mangiato statoMangiare)
        {

            this.statoMangiare = statoMangiare;
        }

        public mangiato GetStatoMangiare()
        {
            return this.statoMangiare;
        }

        public bool Mangiare()
        {
            return GetStatoMangiare() == mangiato.deveMangiare && GetQuantita() > 0;
        }
    }
}
