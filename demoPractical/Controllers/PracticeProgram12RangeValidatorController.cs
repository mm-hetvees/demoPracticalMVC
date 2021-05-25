using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram12RangeValidatorController : Controller
    {
        // GET: PracticeProgram12RangeValidator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AgeValidator model, string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    ViewBag.Age = model.age;
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}