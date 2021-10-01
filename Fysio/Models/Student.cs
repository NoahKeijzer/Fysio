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
        public int Studentnumber { get; set; }

        public Student(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, Gender Gender, string Wachtwoord, int Studentnumber) 
            : base(FirstName, LastName, Emailaddress, PhoneNumber, DayOfBirth, Gender, Wachtwoord)
        {
            this.Studentnumber = Studentnumber;
        }
    }
}
