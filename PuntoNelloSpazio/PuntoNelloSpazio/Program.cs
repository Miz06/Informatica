using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Program
    {
        public struct Punto
        {
            public int x;
            public int y;
        }

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

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Desideri passare:\n[1] Un punto\n[2] Coordinate [3] Le coordinate di default");
                    int scelta2 = Convert.ToInt32(Console.ReadLine());

                    switch (scelta2)
                    {
                        case 1:
                            Punto point;

                            Console.Write("X: ");
                            point.x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Y: ");
                            point.y = Convert.ToInt32(Console.ReadLine());

                            Rettangolo r1 = new Rettangolo(point);
                            break;

                        case 2:
                            Console.Write("X: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Y: ");
                            int y = Convert.ToInt32(Console.ReadLine());

                            Rettangolo r2 = new Rettangolo(x, y);
                            break;

                        case 3:
                            PosizioneAngolo p = new PosizioneAngolo();
                            Rettangolo r3 = new Rettangolo(p.GetWidthPoint, p.GetHeightPoint);
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
