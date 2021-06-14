using System;
using lab1.Models;
using lab1.Models.Database;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            Admin A = new Admin();
            return View(A);
        }

        public ActionResult Admin(Admin A)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Admins.Insert(A);
               
            }
            return View();
        }
    }
}