using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTLChi.BTL._226.Models;

namespace PTLChi.BTL._226.Controllers
{
    public class Danhmuc_spsController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Danhmuc_sps
        public ActionResult Index()
        {
            return View(db.Danhmuc_sps.ToList());
        }

        // GET: Danhmuc_sps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_sp danhmuc_sp = db.Danhmuc_sps.Find(id);
            if (danhmuc_sp == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_sp);
        }

        // GET: Danhmuc_sps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Danhmuc_sps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Danhmuc,Ten_Danhmuc")] Danhmuc_sp danhmuc_sp)
        {
            if (ModelState.IsValid)
            {
                db.Danhmuc_sps.Add(danhmuc_sp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhmuc_sp);
        }

        // GET: Danhmuc_sps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_sp danhmuc_sp = db.Danhmuc_sps.Find(id);
            if (danhmuc_sp == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_sp);
        }

        // POST: Danhmuc_sps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Danhmuc,Ten_Danhmuc")] Danhmuc_sp danhmuc_sp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhmuc_sp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhmuc_sp);
        }

        // GET: Danhmuc_sps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_sp danhmuc_sp = db.Danhmuc_sps.Find(id);
            if (danhmuc_sp == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_sp);
        }

        // POST: Danhmuc_sps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Danhmuc_sp danhmuc_sp = db.Danhmuc_sps.Find(id);
            db.Danhmuc_sps.Remove(danhmuc_sp);
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
