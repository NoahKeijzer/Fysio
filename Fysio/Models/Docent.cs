using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Docent : Person
    {
        public int Personeelsnummer { get; set; }

        public Docent(string Name, string Emailadres, int Telefoonnummer, DateTime Geboortedatum, Geslacht Geslacht, int Personeelsnummer)
            : base(Name, Emailadres, Telefoonnummer, Geboortedatum, Geslacht)
        {
            this.Personeelsnummer = Personeelsnummer;
        }
    }
}

