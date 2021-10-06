using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DomainModels
{
    public class Patient : Person
    {
        private DateTime minumAge = DateTime.Now.AddDays(-16);

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Please select your patiënt number")]
        public int Patiëntnumber { get; set; }
        public Patiëntdossier Patiëntdossier { get; set; }

        public Patient(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime Geboortedatum, string Gender, int Patiëntnumber)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, Geboortedatum, Gender)
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
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}