using Fysio.Data;
using Fysio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Controllers
{
    public class RegisterController : Controller
    {
        // private readonly IRepo<Patient> _PatientRepo;
        private readonly IRepo<Student> _StudentRepo;

        public RegisterController(IRepo<Student> StudentRepo)
        {
            _StudentRepo = StudentRepo;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterNewPerson(EmployeeViewModel employeeViewModel)
        {   
            if (employeeViewModel.Student != null)
            {
                _StudentRepo.Create(employeeViewModel.Student);
                return View("Thanks");
            }
            return View("Register");
            // Implement method that validates the data and saves it in the database
        }
    }
}
