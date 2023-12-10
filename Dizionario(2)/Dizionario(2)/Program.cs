using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizionario_2_ //Alessandro Mizzon 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int p = 0, e;
            char car;
            bool uguale;
            string parola = "";
            string[] dizionario = new string[4];

            for (int i = 0; i < 4; i++)
            {
                dizionario[i] = ""; 
            }
            
            Console.WriteLine("Inserire le parole da inserire nel dizionario:");

            do
            {
                car = Convert.ToChar(Console.Read());

                if (car != 13 && car != ' ') //Se il carattere inserito è diverso dallo spazio vuoto e non è stato premuto invio, allora alla variabile "parola" verrà sommato il suo valore stesso più il carattere inserito  
                {
                    parola = parola + car;
                }
                else if (p < 4) //Se le parole inserite sono minori di 4 (parole massime contenute dal dizionario) viene fatto il controllo della parola e l'eventuale assegnazione alla sezione dell' array
                {
                    e = 0;
                    uguale = false; 

                    do
                    {
                        if (parola == dizionario[e]) //Se la parola è uguale ad una contenuta nell'array alla variabile "uguale" viene assegnato il valore true 
                        {
                            uguale = true;
                            Console.WriteLine($"La parola {parola} è già presente all'interno del dizionario"); //Messaggio di errore
                        }
                        else
                        {
                            dizionario[p] = parola; // Se la parola è diversa da quelle contenute nell'array viene assegnata alla sezione dell'array, con indice uguale alle parole che abbiamo inserito, il valore della variabile "parola"
                        }
                        e++;
                    } while (e < p && uguale == false); 

                    if (uguale != true) //Se la variabile "uguale" è diversa da true, la variabile "p" che conta le parole inserite viene incrementata di 1
                    {
                        p++;
                    }
                    parola = "";
                }
            } while (car != 13); //Si continua il ciclo finchè non viene premuto invio 

            Console.WriteLine("DIZIONARIO:");
            
            for (int i = 0; i < p; i++)
            {
                if (dizionario[i] != "") //Vengono stampate solamente le sezioni dell'array che hanno un valore diverso da ""; Se la sezione dell'array è ancora uguale a "" ciò vuol dire che ad essa non è stata associata una parola in quanto già presente nel dizionario
                {
                    Console.WriteLine(dizionario[i]);
                }
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
