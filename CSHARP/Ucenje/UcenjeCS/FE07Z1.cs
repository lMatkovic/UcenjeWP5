using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z11
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

            /*

            int broj;
            Console.Write("Unesite cijeli broj: ");

            while (!int.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine("Pogrešan unos! Molim unesite cijeli broj.");
            }

            int zbroj = 0;
            int i = 1;

            while (i <= broj)
            {
                if (i % 2 == 0)
                {
                    zbroj += i;
                }

                i++;



            }

            Console.WriteLine($"Zbroj svih parnih brojeva od 1 do {broj} je: {zbroj}");

            */


            // drugi zadatak


            int[] brojevi = new int[10];
            int zbroj = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Unesite broj {i + 1}: ");

                while (!int.TryParse(Console.ReadLine(), out brojevi[1]))
                {
                    Console.WriteLine("Pogrešan unos! Molim unesite cijeli broj.");
                    
                }
                zbroj += brojevi[1];
            }
            






        }

    }
}