using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Volume_cilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int areacerchio;
            int altezza;
            int volume;

            Console.WriteLine("Inserire l'area del cerchio alla base ");
            areacerchio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire l'altezza ");
            altezza = Convert.ToInt32(Console.ReadLine()); 

            volume = areacerchio * altezza;

            Console.Write("L'area del cerchio è: ");
            Console.WriteLine(areacerchio);

            Console.Write("L'altezza è: ");
            Console.WriteLine(altezza);

            Console.Write("Il volume del cilindro è: ");
            Console.WriteLine(volume); 
        }
    }
}
