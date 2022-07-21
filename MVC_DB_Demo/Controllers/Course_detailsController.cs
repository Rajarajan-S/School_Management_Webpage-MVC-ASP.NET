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
    public class Course_detailsController : Controller
    {
        private Vivekananda_SchoolEntities db = new Vivekananda_SchoolEntities();

        // GET: Course_details
        public ActionResult Index()
        {
            return View(db.Course_details.ToList());
        }

        // GET: Course_details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_details course_details = db.Course_details.Find(id);
            if (course_details == null)
            {
                return HttpNotFound();
            }
            return View(course_details);
        }

        // GET: Course_details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course_details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CName,CSub,CDuration")] Course_details course_details)
        {
            if (ModelState.IsValid)
            {
                db.Course_details.Add(course_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course_details);
        }

        // GET: Course_details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_details course_details = db.Course_details.Find(id);
            if (course_details == null)
            {
                return HttpNotFound();
            }
            return View(course_details);
        }

        // POST: Course_details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CName,CSub,CDuration")] Course_details course_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course_details);
        }

        // GET: Course_details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_details course_details = db.Course_details.Find(id);
            if (course_details == null)
            {
                return HttpNotFound();
            }
            return View(course_details);
        }

        // POST: Course_details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course_details course_details = db.Course_details.Find(id);
            db.Course_details.Remove(course_details);
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
