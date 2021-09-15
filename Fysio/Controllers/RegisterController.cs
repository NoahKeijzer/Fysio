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
        public IActionResult RegisterNewPerson(Person person)
        {
            // Implement method that validates the data and saves it in the database
            if (ModelState.IsValid)
            {
                Repository.AddResponse(person);
                return View("Thanks", person);
            }
            else
            {
                return RedirectToAction("Register"); 
            }
        }
    }
}
