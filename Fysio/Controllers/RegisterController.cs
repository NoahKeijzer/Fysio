using DataAccess.Data;
using Domain.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModels;

namespace Presentation.Controllers
{
    public class RegisterController : Controller
    {
        // Just to see if things are in sync again

        private readonly ISQLRepo<Patient> _PatientRepo;
        private readonly ISQLRepo<Student> _StudentRepo;
        private readonly ISQLRepo<Physiotherapist> _PhysiotherapistRepo;


        public RegisterController(ISQLRepo<Student> StudentRepo, ISQLRepo<Patient> PatientRepo, ISQLRepo<Physiotherapist> PhysiotherapistRepo)
        {
            _PatientRepo = PatientRepo;
            _StudentRepo = StudentRepo;
            _PhysiotherapistRepo = PhysiotherapistRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterNewPatient()
        {
            return View("RegisterNewPatient");
        }
        [HttpPost]
        public IActionResult RegisterNewStudent(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Student != null)
            {
                _StudentRepo.Create(registerViewModel.Student);
                return View("Thanks");
            }          
            return View("Register");
            // Implement method that validates the data and saves it in the database
        }
        [HttpPost]
        public IActionResult RegisterNewPatient(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Patient != null)
            {
                _PatientRepo.Create(registerViewModel.Patient);
                return View("Thanks");
            }
            return View("Register");
        }
        [HttpPost]
        public IActionResult RegisterNewPhysiotherapist(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Physiotherapist != null)
            {
                _PhysiotherapistRepo.Create(registerViewModel.Physiotherapist);
                return View("Thanks");
            }
            return View("Register");
        }
    }
}
