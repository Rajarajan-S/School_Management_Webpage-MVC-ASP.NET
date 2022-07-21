using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_DB_Demo.Models;

namespace MVC_DB_Demo.Controllers
{
    public class Enrollment_detailsController : Controller
    {
        private Vivekananda_SchoolEntities db = new Vivekananda_SchoolEntities();

        // GET: Enrollment_details
        public ActionResult Index()
        {
            var enrollment_details = db.Enrollment_details.Include(e => e.Course_details).Include(e => e.Student_VMHSS);
            return View(enrollment_details.ToList());
        }

        // GET: Enrollment_details/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment_details enrollment_details = db.Enrollment_details.Find(id);
            if (enrollment_details == null)
            {
                return HttpNotFound();
            }
            return View(enrollment_details);
        }

        // GET: Enrollment_details/Create
        public ActionResult Create()
        {
            ViewBag.CId = new SelectList(db.Course_details, "Id", "CName");
            ViewBag.sID = new SelectList(db.Student_VMHSS, "Id", "FirstName");
            return View();
        }

        // POST: Enrollment_details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "eId,sID,CId,Adm")] Enrollment_details enrollment_details)
        {
            if (ModelState.IsValid)
            {
                db.Enrollment_details.Add(enrollment_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CId = new SelectList(db.Course_details, "Id", "CName", enrollment_details.CId);
            ViewBag.sID = new SelectList(db.Student_VMHSS, "Id", "FirstName", enrollment_details.sID);
            return View(enrollment_details);
        }

        // GET: Enrollment_details/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment_details enrollment_details = db.Enrollment_details.Find(id);
            if (enrollment_details == null)
            {
                return HttpNotFound();
            }
            ViewBag.CId = new SelectList(db.Course_details, "Id", "CName", enrollment_details.CId);
            ViewBag.sID = new SelectList(db.Student_VMHSS, "Id", "FirstName", enrollment_details.sID);
            return View(enrollment_details);
        }

        // POST: Enrollment_details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "eId,sID,CId,Adm")] Enrollment_details enrollment_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CId = new SelectList(db.Course_details, "Id", "CName", enrollment_details.CId);
            ViewBag.sID = new SelectList(db.Student_VMHSS, "Id", "FirstName", enrollment_details.sID);
            return View(enrollment_details);
        }

        // GET: Enrollment_details/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment_details enrollment_details = db.Enrollment_details.Find(id);
            if (enrollment_details == null)
            {
                return HttpNotFound();
            }
            return View(enrollment_details);
        }

        // POST: Enrollment_details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Enrollment_details enrollment_details = db.Enrollment_details.Find(id);
            db.Enrollment_details.Remove(enrollment_details);
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
