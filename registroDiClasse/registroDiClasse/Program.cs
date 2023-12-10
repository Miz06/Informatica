using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laScuolaElementare
{
    internal class Program
    {
        static void Main(string[] args)  //Alessandro Mizzon 
        {
            int N, sezReg, spazio = 0, e;
            string nome, cercaNome;
            bool var1, var2;

            Console.WriteLine("Inserire il numero di studenti della classe:");
            N = Convert.ToInt32(Console.ReadLine());

            string[] classe = new string[N];

            for (int i = 0; i < N; i++)
            {
                classe[i] = "";
            }

            do
            {
                Console.WriteLine("===Registro di classe===");
                Console.WriteLine("[1] inserimento");
                Console.WriteLine("[2] presenti");
                Console.WriteLine("[3] ricerca");
                Console.WriteLine("[4] ricerca posizione alunno/registro");
                Console.WriteLine("[5] esci");

                do
                {
                    Console.WriteLine("Inserire il numero corrispondente alla sezione di registro a cui si vuole andare:");
                    sezReg = Convert.ToInt32(Console.ReadLine());
                } while (sezReg < 1 || sezReg > 5);


                Console.Clear();

                switch (sezReg)
                {
                    case (1):
                        if (spazio < N)
                        {
                            Console.WriteLine("Inserire il nome del bambino:");
                            nome = Console.ReadLine();
                            e = 0;
                            var1 = true;
                            do
                            {
                                if (nome == classe[e])
                                {
                                    Console.WriteLine($"Errore. Alunno già presente alla posizione numero {e + 1} del registro.");
                                    var1 = false;
                                }
                                else
                                {
                                    e++;
                                }
                            } while (e < N && var1 == true);

                            if (var1 == true)
                            {
                                classe[spazio] = nome;
                                spazio++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non c'è più posto nella classe.");
                        }
                        Console.WriteLine("Premere invio per tornare al menù principale");
                        break;

                    case (2):
                        Console.WriteLine("GLi studenti della classe sono:");
                        for (int i = 0; i < spazio; i++)
                        {
                            Console.WriteLine($"{i + 1}) {classe[i]}");
                        }
                        Console.WriteLine("Premere invio per tornare al menù principale");
                        break;

                    case (3):
                        Console.WriteLine("Funzionalità non ancora implementata.");
                        Console.WriteLine("Premere invio per tornare al menù principale");
                        break;

                    case (4):
                        Console.WriteLine("Inserire il nome dell'alunno di cui si vuole trovare la posizione del registro:");
                        cercaNome = Console.ReadLine();
                        e = 0;
                        var2 = true;
                        do
                        {
                            if (cercaNome == classe[e])
                            {
                                Console.WriteLine($"{cercaNome} si trova nella posizione {e + 1} del registro.");
                                var2 = false;
                            }
                            else if (e == N - 1 && var2 == true)
                            {
                                Console.WriteLine("Errore. Alunno non presente nel registro.");
                            }
                            e++;
                        } while (e < N && var2 == true);
                        Console.WriteLine("Premere invio per tornare al menù principale");
                        break;

                    case (5):
                        Console.WriteLine("Programma terminato.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (sezReg != 5);
        }
    }
}