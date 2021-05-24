using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram6ImageDisplayController : Controller
    {
        // GET: PracticeProgram6ImageDisplay
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string radioChoice)
        {
            if (radioChoice == "blueHills")
            {
                ViewBag.result = "~/Content/Images/bluehills.jpg";
            }
            else if (radioChoice == "sunset")
            {
                ViewBag.result = "~/Content/Images/sunset.jpg";
            }
            else if (radioChoice == "waterLilis")
            {
                ViewBag.result = "~/Content/Images/waterlilis.jpg";
            }
            else if (radioChoice == "winter")
            {
                ViewBag.result = "~/Content/Images/winter.jpg";
            }
            else
            {
                ViewBag.result = "~/Content/Images/bluehills.jpg";
            }
            return View();
        }
    }
}