using DataAccess.Data;
using Domain.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModels;

namespace Presentation.Controllers
{
    public class PatientController : Controller
    {
        private PatientDossierViewModel PatientDossierViewModel;
        private readonly ISQLRepo<Patient> _PatientRepo;
        private readonly ISQLRepo<Patiëntdossier> _PatientdossierRepo;
        private readonly ISQLRepo<Physiotherapist> _PhysiotherapistRepo;

        public PatientController(ISQLRepo<Patient> PatientRepo, ISQLRepo<Patiëntdossier> PatientdossierRepo, ISQLRepo<Physiotherapist> PhysiotherapistRepo)
        {
            PatientDossierViewModel = new PatientDossierViewModel();
            _PatientRepo = PatientRepo;
            _PatientdossierRepo = PatientdossierRepo;
            _PhysiotherapistRepo = PhysiotherapistRepo;
        }

        public IActionResult Index()
        {
            return View("~/Views/Overview/OverviewPatients.cshtml", _PatientRepo.Get());
        }

        [Route("/Patient/Index/{id}")]
        public IActionResult PatientDossier(int id)
        {
            PatientDossierViewModel.Physiotherapists = _PhysiotherapistRepo.Get();
            PatientDossierViewModel.Patient = _PatientRepo.Get(id);
  
            if (_PatientRepo.Get(id).Patiëntdossier != null)
            {
                return View("~/Views/PatientDossier/EditPatientDossier.cshtml", PatientDossierViewModel);
            }
            return View("~/Views/PatientDossier/AddPatientDossier.cshtml", PatientDossierViewModel);
        }
        [HttpPost]
        public IActionResult PatientDossier(PatientDossierViewModel PatientDossierViewModel)
        {
            _PatientdossierRepo.Create(PatientDossierViewModel.Patiëntdossier);
            PatientDossierViewModel.Patient.Patiëntdossier.PatientEmail = PatientDossierViewModel.Patient.Emailaddress;
            PatientDossierViewModel.Patient.Patiëntdossier = PatientDossierViewModel.Patiëntdossier;
            return View("Index");
        }
    }
}
