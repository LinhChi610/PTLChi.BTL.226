using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTLChi.BTL._226.Models;
using QLBHDTDD.Models;

namespace PTLChi.BTL._226.Controllers
{
    public class Sp_BanController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Sp_Ban
        public ActionResult Index()
        {
            var sp_Ban = db.Sp_Ban.Include(s => s.SanPhams);
            return View(sp_Ban.ToList());
        }

        // GET: Sp_Ban/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sp_Ban sp_Ban = db.Sp_Ban.Find(id);
            if (sp_Ban == null)
            {
                return HttpNotFound();
            }
            return View(sp_Ban);
        }

        // GET: Sp_Ban/Create
        public ActionResult Create()
        {
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm");
            return View();
        }

        // POST: Sp_Ban/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_sp_ban,ID_sp,So_luong_ban")] Sp_Ban sp_Ban)
        {
            if (ModelState.IsValid)
            {
                db.Sp_Ban.Add(sp_Ban);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", sp_Ban.ID_sp);
            return View(sp_Ban);
        }

        // GET: Sp_Ban/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sp_Ban sp_Ban = db.Sp_Ban.Find(id);
            if (sp_Ban == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", sp_Ban.ID_sp);
            return View(sp_Ban);
        }

        // POST: Sp_Ban/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_sp_ban,ID_sp,So_luong_ban")] Sp_Ban sp_Ban)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sp_Ban).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", sp_Ban.ID_sp);
            return View(sp_Ban);
        }

        // GET: Sp_Ban/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sp_Ban sp_Ban = db.Sp_Ban.Find(id);
            if (sp_Ban == null)
            {
                return HttpNotFound();
            }
            return View(sp_Ban);
        }

        // POST: Sp_Ban/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sp_Ban sp_Ban = db.Sp_Ban.Find(id);
            db.Sp_Ban.Remove(sp_Ban);
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
