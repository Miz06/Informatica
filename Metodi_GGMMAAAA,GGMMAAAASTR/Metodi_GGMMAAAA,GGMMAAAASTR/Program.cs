using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi_GGMMAAAA_GGMMAAAASTR
{
    internal class Program
    {
        struct Data
        {
            public string GG;
            public string MM;
            public string AAAA;
        }

        static void Main(string[] args)
        {//Alessandro Mizzon
            Data data;
            Data data2; 
            int numero;
            string stringa;

            Console.WriteLine("Inserire un valore che rappresenti una data");
            numero = Convert.ToInt32(Console.ReadLine()); 
            stringa = Convert.ToString(numero);

            DataI(stringa, out data);
            Console.Write($"{Convert.ToInt32(data.GG)} ");
            Console.Write($"{Convert.ToInt32(data.MM)} ");
            Console.Write($"{Convert.ToInt32(data.AAAA)}");

            Console.WriteLine("");
            Console.WriteLine("*******************");
            Console.WriteLine("");

            Console.WriteLine("Inserire una stringa che rappresenti una data");
            stringa = Console.ReadLine(); 

            DataS(stringa, out data2);
            Console.Write($"{Convert.ToInt32(data2.GG)} ");
            Console.Write($"{Convert.ToInt32(data2.MM)} ");
            Console.Write($"{Convert.ToInt32(data2.AAAA)}");

            Console.ReadLine(); 
        }

        static void DataI(string stringa, out Data data)
        {
            data = new Data();
            for (int i = 0; i < 8; i++)
            {
                if (i < 2)
                {
                    data.GG += stringa[i];
                }
                if (i > 1 && i < 4)
                {
                    data.MM += stringa[i];
                }
                if (i > 3)
                {
                    data.AAAA += stringa[i];
                }
            }
        }

        static void DataS(string stringa, out Data data2)
        {
            data2 = new Data();
            for (int i = 0; i < 8; i++)
            {
                if (i < 2)
                {
                    data2.GG += stringa[i];
                }
                if (i > 1 && i < 4)
                {
                    data2.MM += stringa[i];
                }
                if (i > 3)
                {
                    data2.AAAA += stringa[i];
                }
            } 
        }
    }
}
