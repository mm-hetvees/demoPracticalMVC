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
    public class PracticeProgram26ClientsController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: PracticeProgram26Clients
        public ActionResult Index()
        {
            return View(db.Clients.ToList());
        }

        // GET: PracticeProgram26Clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: PracticeProgram26Clients/Create
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
                Text = "Patna",
                Value = "Patna"
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Mumbai",
                Value = "Mumbai"
            });
            ViewBag.City = lstCity;

            List<SelectListItem> lstState = new List<SelectListItem>();
            lstState.Add(new SelectListItem()
            {
                Text = "Gujarat",
                Value = "Gujarat"
            });
            lstState.Add(new SelectListItem()
            {
                Text = "Bihar",
                Value = "Bihar"
            });
            lstState.Add(new SelectListItem()
            {
                Text = "Maharashtra",
                Value = "Maharashtra"
            });
            ViewBag.State = lstState;
            return View();
        }

        // POST: PracticeProgram26Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientNumber,ClientName,Address,City,State,Pincode")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: PracticeProgram26Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            List<SelectListItem> lstCity = new List<SelectListItem>();
            lstCity.Add(new SelectListItem()
            {
                Text = "Ahmedabad",
                Value = "Ahmedabad",
                Selected = client.City == "Ahmedabad" ? true : false
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Patna",
                Value = "Patna",
                Selected = client.City == "Patna" ? true : false
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Mumbai",
                Value = "Mumbai",
                Selected = client.City == "Mumbai" ? true : false
            });
            ViewBag.City = lstCity;

            List<SelectListItem> lstState = new List<SelectListItem>();
            lstState.Add(new SelectListItem()
            {
                Text = "Gujarat",
                Value = "Gujarat",
                Selected = client.State == "Gujarat" ? true : false
            });
            lstState.Add(new SelectListItem()
            {
                Text = "Bihar",
                Value = "Bihar",
                Selected = client.State == "Bihar" ? true : false
            });
            lstState.Add(new SelectListItem()
            {
                Text = "Maharashtra",
                Value = "Maharashtra",
                Selected = client.State == "Maharashtra" ? true : false
            });
            ViewBag.State = lstState;
            return View(client);
        }

        // POST: PracticeProgram26Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientNumber,ClientName,Address,City,State,Pincode")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: PracticeProgram26Clients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: PracticeProgram26Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Clients.Find(id);
            db.Clients.Remove(client);
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
