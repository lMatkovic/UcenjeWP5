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
        public Klub DomaciKlub { get; set; }
        public Klub GostujuciKlub { get; set; }
             
        
    }
}
