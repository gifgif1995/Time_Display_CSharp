
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace time_display.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            DateTime aDate = DateTime.Now;
            ViewBag.DayDisplay = aDate.ToString("dddd");
            ViewBag.DateDisplay2 = aDate.ToString("MMM dd, yyyy");
            ViewBag.TimeDisplay = aDate.ToString("hh:mm tt");
            return View("home");
        }
    }
}