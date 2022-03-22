using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private TourContext tourContext { get; set; }

        public HomeController(TourContext newTour)
        {
            tourContext = newTour;
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
        public IActionResult AddTour(int id)
        {

            ViewBag.TimeId = id;

            return View("AddTour");
        }

        [HttpPost]
        public IActionResult AddTour(Tour t)
        {
            
            if (ModelState.IsValid)
            {
                var ttime= tourContext.Times.Single(x => x.SlotId == t.SlotId);
                ttime.Filled = true;
                tourContext.Add(t);
                tourContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(t);
            }

        }
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Times = tourContext.Times.Where(x => x.Filled == false).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Time t)
        {
            var ts = t.SlotId;
            return RedirectToAction("AddTour", ts);
        }


        [HttpGet]
        public IActionResult Edit(int tourid, int slotid)
        {
            ViewBag.TimeId = slotid;

            var tour = tourContext.Tours.Single(x => x.TourId == tourid);

            return View("AddTour", tour);

        }

        [HttpPost]
        public IActionResult Edit(Tour t)
        {
            if (ModelState.IsValid)
            {
                tourContext.Update(t);
                tourContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("AddTour", t);
            }
            
        }

        public IActionResult Delete(Tour t, int id)
        {
            ViewBag.TimeId = id;
            var ttime = tourContext.Times.Single(x => x.SlotId == t.SlotId);
            ttime.Filled = false;
            tourContext.Remove(t);
            tourContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ViewTours (Tour t)
        {
            var tours = tourContext.Tours.Include(x => x.Slot).ToList();
            return View(tours);
        }

    }
}
