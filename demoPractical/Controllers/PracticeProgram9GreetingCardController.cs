using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram9GreetingCardController : Controller
    {
        // GET: PracticeProgram9GreetingCard
        public ActionResult Index()
        {
            List<SelectListItem> lstColour = new List<SelectListItem>();
            lstColour.Add(new SelectListItem()
            {
                Text = "Black",
                Value = "black"
            });
            lstColour.Add(new SelectListItem()
            {
                Text = "Pink",
                Value = "pink"
            });
            lstColour.Add(new SelectListItem()
            {
                Text = "Red",
                Value = "red"
            });
            lstColour.Add(new SelectListItem()
            {
                Text = "Yellow",
                Value = "yellow"
            });
            ViewBag.ddlColour = lstColour;

            List<SelectListItem> lstFontStyle = new List<SelectListItem>();
            lstFontStyle.Add(new SelectListItem()
            {
                Text = "Arial",
                Value = "Arial"
            });
            lstFontStyle.Add(new SelectListItem()
            {
                Text = "Comic Sans MS",
                Value = "Comic Sans MS"
            });
            lstFontStyle.Add(new SelectListItem()
            {
                Text = "Lucida Console",
                Value = "Lucida Console"
            });
            ViewBag.ddlFontStyle = lstFontStyle;
            return View();
        }
        [HttpPost]
        public ActionResult Index(GreetingCard model,string ddlColour,string ddlFontStyle,string chkPictureChoice)
        {
            GreetingCard objResult = new GreetingCard();
            objResult.colour = ddlColour;
            objResult.fontStyle = ddlFontStyle;
            objResult.fontSize = model.fontSize + "px";
            objResult.borderStyle = model.borderStyle;
            objResult.pictureChoice = chkPictureChoice;
            objResult.message = model.message;
            ViewBag.result = objResult;

            if (ViewBag.result.pictureChoice == "true")
            {
                ViewBag.pictureURL = "~/Content/Images/waterlilis.jpg";
            }
            List<SelectListItem> lstColour = new List<SelectListItem>();
            lstColour.Add(new SelectListItem()
            {
                Text = "Black",
                Value = "black"
            });
            lstColour.Add(new SelectListItem()
            {
                Text = "Pink",
                Value = "pink"
            });
            lstColour.Add(new SelectListItem()
            {
                Text = "Red",
                Value = "red"
            });
            lstColour.Add(new SelectListItem()
            {
                Text = "Yellow",
                Value = "yellow"
            });
            ViewBag.ddlColour = lstColour;

            List<SelectListItem> lstFontStyle = new List<SelectListItem>();
            lstFontStyle.Add(new SelectListItem()
            {
                Text = "Arial",
                Value = "Arial"
            });
            lstFontStyle.Add(new SelectListItem()
            {
                Text = "Comic Sans MS",
                Value = "Comic Sans MS"
            });
            lstFontStyle.Add(new SelectListItem()
            {
                Text = "Lucida Console",
                Value = "Lucida Console"
            });
            ViewBag.ddlFontStyle = lstFontStyle;
            return View();
        }
    }
}