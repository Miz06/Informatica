using System;

namespace Esercizio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double costoScatto = 0.5;
            const double canone = 11.5;
            double costoBolletta;
            int scattiContatore;
            int scattiBollettaPrecedente;

            Console.WriteLine("Inserire gli scatti della bolletta precedente: ");
            scattiBollettaPrecedente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero di scatti del contatore: ");
            scattiContatore = Convert.ToInt32(Console.ReadLine());

            costoBolletta = (scattiBollettaPrecedente - scattiContatore) * costoScatto;
            costoBolletta = costoBolletta + canone;

            Console.WriteLine($"Scatti bollletta da pagare: {scattiContatore - scattiBollettaPrecedente}");
            Console.WriteLine($"Canone fisso: {canone}");
            Console.WriteLine($"Scatti effettuati: {scattiContatore}");
            Console.WriteLine($"Costo bolletta (scatti +n canone): {costoBolletta}");
            Console.ReadLine();
        }
    }
}
