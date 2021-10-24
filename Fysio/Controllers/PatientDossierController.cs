using DataAccess.Data;
using Domain.DomainModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Presentation.Controllers
{
    public class PatientDossierController : Controller
    {
        private readonly ISQLRepo<Patient> _PatientRepo;

        public PatientDossierController(ISQLRepo<Patient> PatientRepo)
        {
            _PatientRepo = PatientRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPatientDossier(int PatientNumber)
        {
            return View(_PatientRepo.Get(PatientNumber));
        }
        public IActionResult EditPatientDossier(int PatientNumber)
        {
            return View(_PatientRepo.Get(PatientNumber));
        }
    }
}
