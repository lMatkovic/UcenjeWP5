using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {

        public static void Izvedi()
        {
            Console.WriteLine("Unesite ocjenu (1-5):");
            int ocjena;

            
            if (!int.TryParse(Console.ReadLine(), out ocjena))
            {
                Console.WriteLine("Niste unijeli ispravan broj.");
                return;
            }

            
            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Ocjena je nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Ocjena je dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Ocjena je dobar");
                    break;
                case 4:
                    Console.WriteLine("Ocjena je vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Ocjena je odličan");
                    break;
                default:
                    Console.WriteLine("Unijeli ste ocjenu izvan raspona 1-5.");
                    break;
            }
        }
    }