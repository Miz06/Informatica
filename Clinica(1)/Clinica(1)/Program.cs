using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reparto Medicina = new Reparto("Medicina", 5);

            Paziente p1 = new Paziente("Federico", "Melon", "Medicina");
            Paziente p2 = new Paziente("Emiliano", "Melon", "Medicina");
            Paziente p3 = new Paziente("Emiliano", "Spiller", "Medicina");
            Paziente p4 = new Paziente("Esposito", "Lorenzo", "Medicina");
            Medicina.AggiungiPaziente(p1);
            Medicina.AggiungiPaziente(p2);
            Medicina.AggiungiPaziente(p3);
            Medicina.AggiungiPaziente(p4);

            List<Paziente> pazienti = Medicina.Pazienti;
            Medicina.StampaPazienti();
            //Console.WriteLine(paziente.Anagrafica());
            //Termometro.CambiaTemperatura(+2);
            //paziente.SetTemperatura(Termometro.GetTemperatura());
            //Console.WriteLine(p1.Anagrafica());

            Console.WriteLine("-----------------------");
            Console.WriteLine("Di chi si vuole cambiare la temperatura?(nome)");
            string cercaNome = Console.ReadLine();
            Console.WriteLine("Di chi si vuole cambiare la temperatura?(cognome)");
            string cercaCognome = Console.ReadLine();

            Medicina.CercaPaziente(pazienti, cercaNome, cercaCognome);
            Medicina.StampaPazienti();

            Console.ReadLine();
        }
        static void Inserimento(List<Paziente> Pazienti)
        {
            Paziente paziente = new Paziente("Federico", "Melon", "Medicina");
        }
        //PER DOMANI
        /*
         cambiare la temperatura dei pazienti*/
    }
}