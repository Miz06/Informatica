using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvDecToBin
{
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon 
            string indirizzo, str3 = "";
            int num, zeri;

            Console.WriteLine("Inserire un indirizzo IP:");
            indirizzo = Console.ReadLine();

            string[] arr = indirizzo.Split('.');

            for (int i = 0; i<4; i++)
            {
                num = Convert.ToInt32(arr[i]); 

                do
                {
                   str3 = num % 2 + str3;
                   num = num / 2;
                } while (num >= 1);

                if (str3.Length <8)
                {
                    zeri = 8 - str3.Length; 

                    for (int j = 0; j<zeri; j++)
                    {
                        str3 = 0 + str3;
                    }
                }

                if (i!=3)
                {
                    str3 = "." + str3;
                }
            }

            Console.WriteLine(str3); 

            Console.ReadLine();
        }
    }
}
