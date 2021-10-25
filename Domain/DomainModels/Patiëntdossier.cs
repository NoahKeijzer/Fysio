using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DomainModels
{
    public class Patiëntdossier
    {
        public Patient Patient { get; set; }
        public string PatientEmail { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Klachten { get; set; }
        public int DiagnoseCode { get; set; }
        public string DiagnoseOmschrijving { get; set; }
        public string IntakeGedaanDoor { get; set; }
        public string IntakeOnderSupervisieVan { get; set; }
        public Physiotherapist Hoofdbehandelaar { get; set; }
        public DateTime DatumAanmelding { get; set; }
        public DateTime DatumOntslag { get; set; }
        public string Opmerkingen { get; set; }
        public string Behandelplan { get; set; }
        public Therapy Therapy { get; set; }

    }
}
