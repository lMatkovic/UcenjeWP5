using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Trener:Entitet
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set;}
        public string?  Nacionalnost { get; set; }
        public int? Iskustvo { get; set; }
        public Klub? Klub { get; set; }



        public Trener(int entitet, string ime, string prezime, Klub klub, string nacionalnost, int iskustvo)
        {
            Sifra = entitet;
            Ime = ime;
            Prezime = prezime;
            Klub = klub;
            Nacionalnost = nacionalnost;
            Iskustvo = iskustvo;
        }

        public override string ToString()
        {
            return $"Trener: {Ime} {Prezime}, Nacionalnost: {Nacionalnost}, Iskustvo: {Iskustvo} godina, Klub: {Klub.Naziv}";
        }



    }
}
