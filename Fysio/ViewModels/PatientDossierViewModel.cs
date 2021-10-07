using Domain.DomainModels;

namespace Presentation.ViewModels
{
    public class PatientDossierViewModel
    {
        public Physiotherapist Physiotherapist { get; set; }
        public Patient Patient { get; set; }

        public PatientDossierViewModel()
        {

        }
    }
}
