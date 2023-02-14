using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_b2256.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_b2256.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EnterFilmContext blahContext { get; set; }


        public HomeController(ILogger<HomeController> logger, EnterFilmContext somename)
        {
            _logger = logger;
            blahContext = somename;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Podcasts");
        }

        [HttpGet]
        public IActionResult EnterFilm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterFilm(ApplicationResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
