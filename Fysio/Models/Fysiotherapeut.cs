using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Fysiotherapeut : Person
    {
        public int BIGNummer { get; set; }

        public Fysiotherapeut(string Name, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, int BIGNummer)
            : base(Name, Emailadres, Telefoonnummer, Geboortedatum, Geslacht)
        {
            this.BIGNummer = BIGNummer;
        }
    }
}
