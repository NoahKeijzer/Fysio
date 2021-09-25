using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public class Patient : Person
    {
        [Required(ErrorMessage = "Please select your patiënt number")]
        public int Patiëntnummer { get; set; }
        public ICollection<Patiëntdossier> Patiëntdossier { get; set; }
        public Patient(string FirstName, string LastName, string Emailadres, int Telefoonnummer,  DateTime Geboortedatum, Geslacht Geslacht, string Wachtwoord, int Patiëntnummer)
            : base(FirstName, LastName, Emailadres, Telefoonnummer, Geboortedatum, Geslacht, Wachtwoord)
        {
            this.Patiëntnummer = Patiëntnummer;
        }
    }
}