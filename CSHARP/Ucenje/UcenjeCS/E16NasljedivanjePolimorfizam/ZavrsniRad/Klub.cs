using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Klub:Entitet
    {
        
        public string? Naziv { get; set; }
        public DateTime? Osnovan { get; set; }
        public string? Stadion { get; set; }
        public string? Predsjednik { get; set; }
        public string? Drzava { get; set; }
        public string? Liga { get; set; }


        public Klub(int entitet, string? naziv, DateTime osnovan, string? stadion, string? predsjednik, string? drzava, string? liga)
        {

                 Sifra = entitet;
                 Naziv = naziv;
                 Osnovan = osnovan;
                 Stadion = stadion;
                 Predsjednik = predsjednik;
                 Drzava = drzava;
                 Liga = liga;                             

        }

        public override string ToString()
        {
            return $"Klub: {Naziv}, Osnovan: {Osnovan}, Stadion: {Stadion}, Predsjednik: {Predsjednik}, Drzava: {Drzava}, Liga: {Liga}";
        }


    }
}
