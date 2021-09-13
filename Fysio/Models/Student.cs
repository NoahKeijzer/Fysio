using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Student : Person
    {
        public int Studentnummer { get; set; }

        public Student(string Name, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, int Studentnummer) 
            : base(Name, Emailadres, Telefoonnummer, Geboortedatum, Geslacht)
        {
            this.Studentnummer = Studentnummer;
        }
    }
}
