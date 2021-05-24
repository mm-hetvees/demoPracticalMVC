using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram16RegisterationWithValidationController : Controller
    {
        // GET: PracticeProgram16RegisterationWithValidation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegisterationWithValidation model)
        {
            if (ModelState.IsValid)
            {
                RegisterationWithValidation objResult = new RegisterationWithValidation();
                objResult.FirstName = model.FirstName;
                objResult.LastName = model.LastName;
                objResult.age = model.age;
                objResult.Password = model.Password;
                objResult.ConfirmPassword = model.ConfirmPassword;
                objResult.Email = model.Email;
                ViewBag.result = objResult;
            }
            return View();
        }
    }
}