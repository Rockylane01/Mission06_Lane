using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Lane.Models;

namespace Mission06_Lane.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var Movies = _context.Movies.ToList();

            return View(Movies);
        }

        // GET and POST for Add Movie
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie m)
        {
            _context.Add(m);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
