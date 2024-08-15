using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {

        // Program od korisnika traži unos cijelog broja
        // Program ispisuje da li je uneseni broj paran ili ne



        public static void Izvedi()
        {
            Console.WriteLine("Unesite cijeli broj");
            string unos = Console.ReadLine();

            if (int.TryParse(unos, out int broj))
            {
                if (broj % 2 == 0)
                {
                    Console.WriteLine("Uneseni broj je paran.");

                }
                else
                {
                    Console.WriteLine("Uneseni broj je neparan");
                }

            }

            else
            {
                Console.WriteLine("Unesite ispravan cijeli broj");
            }
                
        }





    }
}
