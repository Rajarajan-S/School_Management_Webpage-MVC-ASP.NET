using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2.Controllers
{
    public class StudentSampleController : Controller
    {
        // GET: StudentSample
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StandardHTMLControls()
        {
            return View();
        }
    }
}