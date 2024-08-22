using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Igrac:Entitet
    {

        public string? Ime { get; set; }
        public string? Prezime { get;set; }
        public DateTime? DatumRođenja { get; set; }
        public string  Pozicija { get; set; }
        public int BrojDresa { get; set; }
        public Klub Klub { get; set; }






    }
}
