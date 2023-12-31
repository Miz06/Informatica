﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Reparto
    {
        string _nomeReparto;
        public List<Paziente> Pazienti;
        Termometro termometro;
        public Reparto(string nomeReparto)
        {
            string _nomeReparto;
            Pazienti = new List<Paziente>();
            termometro = new Termometro();
        }
        public Reparto(string nomeReparto, int nPazienti)
        {
            _nomeReparto = nomeReparto;
            Pazienti = new List<Paziente>(nPazienti);
            termometro = new Termometro();
        }
        public void AggiungiPaziente(Paziente p)
        {
            Pazienti.Add(p);
        }
        public void StampaPazienti()
        {
            foreach (Paziente p in Pazienti)
            {
                Console.WriteLine(p.Anagrafica());
            }
        }
        public void CercaPaziente(List<Paziente> rep, string nome, string cognome)
        {
            for (int i = 0; i < rep.Count; i++)
            {
                if (nome == rep[i]._nome && cognome == rep[i]._cognome)
                {
                    rep[i]._temperatura += 2;
                }
            }
        }
    }
}