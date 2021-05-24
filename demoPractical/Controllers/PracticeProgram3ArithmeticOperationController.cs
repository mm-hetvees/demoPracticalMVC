using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram3ArithmeticOperationController : Controller
    {
        // GET: PracticeProgram3ArithmeticOperation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ArithemeticOperation model,string operation)
        {
            if (operation == "+")
            {
                model.ans = model.no1 + model.no2;
            }
            if (operation == "-")
            {
                model.ans = model.no1 - model.no2;
            }
            if (operation == "*")
            {
                model.ans = model.no1 * model.no2;
            }
            if (operation == "/")
            {
                if (model.no1 != 0 && model.no2 != 0)
                {
                    model.ans = model.no1 / model.no2;
                }
            }
            return View(model);
        }
    }
}