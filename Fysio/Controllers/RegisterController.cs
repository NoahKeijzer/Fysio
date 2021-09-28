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
        public IActionResult Register()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Docent = null;
            mymodel.Students = null;
            return View(mymodel);
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
