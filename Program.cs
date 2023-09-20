using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kraj,vrijednost1,vrijednost2,sljRez;

            vrijednost1 = sljRez = 0;
            vrijednost2 = 1;

            Console.Write("Upisi kraj Fibonaccijevog niza: ");
            kraj = Convert.ToInt32(Console.ReadLine()); // upisivanje broja n

            Console.WriteLine("");
            Console.WriteLine("Fibonaccijev niz: ");
            for(int i = 1; i <= kraj; ++i)
            {
                if(i ==1)
                {
                    Console.Write(vrijednost1 + " "); // samo za prvu nulu
                }
                if (i == 2)
                {
                    Console.Write(vrijednost2 + " "); // samo za prvu jedinicu
                }

                sljRez = vrijednost1 + vrijednost2; // zbroj prethodne 2 vrijednosti u novu varijablu
                vrijednost1 = vrijednost2; // odbacivanje najmanjeg broja x (za sljedeći loop)
                vrijednost2 = sljRez; // dodavanje novog broja y na mjesto većeg (za sljedeći loop)
                // s prethodne 2 linije svaki krug dobivamo nova 2 najveća broja koja ćemo zbrojit u novom krugu

                Console.Write(sljRez + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Broj koj je " + kraj + ". po redu u Fibonaccijevom nizu jest: " + sljRez + ".");// ispis rezultata 
                

            Console.ReadKey();

        }
    }
}
