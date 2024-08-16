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
            Console.WriteLine("Unesite prvi cijeli broj: ");
            string unos = Console.ReadLine();

            Console.WriteLine("Unesite drugi cijeli broj: ");
            string unos2 = Console.ReadLine();

            if (int.TryParse(unos, out int broj1) && int.TryParse(unos2, out int broj2))
            {

                if (broj1 < broj2)
                {
                    Console.WriteLine("Manji broj je: " + broj1);
                }
                else if (broj2 < broj1)
                {
                    Console.WriteLine("Manji broj je: " + broj2);
                }
                else
                {
                    Console.WriteLine("Brojevi su jednaki");
                }

            }
            else 
            {
                Console.WriteLine("Greška: Unesite ispravne cijele brojeve");
            }










        }

        // isiti zadatak ali za tri unesena broja ispisati najmanji




    }
}
