using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram2TextboxDataDsiplayController : Controller
    {
        // GET: PracticeProgram2TextboxDataDsiplay
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Index(textboxDataDisplayInLabel model)
        {
            ViewBag.data = "Entered Value Is :" + model.name;
            return View();
        }
    }
}