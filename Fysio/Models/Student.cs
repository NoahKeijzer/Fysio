using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public class Student : Person
    {
        [Required(ErrorMessage = "Please enter your student number")]
        public int Studentnummer { get; set; }

        public Student(string FirstName, string LastName, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, string Wachtwoord, int Studentnummer)
            : base(FirstName, LastName, Emailadres, Telefoonnummer, Geboortedatum, Geslacht, Wachtwoord)
        {
            this.Studentnummer = Studentnummer;
        }
    }
}
