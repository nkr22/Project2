using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TourContext tourContext { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
        [HttpGet]
        public IActionResult AddTour()
        {

            ViewBag.Times = tourContext.Times.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddTour(Tour t)
        {

            if (ModelState.IsValid)
            {
                tourContext.Add(t);
                tourContext.SaveChanges();
                return View();
            }
            else
            {
                ViewBag.Times = tourContext.Times.ToList();
                return View(t);
            }

        }

        public IActionResult SignUp()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Edit(int tourid)
        {
            ViewBag.Times = tourContext.Times.ToList();

            var tour = tourContext.Tours.Single(x => x.TourId == tourid);

            return View("AddTour", tour);

        }

        [HttpPost]
        public IActionResult Edit(Tour t)
        {
            tourContext.Update(t);
            tourContext.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete( int tourid)
        {
            var tour = tourContext.Tours.Single(x => x.TourId == tourid);
            return View(tour);

        }

        [HttpPost]
        public IActionResult Delete(Tour t)
        {
            tourContext.Remove(t);
            tourContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
