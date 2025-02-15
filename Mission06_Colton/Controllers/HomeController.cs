using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Colton.Models;

namespace Mission06_Colton.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(Movie response)
        {

            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation");
        }



    }
}
