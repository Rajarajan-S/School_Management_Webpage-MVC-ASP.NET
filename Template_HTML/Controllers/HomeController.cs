
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template_HTML.Models;


namespace Template_HTML.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeModel emp = new EmployeeModel()
            {
                Id = 1,
                Name = "Rajarajan",
                Email = "rajarajan@gmail.com",
                DOB = DateTime.Now,
                IsOnline = true,
            };

            ViewData["empdata"] = emp;
            return View(emp);
        }
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel e)
        {
            return View();
        }

    }
}