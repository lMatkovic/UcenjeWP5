using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z2
    {
        // Program unosi brojeve sve dok se ne unese broj -1
        // Program ispisuje zbroj svih unesenih brijeva

        public static void Izvedi()
        {
            int zbroj = 0;
            int broj;


            do
            {
                Console.WriteLine("Unesi broj (-1 za kraj)");
                broj = int.Parse(Console.ReadLine());

                if (broj != -1)
                {
                    zbroj += broj;
                }
            } while (broj != -1);

            Console.WriteLine("Zbroj svih unesenih brojeva je: " + zbroj);
        }

        
    }
}
