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

        public IActionResult AddTour()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
