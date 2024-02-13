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
            string[] options = new string[] { "rettangolo", "Quadrato", "Parallelogramma" };

            for (int i = 0; i<options.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {options[i]}");
            }

            Console.WriteLine("^^^^^^^^^^^^^^^^");
            Console.Write("Scelta: ");
            int scelta = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Desideri passare:\n[1] Un punto\n[2] Coordinate [3] Le coordinate di default");
            int scelta2 = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    switch (scelta2)
                    {
                        case 1:
                            Console.Write("X: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Y: ");
                            int y = Convert.ToInt32(Console.ReadLine());

                            Rettangolo r = new Rettangolo(x, y);
                            break;

                        case 2:
                            Rettangolo r = new Rettangolo();
                            break;

                        case 3:
                            PosizioneAngolo p = new PosizioneAngolo();

                            Rettangolo r = new Rettangolo(p);
                            break;
                    }
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }

            Console.ReadLine();
        }
    }
}
