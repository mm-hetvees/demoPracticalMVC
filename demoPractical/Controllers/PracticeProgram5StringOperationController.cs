using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram5StringOperationController : Controller
    {
        // GET: PracticeProgram5StringOperation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(StringOperation model,string radioChoice)
        {
            if (radioChoice == "UpperCase")
            {
                model.result = model.inputString.ToUpper();
            }
            if (radioChoice == "LowerCase")
            {
                model.result = model.inputString.ToLower();
            }
            if (radioChoice == "LeftCharacters")
            {
                model.result = model.inputString.Substring(0,5);
            }
            if (radioChoice == "RightCharacters")
            {
                model.result = model.inputString.Substring(model.inputString.Length-5);
            }
            return View(model);
        }
    }
}