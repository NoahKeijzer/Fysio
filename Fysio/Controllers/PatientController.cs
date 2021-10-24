using DataAccess.Data;
using Domain.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PatientController : Controller
    {
        private readonly ISQLRepo<Patient> _PatientRepo;
        public PatientController(ISQLRepo<Patient> PatientRepo)
        {
            _PatientRepo = PatientRepo;
        }

        public IActionResult Index()
        {
            return View("~/Views/Overview/OverviewPatients.cshtml", _PatientRepo.Get());
        }

        [Route("/Patient/Index/{id}")]
        public IActionResult PatientDossier(int id)
        {
            if (_PatientRepo.Get(id).Patiëntdossier != null)
            {
                return View("~/Views/PatientDossier/EditPatientDossier.cshtml", _PatientRepo.Get(id));
            }
            return View("~/Views/PatientDossier/AddPatientDossier.cshtml", _PatientRepo.Get(id));
        }
    }
}
