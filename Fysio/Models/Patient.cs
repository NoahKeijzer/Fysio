using System;

namespace Fysio.Models
{
    public class Patient : Person
    {
        public int Patiëntnummer { get; set; }

        public Patient(string Name, string Emailadres, int Telefoonnummer,  DateTime Geboortedatum, Geslacht Geslacht, int Patiëntnummer)
            : base(Name, Emailadres, Telefoonnummer, Geboortedatum, Geslacht)
        {
            this.Patiëntnummer = Patiëntnummer;
        }
    }
}