using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z2
    {

        // zadatak
        // Korisnik će unijeti dvoznamenkasti broj
        // Ispisuje se prva znamenka
        // 56 => 5
        // 11 => 1

        public static void Izvedi()
        {
            Console.Write("Unesite dvoznamenkasti broj: ");

            if (int.TryParse(Console.ReadLine(), out int broj) && broj >= 10 && broj <= 99)
            {

                int prvaZnamenka = broj / 10;
                Console.WriteLine("Prva znamenka je " + prvaZnamenka);
            }
            else
            {
                Console.WriteLine("Molim unesite validan dvoznamenkasti broj.");
            }
              









        }
    }
    
}
