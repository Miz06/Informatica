using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioneInf
{
    struct ip
    {
        public string decimale;
        public string esadecimale;
        public string binario;

        public override string ToString()
        {
            return string.Format($"ip: {decimale}, b: {binario}, h: {esadecimale}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {//Alessandro Mizzon 4E
            ip indirizzo;

            Console.WriteLine("Inserire un indirizzo:");
            indirizzo.decimale = Console.ReadLine();

            indirizzo.binario = "";
            indirizzo.esadecimale = "";

            ConvertToBin(ref indirizzo);
            ConvertToHex(ref indirizzo); 

            Console.WriteLine(indirizzo.ToString());

            Console.ReadLine();
        }

        static void ConvertToBin(ref ip indirizzo)
        {

            //CONVERSIONE BINARIA
            int num;

            string[] arr = indirizzo.decimale.Split('.');

            for (int i = 3; i > -1; i--)
            {
                num = Convert.ToInt32(arr[i]);
                for (int j = 0; j < 8; j++)
                {
                    indirizzo.binario = num % 2 + indirizzo.binario;
                    num = num / 2;
                }

                if (i != 0)
                {
                    indirizzo.binario = '.' + indirizzo.binario;
                }
            }
        }

        static void ConvertToHex(ref ip indirizzo)
        {
            int num;

            string[] arr = indirizzo.decimale.Split('.');

            for (int i = 3; i > -1; i--)
            {
                num = Convert.ToInt32(arr[i]);
                for (int j = 0; j < 2; j++)
                {
                    if (num % 16 <10)
                    {
                        indirizzo.esadecimale = num % 16 + indirizzo.esadecimale;
                    }
                    else
                    {
                        indirizzo.esadecimale = Convert.ToChar((num % 16)+55) + indirizzo.esadecimale;
                    }
                    num = num / 16;
                }

                if (i != 0)
                {
                    indirizzo.esadecimale = '.' + indirizzo.esadecimale;
                }
            }
        }

    }
}
