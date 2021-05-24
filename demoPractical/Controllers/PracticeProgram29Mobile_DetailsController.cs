using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoPractical;

namespace demoPractical.Controllers
{
    public class PracticeProgram29Mobile_DetailsController : Controller
    {
        private trainingEntities db = new trainingEntities();

        // GET: PracticeProgram29Mobile_Details
        public ActionResult Index()
        {
            return View(db.Mobile_Details.ToList());
        }

        // GET: PracticeProgram29Mobile_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile_Details mobile_Details = db.Mobile_Details.Find(id);
            if (mobile_Details == null)
            {
                return HttpNotFound();
            }
            return View(mobile_Details);
        }

        // GET: PracticeProgram29Mobile_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PracticeProgram29Mobile_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ModelName,ModelPrice,ModelImage")] Mobile_Details mobile_Details, HttpPostedFileBase MobileImage)
        {
            if (ModelState.IsValid)
            {
                var allowedExtensions = new[] { ".Jpg", ".png", ".jpg", "jpeg", ".PNG",".JPEG" };
                Mobile_Details mobileData = new Mobile_Details();
                mobileData.ModelName = mobile_Details.ModelName;
                mobileData.ModelPrice = mobile_Details.ModelPrice;
                mobileData.ModelImage = MobileImage.ToString();
                var fileName = Path.GetFileName(MobileImage.FileName);//for fetching fileName
                var fileExtension = Path.GetExtension(MobileImage.FileName);//for fetching extension
                if (allowedExtensions.Contains(fileExtension)) //check what type of extension  
                {
                    string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
                    string myfile = name + fileExtension; 
                    var path = Path.Combine(Server.MapPath("~/Content/Images/"), myfile);
                    mobileData.ModelImage = myfile;
                    db.Mobile_Details.Add(mobileData);
                    db.SaveChanges();
                    MobileImage.SaveAs(path);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.message = "Please choose only Image file";
                }
               ;
            }

            return View(mobile_Details);
        }

        // GET: PracticeProgram29Mobile_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile_Details mobile_Details = db.Mobile_Details.Find(id);
            if (mobile_Details == null)
            {
                return HttpNotFound();
            }
            return View(mobile_Details);
        }

        // POST: PracticeProgram29Mobile_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ModelName,ModelPrice,ModelImage")] Mobile_Details mobile_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mobile_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mobile_Details);
        }

        // GET: PracticeProgram29Mobile_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile_Details mobile_Details = db.Mobile_Details.Find(id);
            if (mobile_Details == null)
            {
                return HttpNotFound();
            }
            return View(mobile_Details);
        }

        // POST: PracticeProgram29Mobile_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mobile_Details mobile_Details = db.Mobile_Details.Find(id);
            db.Mobile_Details.Remove(mobile_Details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FilterData()
        {
            return View("FilterData");
        }
        public ActionResult GetDataOnFilter(int minimumamount,int maximumamount)
        {
            var result = db.Mobile_Details.Where(a => a.ModelPrice >= minimumamount && a.ModelPrice <= maximumamount).ToList();
            return PartialView("_FilterDataDisplay", result);
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
