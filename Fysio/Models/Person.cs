using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Person
    {

        public string Name { get; set; }
        public string Emailadres { get; set; }
        public int Telefoonnummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Geslacht Geslacht { get; set; }

        public Person(string Name, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht)
        {
            this.Name = Name;
            this.Emailadres = Emailadres;
            this.Telefoonnummer = Telefoonnummer;
            this.Geboortedatum = Geboortedatum;
            this.Geslacht = Geslacht;
        }
    }
}
