using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDREA_BARBIN_3_E_CONVERSIONE_DA_DECIMALE_A_BINARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dato numero in base 10 nel range 0 - 255, convertirlo in base 2.
            int numero, valoreAusiliario, x, nCifre = 0, posizione = 0; //La variabile posizione indica la posizione che i valori assumono nell'array.
            x = Console.WindowWidth;
            int[] numBin;
            numBin = new int[256];

            //FASE DI INPUT CON CONTROLLO DEI DATI
            do
            {
                Console.WriteLine("Inserire numero in base 10 nel range 0-255, convertirlo in base 2.");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0 || numero > 255)
                {
                    Console.WriteLine("Out of range.");
                    Console.ReadLine();
                }
            } while (numero < 0 || numero > 255);
            Console.Write("Il corrispondete valore in base 2 è: ");

            //FASE DI ELABORAZIONE DATI
            do
            {

                valoreAusiliario = numero;

                //DIVIDO IL NUMERO PER 2 FINCHE' E' MAGGIORE DI 0
                numero = numero / 2;

                //TROVO IL RESTO DELLA DIVISIONE, MENTRE IL QUOZIENTE VERRA' ULTERIORMENTE DIVISO PER 2 FINO AL TERMINE DEL CICLO.
                valoreAusiliario = valoreAusiliario % 2;
                nCifre++;

                numBin[posizione] = valoreAusiliario; //Inserisco il valore della variabile valoreAusiliario in un array in modo tale da potere riportare in output successivamente le cifre nell'ordine corretto.
                posizione++;

            } while (numero > 0);

            //FASE DI OUTPUT
            do
            {
                nCifre++;
                Console.Write("0");
            } while (nCifre < 8);
            posizione = posizione - 1;
            do
            {
                Console.Write(numBin[posizione]);
                posizione--;
            } while (posizione >= 0);
            Console.Write(".");
            Console.ReadLine();
        }
    }
}
