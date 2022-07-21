using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBinding_Ex.Models;

namespace DataBinding_Ex.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stulist = new List<Student>()
            {
                new Student(){ Id=1, Name="Raja", Email="raja@gmail.com", Department="AE"},
                new Student(){ Id=2, Name="Aswath", Email="aswath@gmail.com", Department="CSE"},
                new Student(){ Id=3, Name="Mani", Email="mani@gmail.com", Department="IT"},
                new Student(){ Id=4, Name="Karthi", Email="karthi@gmail.com", Department="ECE"},
                new Student(){ Id=4, Name="Surya", Email="surya@gmail.com", Department="EEE"},
            };
            return View(stulist);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}