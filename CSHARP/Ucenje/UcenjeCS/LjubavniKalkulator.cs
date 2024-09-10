using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        internal static void Izvedi()
        {

            Console.Write("Unesi svoje ime: ");
            string ime1 = Console.ReadLine().ToUpper();

            Console.Write("Unesi ime simpatije: ");
            string ime2 = Console.ReadLine().ToUpper();


            string imena = ime1 + ime2;


            List<int> brojevi = BrojanjeSlova(imena);


            Console.WriteLine(string.Join("", brojevi));



            brojevi = ZbrojiBrojeve(brojevi);


            int rezultat = int.Parse(string.Join("", brojevi));
            Console.WriteLine(rezultat);
        }


        static List<int> BrojanjeSlova(string imena)
        {
            List<int> brojevi = new List<int>();
            foreach (char slovo in imena)
            {
                int count = 0;
                foreach (char s in imena)
                {
                    if (slovo == s) count++;
                }
                brojevi.Add(count);
            }
            return brojevi;
        }


        static List<int> ZbrojiBrojeve(List<int> brojevi)
        {

            if (brojevi.Count <= 2)
            {
                return brojevi;
            }

            List<int> noviBrojevi = new List<int>();
            int i = 0, j = brojevi.Count - 1;

            while (i <= j)
            {
                if (i == j)
                {
                    noviBrojevi.Add(brojevi[i]);
                }
                else
                {
                    int zbroj = brojevi[i] + brojevi[j];

                    foreach (char broj in zbroj.ToString())
                    {
                        noviBrojevi.Add(int.Parse(broj.ToString()));
                    }
                }
                i++;
                j--;
            }

            if (noviBrojevi.Count > 2)
            {
                Console.WriteLine(string.Join("", noviBrojevi));
            }

            return ZbrojiBrojeve(noviBrojevi);
        }
    }

}
    

