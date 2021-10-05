using DataAccess.Data;
using Fysio.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fysio.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISQLRepo<Patient> _PatientRepo;
        private readonly ISQLRepo<Student> _StudentRepo;

        public RegisterController(ISQLRepo<Student> StudentRepo, ISQLRepo<Patient> PatientRepo)
        {
            _StudentRepo = StudentRepo;
            _PatientRepo = PatientRepo;
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterBehandeling()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterNewPerson(RegisterViewModel registerViewModel)
        {   
            if (registerViewModel.Student != null) { 
                _StudentRepo.Create(registerViewModel.Student);
                return View("Thanks");
            }
            else if (registerViewModel.Patient != null)
            {
                _PatientRepo.Create(registerViewModel.Patient);
                return View("Thanks");
            }              
            return View("Register");
            // Implement method that validates the data and saves it in the database
        }
    }
}
