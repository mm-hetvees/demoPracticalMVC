﻿using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram13CompareValidatorController : Controller
    {
        // GET: PracticeProgram13CompareValidator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CompareValidator model, string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    ViewBag.Password = model.Password;
                    ViewBag.ConfirmPassword = model.ConfirmPassword;
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