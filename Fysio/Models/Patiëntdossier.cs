using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Patiëntdossier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Patient Patient { get; set; }
        public string Klachten { get; set; }
        public string DiagnoseCode { get; set; }
        public string DiagnosOmschrijving { get; set; }
        public Student Student { get; set; }
        public Physiotherapist Physiotherapist { get; set; }
        public string IntakeGedaanDoor { get; set; }
        public string IntakeOnderSupervisieVan { get; set; }
        public Physiotherapist Hoofdbehandelaar { get; set; }
        public DateTime DatumAanmelding { get; set; }
        public DateTime DatumOntslag { get; set; }
        public string Opmerkingen { get; set; }
        public string Behandelplan { get; set; }
        public string Behandelingen { get; set; }

    }
}
