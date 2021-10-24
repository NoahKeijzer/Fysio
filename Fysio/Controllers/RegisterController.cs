using Fysio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Controllers
{
    public class RegisterController : Controller
    {
<<<<<<< Updated upstream
        public IActionResult Register()
=======
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
>>>>>>> Stashed changes
        {
            return View("RegisterPatient");
        }
        [HttpPost]
        public IActionResult RegisterNewPerson(EmployeeViewModel employeeViewModel)
        {
            if (employeeViewModel.Student != null)
            {

            }
            return View();
            // Implement method that validates the data and saves it in the database
        }
    }
}
