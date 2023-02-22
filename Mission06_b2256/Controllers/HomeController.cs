using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categorys = blahContext.Categorys.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult EnterFilm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return View("confirmation", ar);
            }
            else //if it's invalid
            {
                ViewBag.Categorys = blahContext.Categorys.ToList();
                return View(ar);
            }

            
        }
        
        public IActionResult filmlist()
        {
            var films = blahContext.Responses.
                Include(x => x.Category).ToList();
            return View(films);
        }

        [HttpGet]
        public IActionResult Edit(int FilmID)
        {
            ViewBag.Categorys = blahContext.Categorys.ToList();
            var application = blahContext.Responses.Single(x => x.FilmID == FilmID);
            return View("EnterFilm", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();
            return RedirectToAction("filmlist");
        }
        [HttpGet]
        public IActionResult delete(int FilmID)
        {
            var moviestuff = blahContext.Responses.Single(x => x.FilmID == FilmID);
            return View(moviestuff);
        }
        [HttpPost]
        public IActionResult delete(ApplicationResponse ar)
        {
            blahContext.Responses.Remove(ar);
            blahContext.SaveChanges();
            return RedirectToAction("filmlist");
        }
    }
}
