﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Predavac: Osoba
    {
     

        public Predavac() { }

        public Predavac(int sifra, string ime, string prezime,string IBAN) 
        {
            base.Sifra = sifra;
            base.Ime = ime;
            base.Prezime = prezime;
          


        }
    }
}
