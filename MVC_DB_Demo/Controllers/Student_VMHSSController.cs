using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_DB_Demo.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;

namespace MVC_DB_Demo.Controllers
{
    public class Student_VMHSSController : Controller
    {
        private Vivekananda_SchoolEntities db = new Vivekananda_SchoolEntities();

        // GET: Student_VMHSS
        public ActionResult Index()
        {
            return View(db.Student_VMHSS.ToList());
        }

        // GET: Student_VMHSS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_VMHSS student_VMHSS = db.Student_VMHSS.Find(id);
            if (student_VMHSS == null)
            {
                return HttpNotFound();
            }
            return View(student_VMHSS);
        }

        // GET: Student_VMHSS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_VMHSS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,DOB,Gender,Phone,Address")] Student_VMHSS student_VMHSS)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Student_VMHSS.Add(student_VMHSS);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            return View(student_VMHSS);
        }

        // GET: Student_VMHSS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_VMHSS student_VMHSS = db.Student_VMHSS.Find(id);
            if (student_VMHSS == null)
            {
                return HttpNotFound();
            }
            return View(student_VMHSS);
        }

        // POST: Student_VMHSS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,DOB,Gender,Phone,Address")] Student_VMHSS student_VMHSS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_VMHSS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_VMHSS);
        }

        // GET: Student_VMHSS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_VMHSS student_VMHSS = db.Student_VMHSS.Find(id);
            if (student_VMHSS == null)
            {
                return HttpNotFound();
            }
            return View(student_VMHSS);
        }

        // POST: Student_VMHSS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            Student_VMHSS student_VMHSS = db.Student_VMHSS.Find(id);
            db.Student_VMHSS.Remove(student_VMHSS);
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
