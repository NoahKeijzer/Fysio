using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Fysiotherapeut : Person
    {
        public int BIGNummer { get; set; }

        public Fysiotherapeut(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, Gender Gender, string Password, int BIGNummer)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, DayOfBirth, Gender, Password)
        {
            this.BIGNummer = BIGNummer;
        }
    }
}
