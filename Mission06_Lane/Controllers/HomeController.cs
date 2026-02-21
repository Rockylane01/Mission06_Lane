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

        // GET for Movie List
        [HttpGet]
        public IActionResult MovieList()
        {
            var Movies = _context.Movies.ToList();

            return View(Movies);
        }

        // GET and POST for Add Movie
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie m)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(m);
            }
            _context.Add(m);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        // GET and POST for Edit Movie
        [HttpGet]
        public IActionResult EditMovie(int id)
        {
            var m = _context.Movies
                .Single(m => m.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", m);
        }

        [HttpPost]
        public IActionResult EditMovie(Movie m)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View("AddMovie", m);
            }

            _context.Update(m);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        // GET and POST for Delete Movie
        [HttpGet]
        public IActionResult DeleteMovie(int id)
        {
            var record = _context.Movies.Single(x => x.MovieId == id);

            return View(record);
        }

        [HttpPost]
        public IActionResult DeleteMovie(Movie m)
        {
            _context.Movies.Remove(m);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
