using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Fysio.Models
{
    public abstract class Person : IValidatableObject
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [BindProperty, DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email address")]
        public string Emailaddress { get; set; }
        [BindProperty, DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your phone number")]
        public int PhoneNumber { get; set; }
        [BindProperty, DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter your birthday")]
        public DateTime DayOfBirth { get; set; }
        [Required(ErrorMessage = "Please select your gender")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Please select your password")]
        public string Password {  get; set; }

        public Person(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, Gender Gender, string Password)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Emailaddress = Emailaddress;
            this.PhoneNumber = PhoneNumber;
            this.DayOfBirth = DayOfBirth;
            this.Gender = Gender;
            this.Password = Password;
        }
        public Person()
        {

        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        
    }
}
