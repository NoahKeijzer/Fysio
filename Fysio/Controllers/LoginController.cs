﻿using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }
    }
}
