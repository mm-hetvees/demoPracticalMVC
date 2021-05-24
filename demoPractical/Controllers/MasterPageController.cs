using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class MasterPageController : Controller
    {
        // GET: MasterPage
        public ActionResult Index()
        {
            ViewBag.Message = "Your application home page.";
            return View();
        }

        public ActionResult AboutMasterPage()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult ContactMasterPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}