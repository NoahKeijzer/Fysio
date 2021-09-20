using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Models
{
    public class Patiëntdossier
    {
        public int Id { get; }
        public string Name { get; set; }
        public Patient Patient { get; set; }
        public string Klachten { get; set; }
        public string DiagnoseCode { get; set; }
        public string DiagnosOmschrijving { get; set; }
        public Student Student { get; set; }
        public Fysiotherapeut Fysiotherapeut { get; set; }
        public string IntakeGedaanDoor { get; set; }
        public string IntakeOnderSupervisieVan { get; set; }
        public Fysiotherapeut Hoofdbehandelaar { get; set; }
        public DateTime DatumAanmelding { get; set; }
        public DateTime DatumOntslag { get; set; }
        public string Opmerkingen { get; set; }
        public string Behandelplan { get; set; }
        public string Behandelingen { get; set; }

    }
}
