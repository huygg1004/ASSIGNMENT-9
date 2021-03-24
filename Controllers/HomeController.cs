using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3_Movie.Models;
using DateMe.Models;

namespace Assignment3_Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext _context;

        public HomeController(ILogger<HomeController> logger, MoviesContext context)
        {
            _logger = logger;
            _context = context;
        }
        // homepage
        public IActionResult Index()
        {
            return View();
        }

        //return podcast page
        public IActionResult podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieList(Movies newMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(newMovie);
                _context.SaveChanges();
                return RedirectToAction("EnteredList");
            }
            else
            {
                return View();
            }

        }

        public IActionResult EnteredList(Movies movie)
        {
            //return View();
            return View(_context.Movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
