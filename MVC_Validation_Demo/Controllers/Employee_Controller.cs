using MVC_Validation_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Validation_Demo.Controllers
{
    public class Employee_Controller : Controller
    {
        // GET: Employee_
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Employee_Class e)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View ("Index");
            }   
        }
    }
}