using System;
using System.Text;

namespace UcenjeCS
{
    internal class GeneratorLozinke
    {
        // Funkcija za generiranje lozinke
        internal static string GenerirajLozinku(int duzina, bool velikaSlova, bool malaSlova, bool brojevi, bool interpunkcija, bool pocinjeBrojem, bool pocinjeInterpunkcijom, bool zavrsavaBrojem, bool zavrsavaInterpunkcijom, bool bezPonavljanja)
        {
            string velikaSlovaSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string malaSlovaSet = "abcdefghijklmnopqrstuvwxyz";
            string brojeviSet = "0123456789";
            string interpunkcijaSet = "!@#$%^&*()-_=+[{]};:'\"\\|,<.>/?`~";
            StringBuilder dostupniZnakovi = new StringBuilder();
            StringBuilder lozinka = new StringBuilder();
            Random random = new Random();

            // Prikupljanje dostupnih znakova
            if (velikaSlova) dostupniZnakovi.Append(velikaSlovaSet);
            if (malaSlova) dostupniZnakovi.Append(malaSlovaSet);
            if (brojevi) dostupniZnakovi.Append(brojeviSet);
            if (interpunkcija) dostupniZnakovi.Append(interpunkcijaSet);

            if (dostupniZnakovi.Length == 0)
            {
                return "Nema dovoljno opcija za generiranje lozinke!";
            }

            
            if (pocinjeBrojem)
            {
                lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
            }
            else if (pocinjeInterpunkcijom)
            {
                lozinka.Append(interpunkcijaSet[random.Next(interpunkcijaSet.Length)]);
            }

            
            while (lozinka.Length < duzina - 1)
            {
                char sljedeciZnak = dostupniZnakovi[random.Next(dostupniZnakovi.Length)];
                if (bezPonavljanja && lozinka.ToString().Contains(sljedeciZnak))
                {
                    continue; 
                }
                lozinka.Append(sljedeciZnak);
            }

            
            if (zavrsavaBrojem)
            {
                lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
            }
            else if (zavrsavaInterpunkcijom)
            {
                lozinka.Append(interpunkcijaSet[random.Next(interpunkcijaSet.Length)]);
            }
            else
            {
                lozinka.Append(dostupniZnakovi[random.Next(dostupniZnakovi.Length)]);
            }

            return lozinka.ToString();
        }

        
        internal static void Izvedi()
        {
            
            Console.Write("Unesite dužinu lozinke: ");
            int duzina = int.Parse(Console.ReadLine());

            Console.Write("Uključiti velika slova? (da/ne): ");
            bool velikaSlova = Console.ReadLine().ToLower() == "da";

            Console.Write("Uključiti mala slova? (da/ne): ");
            bool malaSlova = Console.ReadLine().ToLower() == "da";

            Console.Write("Uključiti brojeve? (da/ne): ");
            bool brojevi = Console.ReadLine().ToLower() == "da";

            Console.Write("Uključiti interpunkcijske znakove? (da/ne): ");
            bool interpunkcija = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka počinje brojem? (da/ne): ");
            bool pocinjeBrojem = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka počinje interpunkcijskim znakom? (da/ne): ");
            bool pocinjeInterpunkcijom = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka završava brojem? (da/ne): ");
            bool zavrsavaBrojem = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka završava interpunkcijskim znakom? (da/ne): ");
            bool zavrsavaInterpunkcijom = Console.ReadLine().ToLower() == "da";

            Console.Write("Lozinka nema ponavljajuće znakove? (da/ne): ");
            bool bezPonavljanja = Console.ReadLine().ToLower() == "da";

            Console.Write("Koliko lozinki generirati? ");
            int brojLozinki = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(duzina, velikaSlova, malaSlova, brojevi, interpunkcija, pocinjeBrojem, pocinjeInterpunkcijom, zavrsavaBrojem, zavrsavaInterpunkcijom, bezPonavljanja);
                Console.WriteLine($"Lozinka {i + 1}: {lozinka}");
            }
        }
    }
}
