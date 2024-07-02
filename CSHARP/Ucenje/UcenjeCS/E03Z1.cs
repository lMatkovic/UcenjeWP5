using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

         Console.WriteLine("Unesite svoje godine: ");
         int g = int.Parse(Console.ReadLine());

         if (g <= 0 || g >= 112)
         {
             Console.WriteLine("GREŠKA");
         }
         else if (g >= 18)
         {
             Console.WriteLine("Punoljetan");
         }
         else
         {
             Console.WriteLine("Nije punoljetan");
         }



        }
  
       
        




    }
}
