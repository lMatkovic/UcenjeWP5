using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {

        // Korisnik unosi brojčanu vrijednost ocjene od 1 do 5
        // Program ispisuje slovno ocjenu, a ako korsnik nije unosio ocjenu
        // program ispisuje: broj nije ocjena
        
        
        internal static void Izvedi()
        {

            Console.WriteLine("Unesite brojčanu vrijednost ocjene (1-5): ");
            string unos = Console.ReadLine();

            switch (unos) 
            {
                case "1":
                    Console.WriteLine("Nedovoljan");
                    break;

                case "2":
                    Console.WriteLine("Dovoljan");
                    break;

                case "3":
                    Console.WriteLine("Dobar");
                    break;

                case "4":
                    Console.WriteLine("Vrlo dobar");
                    break;

                case "5":
                    Console.WriteLine("Odličan");
                    break;

                default:
                    Console.WriteLine("broj nije ocjena");
                    break;
            }
            
            




        }
    }
}
