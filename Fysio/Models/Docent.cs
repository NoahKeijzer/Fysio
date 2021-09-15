using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fysio.Models
{
    public class Docent : Person
    {
        [Required(ErrorMessage = "Please enter your personeels nummer")]
        public int Personeelsnummer { get; set; }

        public Docent(string FirstName, string LastName, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, string Wachtwoord, int Personeelsnummer)
            : base(FirstName, LastName, Emailadres, Telefoonnummer, Geboortedatum, Geslacht, Wachtwoord)
        {
            this.Personeelsnummer = Personeelsnummer;
        }
    }
}

