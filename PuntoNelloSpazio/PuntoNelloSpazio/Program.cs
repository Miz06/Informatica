using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosizioneAngolo position;
            string[] options = new string[] { "Rettangolo", "Quadrato", "Parallelogramma" };

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {options[i]}");
            }

            Console.WriteLine("^^^^^^^^^^^^^^^^");
            Console.Write("Scelta: ");
            int scelta = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("----------------");

            Console.WriteLine("Desideri passare:\n[1] Un punto\n[2] Le coordinate di default");
            int scelta2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("^^^^^^^^^^^^^^^^");

            if (scelta2 == 1)
            {
                Console.Write("Inserire x: ");
                int Setx = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserire y: ");
                int Sety = Convert.ToInt32(Console.ReadLine());

                position = new PosizioneAngolo(Setx, Sety);
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Il tuo punto è:\nx => {position.GetXPoint}\ny => {position.GetYPoint}");
                Console.WriteLine("----------------------------");
            }
            else
            {
                position = new PosizioneAngolo();
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Il tuo punto è:\nx => {position.GetXPoint}\ny => {position.GetYPoint}");
                Console.WriteLine("----------------------------");
            }

            switch (scelta)
            {
                case 1:
                    Rettangolo rettangolo = new Rettangolo(position, 20, 20);

                    Console.WriteLine($"Il tuo rettangololo ha:\nArea => {rettangolo.Area()}\nPerimetro => {rettangolo.Perimetro()}");
                    Console.WriteLine("----------------------------");
                    break;

                case 2:
                    Quadrato quadrato = new Quadrato(position, 20, 20);

                    Console.WriteLine($"Il tuo quadrato ha:\nArea => {quadrato.Area()}\nPerimetro => {quadrato.Perimetro()}");
                    Console.WriteLine("----------------------------");
                    break;

                case 3:
                    Parallelogramma parallelogramma = new Parallelogramma(position, 20, 20, 2);

                    Console.WriteLine($"Il tuo parallelogramma ha:\nArea => {parallelogramma.Area()}\nPerimetro => {parallelogramma.Perimetro()}\nVolume => {parallelogramma.Volume()}");
                    Console.WriteLine("----------------------------");
                    break;
            }
            Console.ReadLine();
        }
    }
}
