using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DomainModels
{
    public class Physiotherapist : Person
    {
        public int BIGNummer { get; set; }
        public string Password { get; set; }

        public Physiotherapist(string FirstName, string LastName, string Emailaddress, int PhoneNumber, DateTime DayOfBirth, string Gender, string Password, int BIGNummer)
            : base(FirstName, LastName, Emailaddress, PhoneNumber, DayOfBirth, Gender)
        {
            this.BIGNummer = BIGNummer;
            this.Password = Password;
        }
        public Physiotherapist()
        {

        }
    }
}
