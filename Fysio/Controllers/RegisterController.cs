using DataAccess.Data;
using Fysio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fysio.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISQLRepo<Patient> _PatientRepo;
        private readonly ISQLRepo<Student> _StudentRepo;
        private readonly ISQLRepo<Physiotherapist> _PhysiotherapistRepo;


        public RegisterController(ISQLRepo<Student> StudentRepo, ISQLRepo<Patient> PatientRepo, ISQLRepo<Physiotherapist> PhysiotherapistRepo)
        {
            _PatientRepo = PatientRepo;
            _StudentRepo = StudentRepo;
            _PhysiotherapistRepo = PhysiotherapistRepo;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterNewPerson(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Student != null)
            {
                _StudentRepo.Create(registerViewModel.Student);
                return View("Thanks");
            }
            else if (registerViewModel.Patient != null)
            {
                _PatientRepo.Create(registerViewModel.Patient);
                return View("Thanks");
            }
            else if (registerViewModel.Physiotherapist != null)
            {
                _PhysiotherapistRepo.Create(registerViewModel.Physiotherapist);
                return View("Thanks");
            }
            return View("Register");
            // Implement method that validates the data and saves it in the database
        }
    }
}
