using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Colton.Models;
using static System.Net.Mime.MediaTypeNames;

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

            ViewBag.Categories = _context.Categories
              .OrderBy(x => x.CategoryName)
              .ToList();

            return View("Create", new Movie());
        }
        [HttpPost]
        public IActionResult Create(Movie response) //Adding record to database from the form
        {

            if (ModelState.IsValid)
            {

                _context.Movies.Add(response); // Add Record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {

                ViewBag.Categories = _context.Categories
                   .OrderBy(x => x.CategoryName)
                   .ToList();

                return View(response);
            }
        }


        public IActionResult MovieList()
        {

            //Linq
            var applications = _context.Movies
             .OrderBy(x => x.Title).ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
              .OrderBy(x => x.CategoryName)
              .ToList();
            return View("Create", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie application)
        {
            _context.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
