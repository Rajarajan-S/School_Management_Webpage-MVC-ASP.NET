using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;

namespace MVC_CodeFirst.Controllers
{
    public class DetailsClassesController : Controller
    {
        private DetailsDBcontext db = new DetailsDBcontext();

        // GET: DetailsClasses
        public ActionResult Index()
        {
            return View(db.details.ToList());
        }

        // GET: DetailsClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsClass detailsClass = db.details.Find(id);
            if (detailsClass == null)
            {
                return HttpNotFound();
            }
            return View(detailsClass);
        }

        // GET: DetailsClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetailsClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,City,Email,Phone")] DetailsClass detailsClass)
        {
            if (ModelState.IsValid)
            {
                db.details.Add(detailsClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detailsClass);
        }

        // GET: DetailsClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsClass detailsClass = db.details.Find(id);
            if (detailsClass == null)
            {
                return HttpNotFound();
            }
            return View(detailsClass);
        }

        // POST: DetailsClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,City,Email,Phone")] DetailsClass detailsClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detailsClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detailsClass);
        }

        // GET: DetailsClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsClass detailsClass = db.details.Find(id);
            if (detailsClass == null)
            {
                return HttpNotFound();
            }
            return View(detailsClass);
        }

        // POST: DetailsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetailsClass detailsClass = db.details.Find(id);
            db.details.Remove(detailsClass);
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
