using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1
    {
        public static void Izvedi()
        {
            
            Console.Write("Unesite prvi broj: ");
            int prviBroj = int.Parse(Console.ReadLine());

            
            Console.Write("Unesite drugi broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());

            
            if (prviBroj < drugiBroj)
            {
                for (int i = prviBroj + 1; i < drugiBroj; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (prviBroj > drugiBroj)
            {
                for (int i = drugiBroj + 1; i < prviBroj; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Nema brojeva između jer su oba broja jednaka.");
            }
        }
    }
}
