using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram8RegisterationFormController : Controller
    {
        // GET: PracticeProgram8RegisterationForm
        public ActionResult Index()
        {
            List<SelectListItem> lstCountry = new List<SelectListItem>();
            lstCountry.Add(new SelectListItem() { 
                Text="India",
                Value="India"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Afghanistan",
                Value = "Afghanistan"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Australia",
                Value = "Australia"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Canada",
                Value = "Canada"
            });
            ViewBag.ddlCountry = lstCountry;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registeration model,string ddlCountry,string btnAction)
        {
            if (btnAction == "Register") {
                Registeration objResult = new Registeration();
                objResult.FirstName = model.FirstName;
                objResult.LastName = model.LastName;
                objResult.BirthDate = model.BirthDate;
                objResult.Address = model.Address;
                objResult.Zipcode = model.Zipcode;
                objResult.Country = ddlCountry;
                ViewBag.result = objResult;
            }   
            if (btnAction == "Reset") {
                ModelState.Clear();
            }
            List<SelectListItem> lstCountry = new List<SelectListItem>();
            lstCountry.Add(new SelectListItem()
            {
                Text = "India",
                Value = "India"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Afghanistan",
                Value = "Afghanistan"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Australia",
                Value = "Australia"
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Canada",
                Value = "Canada"
            });
            ViewBag.ddlCountry = lstCountry;
            return View();
        }
    }
}