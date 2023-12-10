using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6_pg_98
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldoContoCorrente;
            const double valoreLire = 1936.27; 
            const double valoreDollari = 1.04;

            Console.Write("Inserire il saldo del conto corrente: ");
            saldoContoCorrente = Convert.ToDouble(Console.ReadLine());

            Console.Clear(); 
            Console.WriteLine($"Un euro equivale a: {valoreLire} lire e {valoreDollari} dollari.");
            Console.WriteLine($"Il saldo del conto corrente in lire è equivalente a: {saldoContoCorrente*valoreLire}");
            Console.WriteLine($"Il saldo del conto corrente in dollari è equivalente a: {saldoContoCorrente*valoreDollari}");


        }
    }
}
