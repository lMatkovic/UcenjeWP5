using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {

        // Program od korisnika unosi cijeli broj (osigurava se unos)
        // Koristeći while petlju program ispisuje 
        // zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
        // unos 10 ispis 30
        // unos 12 ispis 42




        // Program od korisnika unosi 10 brojeva
        // Program ispisuje prvo zbroj svih unesenih brojeva
        // i nakon toga ispisuje unesene brojeve jedno ispod drugog


        public static void Izvedi()
        {
            int broj;

            while(true)
            {
                Console.WriteLine("Unesi cijeli broj: ");
                if (int.TryParse(Console.ReadLine(), out broj))
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Neispravan unos. Pokušaj ponovno");
                }
            }
            
            int zbroj = 0;
            int i = 1;

            while (i <= broj) 
            {
                if (i% 2 == 0) 
                {
                    zbroj += 1;
                }
                i++;
            }



            Console.WriteLine("Zbroj svih parnih brojeva od 1 do " + broj + " je; " + zbroj);





        }

    }
}
