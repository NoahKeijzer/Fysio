using Fysio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fysio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        { 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
<<<<<<< Updated upstream
=======
        [Route("Home/OverviewPatients")]
        public IActionResult OverviewPatients()
        {
            return View(_PatientRepo.Get());
        }

        [Route("/Home/OverviewPatients/{id}")]
        public IActionResult OverviewPatients(int id)
        {
            return View("~/Views/PatientDossier/AddPatientDossier.cshtml", _PatientRepo.Get(id));
        }
>>>>>>> Stashed changes

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
