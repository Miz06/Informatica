using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dato = false;
            int dato1;

            do
            {
                Console.WriteLine("Inserire un dato");
                int.TryParse(Console.ReadLine(), out dato1);
            } while (dato1<=0);



            Console.ReadLine(); 
        }
    }
}
