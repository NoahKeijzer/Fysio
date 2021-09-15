using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public abstract class Person
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        public string Emailadres { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public int Telefoonnummer { get; set; }
        [Required(ErrorMessage = "Please enter your birthday")]
        public DateTime Geboortedatum { get; set; }
        [Required(ErrorMessage = "Please select your gender")]
        public Geslacht Geslacht { get; set; }
        [Required(ErrorMessage = "Please select your password")]
        public string Wachtwoord {  get; set; }

        public Person(string FirstName, string LastName, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, string Wachtwoord)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Emailadres = Emailadres;
            this.Telefoonnummer = Telefoonnummer;
            this.Geboortedatum = Geboortedatum;
            this.Geslacht = Geslacht;
            this.Wachtwoord = Wachtwoord;
        }
    }
}
