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
        public string?  nacionalnost { get; set; }
        public string? iskustvo { get; set; }
        public Klub Klub { get; set; }



    }
}
