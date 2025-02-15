using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Colton.Models;

namespace Mission06_Colton.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
