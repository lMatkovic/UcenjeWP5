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
            Console.WriteLine("Unesi cijeli broj ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {

                Console.WriteLine("broj " + broj + " je paran");
            }
            else
            {
                Console.WriteLine("broj " + broj + " je neparan");
            }
               
        }





    }
}
