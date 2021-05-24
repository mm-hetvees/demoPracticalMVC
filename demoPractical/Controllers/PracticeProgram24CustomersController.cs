using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoPractical;

namespace demoPractical.Controllers
{
    public class PracticeProgram24CustomersController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: PracticeProgram24Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: PracticeProgram24Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: PracticeProgram24Customers/Create
        public ActionResult Create()
        {
            List<SelectListItem> lstCity = new List<SelectListItem>();
            lstCity.Add(new SelectListItem()
            {
                Text = "Ahmedabad",
                Value = "Ahmedabad"
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Canberra",
                Value = "Canberra"
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Ottawa",
                Value = "Ottawa"
            });
            ViewBag.CustomerCity = lstCity;

            List<SelectListItem> lstCountry = new List<SelectListItem>();
            lstCountry.Add(new SelectListItem()
            {
                Text = "India",
                Value = "India"
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
            ViewBag.CustomerCountry = lstCountry;
            return View();
        }

        // POST: PracticeProgram24Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerName,Customeraddress,CustomerContactNo,CustomerCity,CustomerCountry")] Customer customer,string btnAction)
        {
            if (btnAction == "Submit")
            {
                if (ModelState.IsValid)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            if (btnAction == "Reset")
            {
                ModelState.Clear();
                //customer.CustomerName = string.Empty;
                //customer.Customeraddress = string.Empty;
                //customer.CustomerContactNo = string.Empty;
                List<SelectListItem> lstCity = new List<SelectListItem>();
                lstCity.Add(new SelectListItem()
                {
                    Text = "Ahmedabad",
                    Value = "Ahmedabad"
                });
                lstCity.Add(new SelectListItem()
                {
                    Text = "Canberra",
                    Value = "Canberra"
                });
                lstCity.Add(new SelectListItem()
                {
                    Text = "Ottawa",
                    Value = "Ottawa"
                });
                ViewBag.CustomerCity = lstCity;

                List<SelectListItem> lstCountry = new List<SelectListItem>();
                lstCountry.Add(new SelectListItem()
                {
                    Text = "India",
                    Value = "India"
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
                ViewBag.CustomerCountry = lstCountry;
                return View();
            }

            
            return View(customer);
        }

        // GET: PracticeProgram24Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: PracticeProgram24Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerName,Customeraddress,CustomerContactNo,CustomerCity,CustomerCountry")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: PracticeProgram24Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: PracticeProgram24Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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
