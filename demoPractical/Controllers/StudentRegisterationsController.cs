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
    public class StudentRegisterationsController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: StudentRegisterations
        public ActionResult Index()
        {
            return View(db.StudentRegisterations.ToList());
        }

        // GET: StudentRegisterations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentRegisteration studentRegisteration = db.StudentRegisterations.Find(id);
            if (studentRegisteration == null)
            {
                return HttpNotFound();
            }
            return View(studentRegisteration);
        }

        // GET: StudentRegisterations/Create
        public ActionResult Create()
        {
            List<SelectListItem> lstCourseName = new List<SelectListItem>();
            lstCourseName.Add(new SelectListItem()
            {
                Text = "BTech",
                Value = "BTech"
            });
            lstCourseName.Add(new SelectListItem()
            {
                Text = "MTech",
                Value = "MTech"
            });
            lstCourseName.Add(new SelectListItem()
            {
                Text = "BCA",
                Value = "BCA"
            });
            lstCourseName.Add(new SelectListItem()
            {
                Text = "MCA",
                Value = "MCA"
            });
            lstCourseName.Add(new SelectListItem()
            {
                Text = "BSCIT",
                Value = "BSCIT"
            });
            lstCourseName.Add(new SelectListItem()
            {
                Text = "MSCIT",
                Value = "MSCIT"
            });
            ViewBag.CourseName = lstCourseName;

            List<SelectListItem> lstSemester = new List<SelectListItem>();
            lstSemester.Add(new SelectListItem()
            {
                Text = "First Semester",
                Value = "First Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "Second Semester",
                Value = "Second Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "Third Semester",
                Value = "Third Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "Fourth Semester",
                Value = "Fourth Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "Fifth Semester",
                Value = "Fifth Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "Sixth Semester",
                Value = "Sixth Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "PG First Semester",
                Value = "PG First Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "PG Second Semester",
                Value = "PG Second Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "PG Third Semester",
                Value = "PG Third Semester"
            });
            lstSemester.Add(new SelectListItem()
            {
                Text = "PG Fourth Semester",
                Value = "PG Fourth Semester"
            });
            ViewBag.Semester = lstSemester;

            List<SelectListItem> lstDivision = new List<SelectListItem>();
            lstDivision.Add(new SelectListItem()
            {
                Text = "A",
                Value = "A"
            });
            lstDivision.Add(new SelectListItem()
            {
                Text = "B",
                Value = "B"
            });
            lstDivision.Add(new SelectListItem()
            {
                Text = "C",
                Value = "C"
            });
            ViewBag.Division = lstDivision;

            List<SelectListItem> lstBloodGroup = new List<SelectListItem>();
            lstBloodGroup.Add(new SelectListItem()
            {
                Text = "A+",
                Value = "A+"
            });
            lstBloodGroup.Add(new SelectListItem()
            {
                Text = "A-",
                Value = "A-"
            });
            lstBloodGroup.Add(new SelectListItem()
            {
                Text = "B+",
                Value = "B+"
            });
            lstBloodGroup.Add(new SelectListItem()
            {
                Text = "B-",
                Value = "B-"
            });
            lstBloodGroup.Add(new SelectListItem()
            {
                Text = "AB+",
                Value = "AB+"
            });
            lstBloodGroup.Add(new SelectListItem()
            {
                Text = "AB-",
                Value = "AB-"
            });
            ViewBag.BloodGroup = lstBloodGroup;

            List<SelectListItem> lstReligion = new List<SelectListItem>();
            lstReligion.Add(new SelectListItem()
            {
                Text = "Hindu",
                Value = "Hindu"
            });
            lstReligion.Add(new SelectListItem()
            {
                Text = "Islam",
                Value = "Islam"
            });
            lstReligion.Add(new SelectListItem()
            {
                Text = "Jainism",
                Value = "Jainism"
            });
            lstReligion.Add(new SelectListItem()
            {
                Text = "Buddhism",
                Value = "Buddhism"
            });
            ViewBag.Region = lstReligion;

            List<SelectListItem> lstCategory = new List<SelectListItem>();
            lstCategory.Add(new SelectListItem()
            {
                Text = "General",
                Value = "General"
            });
            lstCategory.Add(new SelectListItem()
            {
                Text = "Open",
                Value = "Open"
            });
            lstCategory.Add(new SelectListItem()
            {
                Text = "OBC",
                Value = "OBC"
            });
            lstCategory.Add(new SelectListItem()
            {
                Text = "SC",
                Value = "SC"
            });
            ViewBag.Category = lstCategory;

            List<SelectListItem> lstCast = new List<SelectListItem>();
            lstCast.Add(new SelectListItem()
            {
                Text = "Brahmins",
                Value = "Brahmins"
            });
            lstCast.Add(new SelectListItem()
            {
                Text = "Kshatriya",
                Value = "Kshatriya"
            });
            lstCast.Add(new SelectListItem()
            {
                Text = "Vaishya",
                Value = "Vaishya"
            });
            lstCast.Add(new SelectListItem()
            {
                Text = "Shudra",
                Value = "Shudra"
            });
            ViewBag.Cast = lstCast;

            List<SelectListItem> lstQuota = new List<SelectListItem>();
            lstQuota.Add(new SelectListItem()
            {
                Text = "Open",
                Value = "Open"
            });
            lstQuota.Add(new SelectListItem()
            {
                Text = "General",
                Value = "General"
            });
            lstQuota.Add(new SelectListItem()
            {
                Text = "Govt.",
                Value = "Govt."
            });
            ViewBag.Quota = lstQuota;

            List<SelectListItem> lstFeeStructure = new List<SelectListItem>();
            lstFeeStructure.Add(new SelectListItem()
            {
                Text = "For BTech",
                Value = "For BTech"
            });
            lstFeeStructure.Add(new SelectListItem()
            {
                Text = "For MTech",
                Value = "For MTech"
            });
            lstFeeStructure.Add(new SelectListItem()
            {
                Text = "For BCA",
                Value = "For BCA"
            });
            lstFeeStructure.Add(new SelectListItem()
            {
                Text = "For MCA",
                Value = "For MCA"
            });
            lstFeeStructure.Add(new SelectListItem()
            {
                Text = "For BSCIT",
                Value = "For BSCIT"
            });
            lstFeeStructure.Add(new SelectListItem()
            {
                Text = "For MSCIT",
                Value = "For MSCIT"
            });
            ViewBag.FeeStructure = lstFeeStructure;

            List<SelectListItem> lstFeesConcession = new List<SelectListItem>();
            lstFeesConcession.Add(new SelectListItem()
            {
                Text = "Yes",
                Value = "true"
            });
            lstFeesConcession.Add(new SelectListItem()
            {
                Text = "No",
                Value = "false"
            });
            ViewBag.FeesConcession = lstFeesConcession;

            List<SelectListItem> lstHostelName = new List<SelectListItem>();
            lstHostelName.Add(new SelectListItem()
            {
                Text = "Gujarat University",
                Value = "Gujarat University"
            });
            lstHostelName.Add(new SelectListItem()
            {
                Text = "Ahmedabad University",
                Value = "Ahmedabad University"
            });
            lstHostelName.Add(new SelectListItem()
            {
                Text = "Allen",
                Value = "Allen"
            });
            ViewBag.HostelName = lstHostelName;
            return View();
        }

        // POST: StudentRegisterations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdmissionNo,AdmissionDate,ApplicationFormNo,CourseName,Semester,Division,FirstName,MiddleName,LastName,DateOfBirth,Gender,FatherName,Occupation,MotherName,AnnualIncome,Nationality,Region,BloodGroup,Category,Cast,Quota,FeesConcession,FeeStructure,MobileNumber,ParentMobileNumber,Address,Percentage10th,Percentage12th,TrasportationCost,HostelName,Marksheet10th,Marksheet12th,SchoolLeaving,ProfilePicture")] StudentRegisteration studentRegisteration)
        {
            if (ModelState.IsValid)
            {
                db.StudentRegisterations.Add(studentRegisteration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentRegisteration);
        }

        // GET: StudentRegisterations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentRegisteration studentRegisteration = db.StudentRegisterations.Find(id);
            if (studentRegisteration == null)
            {
                return HttpNotFound();
            }
            return View(studentRegisteration);
        }

        // POST: StudentRegisterations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdmissionNo,AdmissionDate,ApplicationFormNo,CourseName,Semester,Division,FirstName,MiddleName,LastName,DateOfBirth,Gender,FatherName,Occupation,MotherName,AnnualIncome,Nationality,Region,BloodGroup,Category,Cast,Quota,FeesConcession,FeeStructure,MobileNumber,ParentMobileNumber,Address,Percentage10th,Percentage12th,TrasportationCost,HostelName,Marksheet10th,Marksheet12th,SchoolLeaving,ProfilePicture")] StudentRegisteration studentRegisteration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentRegisteration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentRegisteration);
        }

        // GET: StudentRegisterations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentRegisteration studentRegisteration = db.StudentRegisterations.Find(id);
            if (studentRegisteration == null)
            {
                return HttpNotFound();
            }
            return View(studentRegisteration);
        }

        // POST: StudentRegisterations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentRegisteration studentRegisteration = db.StudentRegisterations.Find(id);
            db.StudentRegisterations.Remove(studentRegisteration);
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
