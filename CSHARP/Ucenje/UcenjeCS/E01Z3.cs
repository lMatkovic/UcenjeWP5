using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z3
    {

        //Program od korisnika učitava ime grada i broj stanovnika.
        //Ispisuje rečenicu: U XXXXXXX živi XXXXX ljudi.

        // Osigurati da se upiše grad
        // Osigurati da se upiše broj stanovnika kao broj

       public static void Izvedi()
        {

            string grad;
            int brojStanovnika;

            while (true)
            {
                Console.Write("Unesite ime grada: ");
                grad = Console.ReadLine();



                if (!string.IsNullOrWhiteSpace(grad))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ime grada ne može biti prazno. Molim unesite ime grada");
                }


            }

            while (true)
            {
                Console.Write("Unesite broj stanovnika: ");
                string unosStanovnika = Console.ReadLine();


                if (int.TryParse(unosStanovnika, out brojStanovnika) && brojStanovnika >= 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Neispavan unos! Molim unesite validan cijeli broj koji predstavlja broj stanovnika.");

                }
            
            
            
            
            
            
            }

            Console.WriteLine($"U {grad} živi {brojStanovnika} ljudi." +
                $"");

        }
    }
}
