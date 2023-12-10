using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruttivendolo
{
    class Program
    {
        enum tipoFrutta
        {
            albicocca, pera, mela, uva
        }
        struct frutta
        {
            public tipoFrutta frutto;
            public double prezzo;
        }

        static void Main(string[] args)
        {
            frutta[] fruttivendolo = new frutta[4];
            int scelta;

            Console.WriteLine("Che frutto vuoi inserire?");
            Console.WriteLine("[1] albicocca");
            Console.WriteLine("[2] pera");
            Console.WriteLine("[3] mela");
            Console.WriteLine("[4] uva");
            scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    fruttivendolo[0].frutto = tipoFrutta.albicocca;

                    break;
                case 2:
                    fruttivendolo[0].frutto = tipoFrutta.pera;
                    break;
                case 3:
                    fruttivendolo[0].frutto = tipoFrutta.mela;
                    break;
                case 4:
                    fruttivendolo[0].frutto = tipoFrutta.uva;
                    break;
            }
            Console.WriteLine("Inserisci il prezzo al kg");
            fruttivendolo[0].prezzo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Il frutto: {fruttivendolo[0].frutto.ToString()} costa: {fruttivendolo[0].prezzo}");

            Console.ReadLine();
        }
    }
}