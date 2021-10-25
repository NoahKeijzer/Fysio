using Domain.DomainModels;
using System.Collections.Generic;

namespace Presentation.ViewModels
{
    public class PatientDossierViewModel
    {
        public Patiëntdossier Patiëntdossier { get; set; }
        public IEnumerable<Physiotherapist> Physiotherapists { get; set; }
        public Patient Patient { get; set; }

        public PatientDossierViewModel()
        {

        }
    }
}
