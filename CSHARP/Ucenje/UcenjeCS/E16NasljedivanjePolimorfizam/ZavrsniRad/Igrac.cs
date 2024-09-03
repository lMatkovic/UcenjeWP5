using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Igrac : Entitet
    {

        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Pozicija { get; set; }
        public int BrojDresa { get; set; }
        public Klub? Klub { get; set; }


        public Igrac(int entitet, string ime, string prezime, DateTime datumRodjenja, string pozicija, int brojDresa, Klub klub)
        {
            Sifra = entitet;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Pozicija = pozicija;
            BrojDresa = brojDresa;
            Klub = klub;
        }

        public override string ToString()
        {
            return $"Igrac: {Ime} {Prezime}, Pozicija: {Pozicija}, Broj Dresa: {BrojDresa}, Klub: {Klub.Naziv}";


        }
    }
}
