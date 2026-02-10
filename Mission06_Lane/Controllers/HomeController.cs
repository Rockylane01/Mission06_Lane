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
