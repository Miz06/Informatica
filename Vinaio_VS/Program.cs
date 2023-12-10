using System;
using System.Threading;
namespace Vinaio_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            const double litriBottiglia = 1.5;
            const int costoLitro = 2;
            const int costoTrasporto = 3;
            bool var1 = true, var2 = true, var3 = true;
            char risposta, risposta2;
            int bottiglioniRichiesti, bottiglioniTotaliRichiesti = 0, x = 0, y = 0, scontriniEmessi = 0, costoTotaleTrasporto = 0;
            double litriRichiesti, litriTotaliRichiesti = 0, costoBottiglie = 0, costoTotaleBottiglie = 0, costoBottiglieSenzaSconto, importo = 0, importoTotale = 0, sconto, scontoTotale = 0;

            do
            {
                do
                {
                    Console.WriteLine("Quanti bottiglioni di Barbera si desiderano?");
                    bottiglioniRichiesti = Convert.ToInt32(Console.ReadLine());

                    litriRichiesti = bottiglioniRichiesti * litriBottiglia;
                    costoBottiglieSenzaSconto = (litriRichiesti * costoLitro);
                    sconto = (costoBottiglieSenzaSconto / 100) * 10;

                    if (litriRichiesti > 45)
                    {
                        costoBottiglie = costoBottiglieSenzaSconto - sconto;
                        var1 = false;
                    }
                    else
                    {
                        if (litriRichiesti <= 45 && litriRichiesti > 0)
                        {
                            costoBottiglie = costoBottiglieSenzaSconto;
                            var1 = false;
                        }
                        else
                        {
                            Console.WriteLine("Risposta non valida, rispondere nuovamente: ");
                        }

                    }
                } while (var1 == true);

                do
                {
                    Console.WriteLine("Si desidera la spedizione a domicilio?");
                    risposta = Convert.ToChar(Console.ReadLine());

                    if (risposta == 'S')
                    {
                        importo = costoBottiglie + costoTrasporto;
                        var2 = false;
                    }
                    else
                    {
                        if (risposta == 'N')
                        {
                            importo = costoBottiglie;
                            var2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Risposta non valida, rispondere nuovamente: ");
                        }

                    }
                } while (var2 == true);

                scontriniEmessi = scontriniEmessi + 1;
                bottiglioniTotaliRichiesti = bottiglioniTotaliRichiesti + bottiglioniRichiesti;
                litriTotaliRichiesti = litriTotaliRichiesti + litriRichiesti;
                scontoTotale = scontoTotale + sconto;
                costoTotaleBottiglie = costoTotaleBottiglie + costoBottiglie;
                costoTotaleTrasporto = costoTotaleTrasporto + costoTrasporto;
                importoTotale = importoTotale + importo;

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(x, y);
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("(==========       Tana dei Goti        ==========)");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine($"(Barbera:    n° bottiglioni:  {bottiglioniRichiesti}, n° litri:  {litriRichiesti} )");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine($"(Sconto 10%:                            {sconto}$Euro )");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("(================================================)");
                Console.SetCursorPosition(x, y + 5);
                Console.WriteLine($"(Totale Parziale:                        {costoBottiglie}$Euro )");
                Console.SetCursorPosition(x, y + 6);
                Console.WriteLine($"(Spese di Trasporto:                      {costoTrasporto}$Euro )");
                Console.SetCursorPosition(x, y + 7);
                Console.WriteLine("(================================================)");
                Console.SetCursorPosition(x, y + 8);
                Console.WriteLine($"(Importo Totale                          {importo}$Euro )");
                Console.SetCursorPosition(x, y + 9);
                Console.WriteLine($"(                                              {scontriniEmessi} )");
                Console.SetCursorPosition(x, y + 10);
                Console.WriteLine("(==========         Arrivederci        ==========)");
                Console.ReadLine();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                do
                {
                    Console.WriteLine("Siamo a fine giornata?");
                    risposta2 = Convert.ToChar(Console.ReadLine());

                    if (risposta2 == 'S')
                    {
                        var3 = false;
                    }
                    else
                    {
                        if (risposta2 == 'N')
                        {
                            importoTotale = costoBottiglie;
                            var3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Risposta non valida, rispondere nuovamente: ");
                        }

                    }
                } while (var3 == true);

            }
            while (risposta2 == 'N');

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("(==========       Tana dei Goti        ==========)");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("(==========       Chiusura Cassa       ==========)");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine($"(Barbera Totale: n°bottiglioni: {bottiglioniTotaliRichiesti}, n°litri: {litriTotaliRichiesti} )");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("(================================================)");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine($"(Totale Sconto:                         {scontoTotale}$Euro )");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine($"(Totale Incasso:                         {importoTotale}$Euro )");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine($"(Totale Spese di trasporto:               {costoTotaleTrasporto}$Euro )");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine($"(n° scontrini emessi:                          {scontriniEmessi} )");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("(==========         Arrivederci        ==========)");

            Console.ReadLine();
        }
    }
}

