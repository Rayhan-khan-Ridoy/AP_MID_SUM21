using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MidProject.Models;

namespace MidProject.Controllers
{
    public class tbl_PerformanceController : Controller
    {
        private FOOTBALLEntities1 db = new FOOTBALLEntities1();

        // GET: tbl_Performance
        [Authorize]
        public ActionResult Index()
        {
            return View(db.tbl_Performance.ToList());
        }

        // GET: tbl_Performance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Performance tbl_Performance = db.tbl_Performance.Find(id);
            if (tbl_Performance == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Performance);
        }

        // GET: tbl_Performance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Performance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RankId,RankName,Goals,RedCards,YellowCards,Year")] tbl_Performance tbl_Performance)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Performance.Add(tbl_Performance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Performance);
        }

        // GET: tbl_Performance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Performance tbl_Performance = db.tbl_Performance.Find(id);
            if (tbl_Performance == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Performance);
        }

        // POST: tbl_Performance/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RankId,RankName,Goals,RedCards,YellowCards,Year")] tbl_Performance tbl_Performance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Performance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Performance);
        }

        // GET: tbl_Performance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Performance tbl_Performance = db.tbl_Performance.Find(id);
            if (tbl_Performance == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Performance);
        }

        // POST: tbl_Performance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Performance tbl_Performance = db.tbl_Performance.Find(id);
            db.tbl_Performance.Remove(tbl_Performance);
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
