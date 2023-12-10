using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoVettori
{
    class Program
    {
        static void Main(string[] args)
        { //Alessandro Mizzon
            int dimensione = 10, metodo, elemento, posizione = -1;
            int estremo = 100, aumenta = 10;
            int[] vettoreMain;
            bool trovato = false;

             CreaVettore(out vettoreMain, dimensione, estremo);

            Visualizza(vettoreMain);

            Console.WriteLine("-------------------");

            CambiaValore(vettoreMain, 4, 200);

            Console.WriteLine("-------------------");

            VisualizzaValori(vettoreMain, dimensione);

            EspandiVettore(ref vettoreMain, aumenta, estremo);

            Visualizza(vettoreMain);
            Console.ReadLine();

            Console.WriteLine("Quale elemento si desidera cercare?");
            elemento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quale metodo si desidera usare?");
            metodo = Convert.ToInt32(Console.ReadLine());

            switch (metodo)
            {
                case (1):
                    TrovaElemento(vettoreMain, ref trovato, elemento, ref posizione);
                    if (trovato)
                    {
                        Console.WriteLine($"L'elemento è presente e si trova in posizione {posizione}");
                    }
                    else
                    {
                        Console.WriteLine("L'elemento non è presente nell'array");
                    }
                    break;

                case (2):
                    TrovaElemento2(vettoreMain, elemento, ref posizione); 
                    if (posizione != -1)
                    {
                        Console.WriteLine($"L'elemento è presente e si trova in posizione {posizione}");
                    }
                    else
                    {
                        Console.WriteLine("L'elemento non è presente nell'array");
                    }
                    break;

                case (3):
                    trovato = TrovaElemento3(vettoreMain, elemento, ref posizione);
                    if (trovato)
                    {
                        Console.WriteLine($"L'elemento è presente e si trova in posizione {posizione}");
                    }
                    else
                    {
                        Console.WriteLine("L'elemento non è presente nell'array");
                    }
                    break;

                case (4):
                    posizione = TrovaElemento4(vettoreMain, elemento);
                    if (posizione != -1)
                    {
                        Console.WriteLine($"L'elemento è presente e si trova in posizione {posizione}");
                    }
                    else
                    {
                        Console.WriteLine("L'elemento non è presente nell'array");
                    }
                    break;
            }

            Console.ReadLine(); 
        }
        static void CreaVettore(out int[] vettore, int dimensione, int estremo)
        {
            vettore = new int[dimensione];
            Random valori = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = valori.Next(1, estremo + 1);
            }
        }

        static void CambiaValore(int[] vettoreMod, int posizione, int valore)
        {
            vettoreMod[posizione] = valore;
        }

        static void Visualizza(int[] vettoreVisualizza) //se il vettore è completamente pieno usiamo .Length
        {
            for (int i = 0; i < vettoreVisualizza.Length; i++)
            {
                Console.Write(vettoreVisualizza[i] + " ");
            }
            Console.WriteLine();
        }
        static void VisualizzaValori(int[] vettoreVisualizza, int dim) //altrimenti usiamo dim
        {
            for (int i = 0; i < dim; i++)
            {
                Console.Write(vettoreVisualizza[i] + " ");
            }
            Console.WriteLine();
        }

        static void EspandiVettore(ref int[] vettoreVecchio, int aumentaDim, int estremo)
        {
            int[] vettoreEsp = new int[vettoreVecchio.Length + aumentaDim];

            for (int i = 0; i < vettoreVecchio.Length; i++)
            {
                vettoreEsp[i] = vettoreVecchio[i];
            }

            for (int i = vettoreVecchio.Length; i < vettoreVecchio.Length + aumentaDim; i++)
            {
                Random valori = new Random();
                vettoreEsp[i] = valori.Next(1, estremo + 1);
            }

            vettoreVecchio = vettoreEsp;
        }

        //cercare un elemento all'interno di un vettore ritornando la posizione se presente
        //in ogni caso il metodo deve segnalare se l'elemento è presente oppure no
        static void TrovaElemento(int[] vettoreDati, ref bool T, int elemento, ref int P)
        {
            for (int i = 0; i<vettoreDati.Length; i++)
            {
                if (vettoreDati[i] == elemento)
                {
                    T = true;
                    P = i; 
                }
            }
        }//ritorna trovato e posizione
        static void TrovaElemento2(int[] vettoreDati, int elemento, ref int P)
        {
            for (int i = 0; i < vettoreDati.Length; i++)
            {
                if (vettoreDati[i] == elemento)
                {
                    P = i;
                }
            }
        }//posizione valida? trovato?
        static bool TrovaElemento3(int[] vettoreDati, int elemento, ref int P)
        {
            bool T = false; 
            for (int i = 0; i < vettoreDati.Length; i++)
            {
                if (vettoreDati[i] == elemento)
                {
                    T = true; 
                    P = i;
                }
            }
            return T; 
        }//trovato ritornato come bool

        static int TrovaElemento4(int[] vettoreDati, int elemento)
        {
            int P = -1; 
            for (int i = 0; i < vettoreDati.Length; i++)
            {
                if (vettoreDati[i] == elemento)
                {
                    P = i;
                }
            }

            return P; 
        }//valore ritornato indica se l'elemento è presente o no (assieme alla posizione)
    }
}