using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequenzaCaratteri
{
    internal class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon 
            char n;
            char[] numeri = new char[10];
            int[] frequenza = new int[10];

            for (int i = 0; i<10; i++)
            {
                numeri[i] = Convert.ToChar(48+i); 
            }

            Console.WriteLine("Inserire una sequenza di numeri:"); 

            do
            {
                n = Convert.ToChar(Console.Read());

                for (int i = 0; i < 10; i++)
                {
                    if (n == numeri[i])
                    {
                        frequenza[i]++; 
                    }
                }
            } while (n != 13);

            for (int i = 0; i < 10; i++)
            {
                if (frequenza[i] != 0)
                {
                    Console.WriteLine($"{numeri[i]}:{frequenza[i]}"); 
                }
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
