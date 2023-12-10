using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Program
    {//Alessandro Mizzon 4E
        static void Main(string[] args)
        {
            Reparto Medicina = new Reparto("Medicina", 3);
            int scelta, inseriti = 0;

            do
            {
                do
                {
                    Console.WriteLine("MENU:\n[1] Inserimento\n[2] Visualizzazione\n[3] Temperature");
                    scelta = Convert.ToInt32(Console.ReadLine());
                } while (scelta < 1 || scelta > 3);

                switch (scelta)
                {
                    case (1):
                        Inserimento(Medicina);
                        break;

                    case (2):
                        Visualizzazione(Medicina);
                        break;

                    case (3):
                        Temperatura(Medicina);
                        break;
                }

                Medicina.ModificaTemperatura("Federico", "Melon", 2);
                //Console.WriteLine(paziente.Anagrafica());
                //Termometro.CambiaTemperatura(+2);
                //paziente.SetTemperatura(Termometro.GetTemperatura());
                //Console.WriteLine(p1.Anagrafica());
                Console.ReadLine();

            } while (inseriti<3);
        }
        static void Inserimento(Reparto rep)
        {
            string nome, cognome, reparto;

            Console.WriteLine("Inserire nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Inserire cognome:");
            cognome = Console.ReadLine();

            Console.WriteLine("Inserire reparto:");
            reparto = Console.ReadLine();

            Paziente paziente = new Paziente(nome, cognome, reparto);

            rep.AggiungiPaziente(paziente);
        }

        static void Visualizzazione(Reparto rep)
        {
            rep.StampaPazienti();
        }

        static void Temperatura(Reparto Rep)
        {
            string nome, cognome;
            int temp;

            Console.WriteLine("Inserire nome di chi si vuole cambiare la temperatura:");
            nome = Console.ReadLine();

            Console.WriteLine("Inserire nome di chi si vuole cambiare la temperatura:");
            cognome = Console.ReadLine();

            Console.WriteLine("Inserire di quanto si vuole cambiare la temperatura:");
            temp = Convert.ToInt32(Console.ReadLine());

            Rep.ModificaTemperatura(nome, cognome, temp);
        }
        //PER DOMANI
        /*
         cambiare la temperatura dei pazienti*/
    }
}