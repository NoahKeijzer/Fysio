using Domain.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PatientDossierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPatientDossier(Patient patient)
        {
            return View(patient);
        }
        public IActionResult EditPatientDossier(Patient patient)
        {
            return View(patient);
        }
    }
}
