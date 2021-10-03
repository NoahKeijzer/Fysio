using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public class Patient : Person
    {
        [Required(ErrorMessage = "Please select your patiënt number")]
        public int Patiëntnumber { get; set; }

        public Patient(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime Geboortedatum, Gender Gender, string Password, int Patiëntnumber)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, Geboortedatum, Gender, Password)
        {
            this.Patiëntnumber = Patiëntnumber;
        }
    }
}