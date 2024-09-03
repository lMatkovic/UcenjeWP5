using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Utakmica:Entitet
    {
        public DateTime? Datum { get; set; }
        public string? Lokacija { get; set; }
        public string? Stadion { get; set; }
        public Klub? DomaciKlub { get; set; }
        public Klub? GostujuciKlub { get; set; }



        public Utakmica(int entitet, DateTime datum, TimeSpan vrijeme, string lokacija, string stadion, Klub domaciKlub, Klub gostujuciKlub)
        {
            Sifra = entitet;
            Datum = datum;
            Lokacija = lokacija;
            Stadion = stadion;
            DomaciKlub = domaciKlub;
            GostujuciKlub = gostujuciKlub;
        }

        public override string ToString()
        {
            return $"Utakmica: Datum {Datum}, Lokacija: {Lokacija}, Stadion: {Stadion}, Domaci Klub: {DomaciKlub.Naziv}, Gostujuci Klub: {GostujuciKlub.Naziv}";
        }


    }
}
