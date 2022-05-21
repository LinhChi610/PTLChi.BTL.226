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
    public class Nhanvien_GHsController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Nhanvien_GHs
        public ActionResult Index()
        {
            return View(db.Nhanvien_GHs.ToList());
        }

        // GET: Nhanvien_GHs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GHs.Find(id);
            if (nhanvien_GH == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien_GH);
        }

        // GET: Nhanvien_GHs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nhanvien_GHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_NhanvienGH,Ten_NhanvienGH,Sdt_1,Sdt_2")] Nhanvien_GH nhanvien_GH)
        {
            if (ModelState.IsValid)
            {
                db.Nhanvien_GHs.Add(nhanvien_GH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhanvien_GH);
        }

        // GET: Nhanvien_GHs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GHs.Find(id);
            if (nhanvien_GH == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien_GH);
        }

        // POST: Nhanvien_GHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_NhanvienGH,Ten_NhanvienGH,Sdt_1,Sdt_2")] Nhanvien_GH nhanvien_GH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanvien_GH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanvien_GH);
        }

        // GET: Nhanvien_GHs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GHs.Find(id);
            if (nhanvien_GH == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien_GH);
        }

        // POST: Nhanvien_GHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nhanvien_GH nhanvien_GH = db.Nhanvien_GHs.Find(id);
            db.Nhanvien_GHs.Remove(nhanvien_GH);
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
