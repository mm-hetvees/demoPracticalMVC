using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram14RegexValidatorController : Controller
    {
        // GET: PracticeProgram14RegexValidator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegexValidator model, string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    ViewBag.Email = model.Email;
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