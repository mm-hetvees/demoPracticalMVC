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
    public class PracticeProgram25EmploeeTablesController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: PracticeProgram25EmploeeTables
        public ActionResult Index()
        {
            var result = db.EmploeeTables.ToList();
            List<EmployeeData> lstEmployee = new List<EmployeeData>();
            foreach (var item in result)
            {
                EmployeeData objEmployee = new EmployeeData();
                objEmployee.Id = item.Id;
                objEmployee.Name = item.Name;
                objEmployee.DateOfBirth = item.DateOfBirth;
                objEmployee.Address = item.Address;
                objEmployee.ContactNumber = item.ContactNumber;
                objEmployee.City = item.City;
                objEmployee.Country = item.Country;
                lstEmployee.Add(objEmployee);
            }
            return View(lstEmployee);
        }

        // GET: PracticeProgram25EmploeeTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploeeTable emploeeTable = db.EmploeeTables.Find(id);
            EmployeeData employeedata = new EmployeeData();
            employeedata.Id = emploeeTable.Id;
            employeedata.Name = emploeeTable.Name;
            employeedata.DateOfBirth = emploeeTable.DateOfBirth;
            employeedata.Address = emploeeTable.Address;
            employeedata.ContactNumber = emploeeTable.ContactNumber;
            employeedata.City = emploeeTable.City;
            employeedata.Country = emploeeTable.Country;
            if (emploeeTable == null)
            {
                return HttpNotFound();
            }
            return View(employeedata);
        }

        // GET: PracticeProgram25EmploeeTables/Create
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
            ViewBag.City = lstCity;

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
            ViewBag.Country = lstCountry;
            return View();
        }

        // POST: PracticeProgram25EmploeeTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DateOfBirth,Address,ContactNumber,City,Country")] EmploeeTable emploeeTable)
        {

            if (ModelState.IsValid)
            {
                db.EmploeeTables.Add(emploeeTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emploeeTable);
        }

        // GET: PracticeProgram25EmploeeTables/Edit/5
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploeeTable emploeeTable = db.EmploeeTables.Find(id);
            if (emploeeTable == null)
            {
                return HttpNotFound();
            }
            EmployeeData employeedata = new EmployeeData();
            employeedata.Id = emploeeTable.Id;
            employeedata.Name = emploeeTable.Name;
            employeedata.DateOfBirth = emploeeTable.DateOfBirth;
            employeedata.Address = emploeeTable.Address;
            employeedata.ContactNumber = emploeeTable.ContactNumber;
            employeedata.City = emploeeTable.City;
            employeedata.Country = emploeeTable.Country;
            List<SelectListItem> lstCity = new List<SelectListItem>();
            lstCity.Add(new SelectListItem()
            {
                Text = "Ahmedabad",
                Value = "Ahmedabad",
                Selected = employeedata.City == "Ahmedabad" ? true : false
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Canberra",
                Value = "Canberra",
                Selected = employeedata.City == "Canberra" ? true : false
            });
            lstCity.Add(new SelectListItem()
            {
                Text = "Ottawa",
                Value = "Ottawa",
                Selected = employeedata.City == "Ottawa" ? true : false
            });
            ViewBag.City = lstCity;

            List<SelectListItem> lstCountry = new List<SelectListItem>();
            lstCountry.Add(new SelectListItem()
            {
                Text = "India",
                Value = "India",
                Selected = employeedata.Country == "India" ? true : false
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Australia",
                Value = "Australia",
                Selected = employeedata.Country == "Australia" ? true : false
            });
            lstCountry.Add(new SelectListItem()
            {
                Text = "Canada",
                Value = "Canada",
                Selected = employeedata.Country == "Canada" ? true : false
            });
            ViewBag.Country = lstCountry;

            return View(employeedata);
        }

        // POST: PracticeProgram25EmploeeTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DateOfBirth,Address,ContactNumber,City,Country")] EmployeeData employeedata)
        {
            if (ModelState.IsValid)
            {
                EmploeeTable emploeeTable = new EmploeeTable();
                emploeeTable.Id = employeedata.Id;
                emploeeTable.Name = employeedata.Name;
                emploeeTable.DateOfBirth = employeedata.DateOfBirth;
                emploeeTable.Address = employeedata.Address;
                emploeeTable.ContactNumber = employeedata.ContactNumber;
                emploeeTable.City = employeedata.City;
                emploeeTable.Country = employeedata.Country;
                db.Entry(emploeeTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeedata);
        }

        // GET: PracticeProgram25EmploeeTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmploeeTable emploeeTable = db.EmploeeTables.Find(id);
            EmployeeData employeedata = new EmployeeData();
            employeedata.Id = emploeeTable.Id;
            employeedata.Name = emploeeTable.Name;
            employeedata.DateOfBirth = emploeeTable.DateOfBirth;
            employeedata.Address = emploeeTable.Address;
            employeedata.ContactNumber = emploeeTable.ContactNumber;
            employeedata.City = emploeeTable.City;
            employeedata.Country = emploeeTable.Country;
            if (emploeeTable == null)
            {
                return HttpNotFound();
            }
            return View(employeedata);
        }

        // POST: PracticeProgram25EmploeeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmploeeTable emploeeTable = db.EmploeeTables.Find(id);
            db.EmploeeTables.Remove(emploeeTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Operations()
        {
            List<SelectListItem> lstOperations = new List<SelectListItem>();
            lstOperations.Add(new SelectListItem()
            {
                Text = "Create",
                Value = "Create"
            });
            lstOperations.Add(new SelectListItem()
            {
                Text = "Update",
                Value = "Edit"
            });
            lstOperations.Add(new SelectListItem()
            {
                Text = "Delete",
                Value = "Delete"
            });
            ViewBag.ddlOperations = lstOperations;
            return View("Operations");
        }
        public ActionResult OperationByData(string ddlOperations)
        {
            return View();
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
