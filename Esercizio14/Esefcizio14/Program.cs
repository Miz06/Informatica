using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esefcizio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pizzemargherita;
            int pizzeprosciutto;
            double farinanecessaria;
            double pomodoronecessario;
            double prosciuttonecessario;
            const double farinapizzamargherita = 100;
            const double pomodoropizzamargherita = 150;
            const double farinapizzaprosciutto = 100;
            const double pomodoropizzaprosciutto = 100;
            const double prosciuttopizzaprosciutto = 50;

            Console.WriteLine("Inserire il numero di pizze margherita che si desiderano: ");
            pizzemargherita = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserire il numero di pizze al prosciutto che si desiderano: ");
            pizzeprosciutto = Convert.ToInt32(Console.ReadLine());

            farinanecessaria = (farinapizzamargherita * pizzemargherita) + (farinapizzaprosciutto * pizzeprosciutto);
            pomodoronecessario = (pomodoropizzamargherita * pizzemargherita) + (pomodoropizzaprosciutto * pizzeprosciutto);
            prosciuttonecessario = (prosciuttopizzaprosciutto * pizzeprosciutto);

            Console.WriteLine($"Il fabbisogno di ogni ingrediente necessario per produrre le {pizzemargherita} pizze margherita e le {pizzeprosciutto} pizze al prosciutto richieste è: ");
            Console.WriteLine($"- {farinanecessaria} grammi di farina;");
            Console.WriteLine($"- {pomodoronecessario} grammi di pomodoro;");
            Console.WriteLine($"- {prosciuttonecessario} grammi di prosciutto;");
            Console.ReadLine();
        }
    }
}
