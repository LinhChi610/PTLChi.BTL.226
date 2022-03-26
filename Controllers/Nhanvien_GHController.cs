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
    public class Nhanvien_GHController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Nhanvien_GH
        public ActionResult Index()
        {
            return View(db.Nhanvien_GH.ToList());
        }

        // GET: Nhanvien_GH/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GH.Find(id);
            if (nhanvien_GH == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien_GH);
        }

        // GET: Nhanvien_GH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nhanvien_GH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_nvgh,Ten_nvgh,Sdt_1,Sdt_2")] Nhanvien_GH nhanvien_GH)
        {
            if (ModelState.IsValid)
            {
                db.Nhanvien_GH.Add(nhanvien_GH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhanvien_GH);
        }

        // GET: Nhanvien_GH/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GH.Find(id);
            if (nhanvien_GH == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien_GH);
        }

        // POST: Nhanvien_GH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_nvgh,Ten_nvgh,Sdt_1,Sdt_2")] Nhanvien_GH nhanvien_GH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanvien_GH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanvien_GH);
        }

        // GET: Nhanvien_GH/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GH.Find(id);
            if (nhanvien_GH == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien_GH);
        }

        // POST: Nhanvien_GH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GH.Find(id);
            db.Nhanvien_GH.Remove(nhanvien_GH);
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
