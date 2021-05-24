using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram11RequiredFieldValidationController : Controller
    {
        // GET: PracticeProgram11RequiredFieldValidation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RequiredFieldValidation model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FirstName = model.FirstName;
                ViewBag.LastName = model.LastName;
            }
            return View();
        }
    }
}