using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.DomainModels
{
    public class Teacher : Person
    {
        [Required(ErrorMessage = "Please enter your personeels nummer")]
        public int StaffNumber { get; set; }

        public Teacher(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, string Gender, int StaffNumber)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, DayOfBirth, Gender)
        {
            this.StaffNumber = StaffNumber;
        }
        public Teacher()
        {

        }
    }
}

