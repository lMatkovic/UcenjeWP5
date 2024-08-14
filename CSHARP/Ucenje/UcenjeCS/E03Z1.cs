using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        // Program od korisnika traži unos broj godina koje ima korisnik
        // Program ispisuje da li je korisnik punoljetna osoba ili ne


        // dodatno: ako je unos ispod nula godine ili iznad 112 godina ipisasti GREŠKA

        public static void Izvedi()
        {

            Console.WriteLine("Unesite broj godina koje imate:");
            string unos = Console.ReadLine();



            if (int.TryParse(unos, out int godine))
            {
                if (godine < 0 || godine > 112)
                {
                    Console.WriteLine("uneseni broj godina nije validan.");
                }


                else if (godine >= 18)
                {
                    Console.WriteLine("Vi ste punoljetna osoba.");
                }

                else
                {
                    Console.WriteLine("Vi niste punoljetna osoba.");
                }



            }


            else 
            {
                Console.WriteLine("Unesite ispravan broj godina");
            }

    }





    }
}
