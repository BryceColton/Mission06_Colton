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
        public IActionResult Index() // Returns the home view
        {
            return View();
        }

        public IActionResult Joel() // Returns the Joel Page
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create() // Return the form page
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(Movie response) //Adding record to database from the form
        {

            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation");
        }



    }
}
