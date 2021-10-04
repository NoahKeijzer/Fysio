using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public class Teacher : Person
    {
        [Required(ErrorMessage = "Please enter your personeels nummer")]
        public int StaffNumber { get; set; }

        public Teacher(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, string Gender, string Wachtwoord, int StaffNumber)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, DayOfBirth, Gender, Wachtwoord)
        {   
            this.StaffNumber = StaffNumber;
        }
        public Teacher()
        {

        }
    }
}

