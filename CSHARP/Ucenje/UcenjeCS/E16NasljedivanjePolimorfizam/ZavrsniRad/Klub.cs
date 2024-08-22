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
        public string ? Liga { get; set; }



    }
}
