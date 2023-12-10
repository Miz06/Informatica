using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrendiParola //Alessandro Mizzon 
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int car;

            Console.WriteLine("Inserire una frase:");
            do
            {
                car = Console.Read();
                if (car == ' ')
                {
                    Console.WriteLine(); 
                }
                else
                {
                    Console.Write(Convert.ToChar(car)); 
                }
            } while (car != 13);

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
