using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Physiotherapist : Person
    {
        public int BIGNummer { get; set; }

        public Physiotherapist(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, Gender Gender, string Password, int BIGNummer)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, DayOfBirth, Gender, Password)
        {
            this.BIGNummer = BIGNummer;
        }
        public Physiotherapist()
        {

        }
    }
}
