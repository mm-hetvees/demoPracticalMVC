using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoPractical;
using demoPractical.Models;

namespace demoPractical.Controllers
{
    public class PracticeProgram23SignUpController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: PracticeProgram23SignUp
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: PracticeProgram23SignUp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: PracticeProgram23SignUp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PracticeProgram23SignUp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,UserPassword,RetypePassword,BirthDate,Gender,UserEmail")] UserDataModel userData, string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    User user = new User();
                    user.FirstName = userData.FirstName;
                    user.LastName = userData.LastName;
                    if (userData.UserPassword == userData.RetypePassword)
                    {
                        user.UserPassword = userData.UserPassword;
                    }
                    user.BirthDate = userData.BirthDate;
                    user.Gender = userData.Gender;
                    user.UserEmail = userData.UserEmail;
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
                return View();
            }

            return View();
        }

        // GET: PracticeProgram23SignUp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: PracticeProgram23SignUp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,UserPassword,BirthDate,Gender,UserEmail")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: PracticeProgram23SignUp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: PracticeProgram23SignUp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
