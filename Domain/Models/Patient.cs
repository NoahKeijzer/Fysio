using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public class Patient : Person
    {
        private DateTime minumAge = DateTime.Now.AddDays(-16);

        [Required(ErrorMessage = "Please select your patiënt number")]
        public int Patiëntnumber { get; set; }

        public Patient(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime Geboortedatum, Gender Gender, string Password, int Patiëntnumber)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, Geboortedatum, Gender, Password)
        {
            this.Patiëntnumber = Patiëntnumber;
        }
        public Patient()
        {

        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            DateTime current = Convert.ToDateTime(DayOfBirth);

            if (current > minumAge)
            {
                yield return new ValidationResult("De patient is jonger dan 16 jaar en mag niet geregistreed worden", new[] { nameof(DayOfBirth) });
            }
        }
    }
}