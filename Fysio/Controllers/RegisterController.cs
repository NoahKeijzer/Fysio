using DataAccess.Data;
using Fysio.Models;
using Microsoft.AspNetCore.Mvc;

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
