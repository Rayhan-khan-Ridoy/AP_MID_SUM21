using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab1.Models;
using System.ComponentModel.DataAnnotations;
using lab1.Models.Database;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Addstudent()
        {
            Student S = new Student();
            return View(S);
        }

        [HttpPost]
        public ActionResult Addstudent( Student S)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(S);
                return RedirectToAction("Index");
            }
            return View();
           
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}