using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E0501
    {

        // Za unesenu riječ provjerite da li je palindrom?
        // Palindrom je riječ koja se jednako čita s obje strane
        // anavolimilovana, 02022020, ananabraparbanana, evolove, evoove

        public static void Izvedi() 
        {
            Console.WriteLine("Unesite riječ ili broj za provjeru");
                string unos = Console.ReadLine();


            unos = unos.ToLower();

            int pocetak = 0;
            int kraj = unos.Length - 1;

            bool jePalidrom = true;
            while (pocetak < kraj)
            {
                if (unos[pocetak] != unos[kraj])
                { 
                    jePalidrom = false;
                    break;
                }
                pocetak++;
                kraj--;
            }
              

            if (jePalidrom)
            {
                Console.WriteLine($"'{unos}' je palidrom");
            }
            else
            {
                Console.WriteLine($"'{unos}' nije palidrom.");
            }

        }
            
     
    }
}
