using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z1
    {

        public static void Izvedi()
        {


            /*
             Console.WriteLine("Upišite jedan broj: ");
             int broj1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Upišite drugi broj: ");      
             int broj2 = int.Parse(Console.ReadLine());


             Console.WriteLine("Uneli ste broj: " + broj1 + " i " + broj2);

            Jednostavnije napravljen zadatak

             */


            int broj1, broj2;

           

            while (true) 
            {
                Console.WriteLine("Unesite prvi broj: ");
                string unos1 = Console.ReadLine();

                if (int.TryParse(unos1, out broj1))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("neispravan unos! Molim unesite cijeli broj.");
                }
                   




            }

            while (true)
            {
                Console.WriteLine("unesite drugi broj");
                string unos2 = Console.ReadLine();

                if(int.TryParse(unos2, out broj2))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Neispravan unos! Molim unesite cijeli broj");
                }

            }

            Console.WriteLine("Uneli ste brojeve: "+ broj1 + " i " + broj2);

            // malo naprednije napravljen zadatak 
        }

    }
}
