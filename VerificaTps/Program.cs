using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VerificaTps
{
//Realizzare un programma in Console che contenga tre thread concorrenti. 
    
//Il primo thread deve
//definire 3 variabili Sub1(valore assegnato a vosto piacere), Sub2(valore assegnato a vostro
//piacere), Sottrazione e dopo aver realizzato la sottrazione tra Sub1 e Sub2 e aver caricato nella
//variabile Sottrazione il risultato preveda la stampa di tale valore per 5 volte a video.



//Il secondo thread deve 
//contenere un ciclo che si ripete 10 volte e che prevede di stampare a video la
//tabellina del numero 37 (ovvero il risultato di 37*1, 37*2, 37*3 ecc).



//Il terzo thread deve prevedere la stampa a video del tuo cognome per 20 volte.



//I tre thread dovranno essere avviati contemporaneamente e si dovrà prevedere che il terzo thread
//termini sempre prima degli altri due.
//Il progetto dovrà essere caricato su una repository GitHub e dovrà contenere 3 COMMIT:
//il primo alla creazione del primo thread, il secondo alla creazione del secondo thread, il terzo al termine del progetto.

    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Sottrazione));           
            Thread t2 = new Thread(new ThreadStart(Tabellina));
            Thread t3 = new Thread(new ThreadStart(Cognome));
            t3.Start();
            Thread.Sleep(TimeSpan.FromMilliseconds(600));
            t1.Start();
           // Thread.Sleep(TimeSpan.FromMilliseconds(600));
            t2.Start();
            Console.ReadKey();
        }
        public static void Sottrazione()
        {
            int Sub1 = 7;
            int Sub2 = 5;
            int sottrazione=Sub1-Sub2;
            Console.WriteLine("sottrazione tra " + Sub1 +" - "+ Sub2 + " = " + sottrazione);
            Console.WriteLine("sottrazione tra " + Sub1 + " - " + Sub2 + " = " + sottrazione);
            Console.WriteLine("sottrazione tra " + Sub1 + " - " + Sub2 + " = " + sottrazione);
            Console.WriteLine("sottrazione tra " + Sub1 + " - " + Sub2 + " = " + sottrazione);
            Console.WriteLine("sottrazione tra " + Sub1 + " - " + Sub2 + " = " + sottrazione);


        }
        public static void Tabellina()
        {
            int tabellina;
            int numero = 37;
           
         
                for (int y = 0; y < 11; y++)
                {
                    tabellina = numero * y;
                    Console.WriteLine(numero + " * "+ y + " = " + tabellina );
                }
            
        }
        public static void Cognome()
        {
            for (int t = 0; t < 20; t++)
            {              
                Console.WriteLine(t + "   Zani");
            }
        }
    }
}
