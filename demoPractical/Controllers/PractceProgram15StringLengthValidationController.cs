using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PractceProgram15StringLengthValidationController : Controller
    {
        // GET: PractceProgram15StringLengthValidation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LengthValidator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.comment = model.comment;
            }
            return View();
        }
    }
}