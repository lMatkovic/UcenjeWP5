using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {

        // Program od korisnika traži unos dva cijela broja
        // Program ispisuje manji



        public static void Izvedi()
        {
            Console.WriteLine("Unesite prvi cijeli broj:");
            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi cijeli broj:");
            int broj2 = int.Parse(Console.ReadLine());

            if (broj1 < broj2)
            {
                Console.WriteLine("Manji broj je: " + broj1);
            }
            else
            {
                Console.WriteLine("Manji broj je: " + broj2);
            }
        }

        // isiti zadatak ali za tri unesena broja ispisati najmanji




    }
}
