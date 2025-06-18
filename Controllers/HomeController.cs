using Microsoft.AspNetCore.Mvc;
using NiceAdmin.Models;
using System.Diagnostics;

namespace NiceAdmin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult formselements()
        {
            return View();
        }
        public IActionResult formslayouts()
        {
            return View();
        }

        public IActionResult formseditors()
        {
            return View();
        }
        public IActionResult formsvalidation ()
        {
            return View();
        }
    }
}
