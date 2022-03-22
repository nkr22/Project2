﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Form()
        {
            return View();
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
            ViewBag.Tours = tourContext.Tours.ToList();

            var tour = tourContext.tours.Single(x => x.TourId == tourid);

            return View("AddTour", tour);

        }

        [HttpPost]
        public IActionResult Edit(ContactInfo ci)
        {
            tourContext.Update(ci);
            tourContext.SaveChanges();

            return RedirectToAction("Index")

        }

        [HttpGet]
        public IActionResult Delete( int tourid)
        {
            var tour = tourContext.tours.Single(x => x.TourId == tourid);
            return View(tour);

        }

        [HttpPost]
        public IActionResult Delete(ContactInfo ci)
        {
            tourContext.Remove(ci);
            tourContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
