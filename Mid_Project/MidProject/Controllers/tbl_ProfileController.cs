using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MidProject.Models;

namespace MidProject.Controllers
{
 
    
    public class tbl_ProfileController : Controller
    {
        private FOOTBALLEntities1 db = new FOOTBALLEntities1();

        // GET: tbl_Profile
        [Authorize]
        public ActionResult Index()
        {
            var tbl_Profile = db.tbl_Profile.Include(t => t.tbl_Performance);
            return View(tbl_Profile.ToList());
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration( tbl_Login tbl_Login)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Login.Add(tbl_Login);
                db.SaveChanges();
                return RedirectToAction("tbl_Login");
            }

            
            return View(tbl_Login);
        }
        public ActionResult tbl_Login()
        {
        
                return View();
            
        }
       
        [HttpPost]
        
        public ActionResult tbl_Login(tbl_Login lg, string ReturnUrl)
        {
            var user = db.tbl_Login.Where(x => x.Username==lg.Username && x.Password==lg.Password ).Count();
            if (user>0)
            {
                var Username = lg.Username.ToString();
                FormsAuthentication.SetAuthCookie("Username", false);


                Session["Username"] = lg.Username.ToString();
                ////return RedirectToAction("Index");
                return Redirect(ReturnUrl);
            }
            else
            {

                return View();
            }
  
        }
        // GET: tbl_Profile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Profile tbl_Profile = db.tbl_Profile.Find(id);
            if (tbl_Profile == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Profile);
        }

        // GET: tbl_Profile/Create
        public ActionResult Create()
        {

            //ViewBag.RankId = new SelectList(db.tbl_Performance, "RankId", "RankName");
            var ranklist = db.tbl_Performance.ToList();
            ViewBag.RankList = new SelectList(ranklist, "RankId", "RankName");
            return View();
        }

        // POST: tbl_Profile/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Nationality,CurrentTeam,Height,Weight,RankId")] tbl_Profile tbl_Profile)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Profile.Add(tbl_Profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RankId = new SelectList(db.tbl_Performance, "RankId", "RankName", tbl_Profile.RankId);
            return View(tbl_Profile);
        }

        // GET: tbl_Profile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Profile tbl_Profile = db.tbl_Profile.Find(id);
            if (tbl_Profile == null)
            {
                return HttpNotFound();
            }
            ViewBag.RankId = new SelectList(db.tbl_Performance, "RankId", "RankName", tbl_Profile.RankId);
            return View(tbl_Profile);
        }

        // POST: tbl_Profile/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Nationality,CurrentTeam,Height,Weight,RankId")] tbl_Profile tbl_Profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RankId = new SelectList(db.tbl_Performance, "RankId", "RankName", tbl_Profile.RankId);
            return View(tbl_Profile);
        }

        // GET: tbl_Profile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Profile tbl_Profile = db.tbl_Profile.Find(id);
            if (tbl_Profile == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Profile);
        }

        // POST: tbl_Profile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Profile tbl_Profile = db.tbl_Profile.Find(id);
            db.tbl_Profile.Remove(tbl_Profile);
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

        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("tbl_Login");
        }
    }
}
