using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Name"] = "Nguyen Duc Hung";
            TempData["Age"] = "27 years old";
            TempData["Address"] = "Ha Noi";
            return RedirectToAction("Showdata");
            //return View();
        }

        public ActionResult ShowData()
        {
            //return RedirectToAction("Index");
            return View();
        }
    }
}