using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Età
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int età; 
            Console.WriteLine("Inserire un codice fiscale");
            string CF = Console.ReadLine();

            string dataNascitaString = CF.Substring(6, 6); 

            età = Età(Convert.ToDateTime(dataNascitaString)); 

            Console.WriteLine(età); 
            Console.ReadLine();

        }

        static int Età(DateTime dataNascita)
        {
            int e;
            DateTime oggi = DateTime.Today;

            e = oggi.Year - dataNascita.Year; 

            return e; 
        }
    }
}
