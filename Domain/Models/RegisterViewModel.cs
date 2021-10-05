using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class RegisterViewModel
    {
        public Physiotherapist Physiotherapist { get; set; }
        public Student Student { get; set; }
        public Patient Patient {  get; set; }

        public RegisterViewModel()
        {

        }
    }
}
