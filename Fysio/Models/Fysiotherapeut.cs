using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Fysiotherapeut : Person
    {
        public int BIGNummer { get; set; }
        public Student student { get; set; }
        public Docent docent { get; set; }
        public Fysiotherapeut(string FirstName, string LastName, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, string Wachtwoord, int BIGNummer)
            : base(FirstName, LastName, Emailadres, Telefoonnummer, Geboortedatum, Geslacht, Wachtwoord)
        {
            this.BIGNummer = BIGNummer;
        }
    }
}
