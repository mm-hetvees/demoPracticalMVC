using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram17FileUploadController : Controller
    {
        // GET: PracticeProgram17FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FilePath model,string btnAction)
        {
            if (btnAction == "Submit") {
                ViewBag.result = model.PathFile + " - File Uploaded Successfully!";
            }
            if (btnAction == "Reset") {
                ModelState.Clear();
            }
            return View();
        }
    }
}