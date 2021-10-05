using DataAccess.Data;
using Fysio.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fysio.Controllers
{
    public class RegisterController : Controller
    {
        // private readonly IRepo<Patient> _PatientRepo;
        private readonly ISQLRepo<Student> _StudentRepo;

        public RegisterController(ISQLRepo<Student> StudentRepo)
        {
            _StudentRepo = StudentRepo;
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterBehandeling()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            registerViewModel.Patient = new Patient
                ("Noah", "de Keijzer", "Emailadres", 012345678, DateTime.Now, "Male", "Wachtwoord", 12345678);

            return View(registerViewModel);
        }
        [HttpPost]
        public IActionResult RegisterNewPerson(RegisterViewModel registerViewModel)
        {   
            if (registerViewModel.Student != null)
            {
                _StudentRepo.Create(registerViewModel.Student);
                return View("Thanks");
            }
            return View("Register");
            // Implement method that validates the data and saves it in the database
        }
    }
}
