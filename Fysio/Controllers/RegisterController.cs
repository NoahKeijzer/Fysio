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
        public IActionResult Register()
        {
            return View();
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
