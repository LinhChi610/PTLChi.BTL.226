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
    public class Chitiet_dhController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Chitiet_DH
        public ActionResult Index()
        {
            var chitiet_DH = db.Chitiet_DH.Include(c => c.SanPhams);
            return View(chitiet_DH.ToList());
        }

        // GET: Chitiet_DH/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_DH = db.Chitiet_DH.Find(id);
            if (chitiet_DH == null)
            {
                return HttpNotFound();
            }
            return View(chitiet_DH);
        }

        // GET: Chitiet_DH/Create
        public ActionResult Create()
        {
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm");
            return View();
        }

        // POST: Chitiet_DH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ct_hd,ID_hd,ID_sp,So_luong_mua,Don_gia")] Chitiet_dh chitiet_DH)
        {
            if (ModelState.IsValid)
            {
                db.Chitiet_DH.Add(chitiet_DH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", chitiet_DH.ID_sp);
            return View(chitiet_DH);
        }

        // GET: Chitiet_DH/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_DH = db.Chitiet_DH.Find(id);
            if (chitiet_DH == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", chitiet_DH.ID_sp);
            return View(chitiet_DH);
        }

        // POST: Chitiet_DH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ct_hd,ID_hd,ID_sp,So_luong_mua,Don_gia")] Chitiet_dh chitiet_DH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chitiet_DH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", chitiet_DH.ID_sp);
            return View(chitiet_DH);
        }

        // GET: Chitiet_DH/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_DH = db.Chitiet_DH.Find(id);
            if (chitiet_DH == null)
            {
                return HttpNotFound();
            }
            return View(chitiet_DH);
        }

        // POST: Chitiet_DH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chitiet_dh chitiet_DH = db.Chitiet_DH.Find(id);
            db.Chitiet_DH.Remove(chitiet_DH);
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
