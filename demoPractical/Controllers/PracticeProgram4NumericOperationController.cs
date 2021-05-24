using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram4NumericOperationController : Controller
    {
        // GET: PracticeProgram4NumericOperation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(NumericOperation model,string radioChoice)
        {
            if(radioChoice== "Odd Or Even")
            {
                if(model.no % 2 == 0)
                {
                    model.result = "Entered Number Is Even!";
                }
                else
                {
                    model.result = "Entered Number Is Odd!";
                }
            }
            if (radioChoice == "Positive Or Negative")
            {
                if (model.no < 0)
                {
                    model.result = "Entered Number Is Negative!";
                }
                else
                {
                    model.result = "Entered Number Is Positive!";
                }
            }
            if (radioChoice == "Square")
            {
                int ans = model.no * model.no;
                model.result = "Square of Entered Number Is : " + ans.ToString();
            }
            if (radioChoice == "Factorial")
            {
                int fact = 1;
                while(model.no > 0)
                {
                    fact = fact * model.no;
                    model.no--;
                }
                model.result = "Factorial of Entered Number Is : " + fact.ToString();
            }
            return View(model);
        }
    }
}