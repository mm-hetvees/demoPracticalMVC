using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PractceProgram10MarksheetController : Controller
    {
        // GET: PractceProgram10Marksheet
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(MarkSheet model, string btnAction)
        {
            if (btnAction == "Calculate")
            {
                var ans = 0;
                ans = int.Parse(model.WebProgrammingMarks) + int.Parse(model.ComputerNetworkMarks) + int.Parse(model.BuisnessInformationSystemMarks) + int.Parse(model.SystemSoftwareMarks) + int.Parse(model.InformationSecurityMarks);
                ViewBag.total = ans.ToString();
                var percentageVal = ans * 100 / 500;
                ViewBag.percentage = (percentageVal.ToString())+"%";
                if (percentageVal > 80)
                {
                    ViewBag.grade = "A+";
                }
                else if (percentageVal > 70 && percentageVal <= 80)
                {
                    ViewBag.grade = "A";
                }
                else if (percentageVal > 60 && percentageVal <= 70)
                {
                    ViewBag.grade = "B+";
                }
                else if (percentageVal > 50 && percentageVal <= 60)
                {
                    ViewBag.grade = "B";
                }
                else if (percentageVal > 40 && percentageVal <= 50)
                {
                    ViewBag.grade = "C";
                }
                else
                {
                    ViewBag.grade = "D";
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
            }

            return View();
        }
    }
}