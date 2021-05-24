using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram18DateTimePickerController : Controller
    {
        // GET: PracticeProgram18DateTimePicker
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(DateTimePicker model, string btnAction)
        {
            if (btnAction == "Submit")
            {
                ViewBag.result = "Selected Date - " + (model.EventDate).ToString("dd/MM/yyyy");
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}