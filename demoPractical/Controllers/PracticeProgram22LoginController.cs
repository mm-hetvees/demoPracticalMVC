using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram22LoginController : Controller
    {
        private trainingEntities db = new trainingEntities();
        // GET: PracticeProgram22Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User obj,string btnAction)
        {
            if (btnAction == "Submit") {
                if (ModelState.IsValid)
                {
                    var res = db.Users.Where(a => a.UserEmail.Equals(obj.UserEmail) && a.UserPassword.Equals(obj.UserPassword)).FirstOrDefault();
                    if (res != null)
                    {
                        ViewBag.Result = "Logged In Succesfully!!";
                    }
                    else
                    {
                        ViewBag.Result = "Please Check Your EmailId & Password!!";
                    }
                }
            }
            if (btnAction == "Reset") {
                ModelState.Clear();
            }
            return View();
        }

    }
}