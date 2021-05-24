using demoPractical.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace demoPractical.Controllers
{
    public class PracticeProgram27EmployeeDepartmentsController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: PracticeProgram27EmployeeDepartments
        public ActionResult Index()
        {
            var result = db.EmployeeDepartments.ToList();
            List<EmployeeDepartmentData> lstEmployee = new List<EmployeeDepartmentData>();
            foreach (var item in result)
            {
                EmployeeDepartmentData objEmployee = new EmployeeDepartmentData();
                objEmployee.Id = item.Id;
                objEmployee.Name = item.Name;
                objEmployee.Job = item.Job;
                objEmployee.HireDate = item.HireDate;
                objEmployee.Salary = item.Salary;
                objEmployee.Commision = item.Commision;
                objEmployee.DepartmentName = item.DepartmentName;
                lstEmployee.Add(objEmployee);
            }
            return View(lstEmployee);
        }

        // GET: PracticeProgram27EmployeeDepartments/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDepartment employeeDepartment = db.EmployeeDepartments.Find(id);
            EmployeeDepartmentData objEmployee = new EmployeeDepartmentData();
            objEmployee.Id = employeeDepartment.Id;
            objEmployee.Name = employeeDepartment.Name;
            objEmployee.Job = employeeDepartment.Job;
            objEmployee.HireDate = employeeDepartment.HireDate;
            objEmployee.Salary = employeeDepartment.Salary;
            objEmployee.Commision = employeeDepartment.Commision;
            objEmployee.DepartmentName = employeeDepartment.DepartmentName;
            if (employeeDepartment == null)
            {
                return HttpNotFound();
            }
            return View(objEmployee);
        }

        // GET: PracticeProgram27EmployeeDepartments/Create
        public ActionResult Create()
        {
            List<SelectListItem> lstJob = new List<SelectListItem>();
            lstJob.Add(new SelectListItem()
            {
                Text = "Manager",
                Value = "Manager"
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Developer",
                Value = "Developer"
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Business Analyst",
                Value = "Business Analyst"
            });
            ViewBag.Job = lstJob;
            List<SelectListItem> lstDepartmentName = new List<SelectListItem>();
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "Accounting",
                Value = "Accounting"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "IT",
                Value = "IT"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "HR",
                Value = "HR"
            });
            ViewBag.DepartmentName = lstDepartmentName;
            return View();
        }

        // POST: PracticeProgram27EmployeeDepartments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Job,HireDate,Salary,Commision,DepartmentName")] EmployeeDepartment employeeDepartment)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDepartments.Add(employeeDepartment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeDepartment);
        }

        // GET: PracticeProgram27EmployeeDepartments/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDepartment employeeDepartment = db.EmployeeDepartments.Find(id);
            EmployeeDepartmentData objEmployee = new EmployeeDepartmentData();
            objEmployee.Id = employeeDepartment.Id;
            objEmployee.Name = employeeDepartment.Name;
            objEmployee.Job = employeeDepartment.Job;
            objEmployee.HireDate = employeeDepartment.HireDate;
            objEmployee.Salary = employeeDepartment.Salary;
            objEmployee.Commision = employeeDepartment.Commision;
            objEmployee.DepartmentName = employeeDepartment.DepartmentName;
            List<SelectListItem> lstJob = new List<SelectListItem>();
            lstJob.Add(new SelectListItem()
            {
                Text = "Manager",
                Value = "Manager",
                Selected = objEmployee.Job == "Manager" ? true : false
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Developer",
                Value = "Developer",
                Selected = objEmployee.Job == "Developer" ? true : false
            });
            lstJob.Add(new SelectListItem()
            {
                Text = "Business Analyst",
                Value = "Business Analyst",
                Selected = objEmployee.Job == "Business Analyst" ? true : false
            });
            ViewBag.Job = lstJob;
            List<SelectListItem> lstDepartmentName = new List<SelectListItem>();
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "Accounting",
                Value = "Accounting",
                Selected = objEmployee.Job == "Accounting" ? true : false
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "IT",
                Value = "IT",
                Selected = objEmployee.Job == "IT" ? true : false
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "HR",
                Value = "HR",
                Selected = objEmployee.Job == "HR" ? true : false
            });
            ViewBag.DepartmentName = lstDepartmentName;
            if (employeeDepartment == null)
            {
                return HttpNotFound();
            }
            return View(objEmployee);
        }

        // POST: PracticeProgram27EmployeeDepartments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Job,HireDate,Salary,Commision,DepartmentName")] EmployeeDepartmentData employeeDepartmentData)
        {
            if (ModelState.IsValid)
            {
                EmployeeDepartment employeeDepartment = new EmployeeDepartment();
                employeeDepartment.Id = employeeDepartmentData.Id;
                employeeDepartment.Name = employeeDepartmentData.Name;
                employeeDepartment.Job = employeeDepartmentData.Job;
                employeeDepartment.HireDate = employeeDepartmentData.HireDate;
                employeeDepartment.Salary = employeeDepartmentData.Salary;
                employeeDepartment.Commision = employeeDepartmentData.Commision;
                employeeDepartment.DepartmentName = employeeDepartmentData.DepartmentName;
                db.Entry(employeeDepartment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeDepartmentData);
        }

        // GET: PracticeProgram27EmployeeDepartments/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDepartment employeeDepartment = db.EmployeeDepartments.Find(id);
            EmployeeDepartmentData objEmployee = new EmployeeDepartmentData();
            objEmployee.Id = employeeDepartment.Id;
            objEmployee.Name = employeeDepartment.Name;
            objEmployee.Job = employeeDepartment.Job;
            objEmployee.HireDate = employeeDepartment.HireDate;
            objEmployee.Salary = employeeDepartment.Salary;
            objEmployee.Commision = employeeDepartment.Commision;
            objEmployee.DepartmentName = employeeDepartment.DepartmentName;
            if (employeeDepartment == null)
            {
                return HttpNotFound();
            }
            return View(objEmployee);
        }

        // POST: PracticeProgram27EmployeeDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EmployeeDepartment employeeDepartment = db.EmployeeDepartments.Find(id);
            db.EmployeeDepartments.Remove(employeeDepartment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmentWiseData()
        {
            List<SelectListItem> lstDepartmentName = new List<SelectListItem>();
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "Accounting",
                Value = "Accounting"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "IT",
                Value = "IT"
            });
            lstDepartmentName.Add(new SelectListItem()
            {
                Text = "HR",
                Value = "HR"
            });
            ViewBag.DepartmentName = lstDepartmentName;
            return View("DepartmentWiseData");
        }
        public ActionResult GetDataDepartmentWise(string departmentName) {
            var result = db.EmployeeDepartments.Where(a =>a.DepartmentName  == departmentName).ToList();
            return PartialView("_DeparrmentWiseData", result);
        }

        public ActionResult EmployeeDataOnSelect(int ?id)
        {
            var result = db.EmployeeDepartments.ToList().ToPagedList(id ?? 1,3);
            return View(result);
        }

        public ActionResult GetData(string id)
        {
            var result = db.EmployeeDepartments.Where(a => a.Id == id).FirstOrDefault();
            ViewBag.partialViewData = result;
            return PartialView("_DisplayData", result);
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
