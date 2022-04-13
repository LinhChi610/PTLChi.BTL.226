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
    public class TinhTrang_dhController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: TinhTrang_dh
        public ActionResult Index()
        {
            return View(db.TinhTrang_dhs.ToList());
        }

        // GET: TinhTrang_dh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinhTrang_dh tinhTrang_dh = db.TinhTrang_dhs.Find(id);
            if (tinhTrang_dh == null)
            {
                return HttpNotFound();
            }
            return View(tinhTrang_dh);
        }

        // GET: TinhTrang_dh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TinhTrang_dh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_tinh_trang,TinhTrangdh")] TinhTrang_dh tinhTrang_dh)
        {
            if (ModelState.IsValid)
            {
                db.TinhTrang_dhs.Add(tinhTrang_dh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tinhTrang_dh);
        }

        // GET: TinhTrang_dh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinhTrang_dh tinhTrang_dh = db.TinhTrang_dhs.Find(id);
            if (tinhTrang_dh == null)
            {
                return HttpNotFound();
            }
            return View(tinhTrang_dh);
        }

        // POST: TinhTrang_dh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_tinh_trang,TinhTrangdh")] TinhTrang_dh tinhTrang_dh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tinhTrang_dh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tinhTrang_dh);
        }

        // GET: TinhTrang_dh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinhTrang_dh tinhTrang_dh = db.TinhTrang_dhs.Find(id);
            if (tinhTrang_dh == null)
            {
                return HttpNotFound();
            }
            return View(tinhTrang_dh);
        }

        // POST: TinhTrang_dh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TinhTrang_dh tinhTrang_dh = db.TinhTrang_dhs.Find(id);
            db.TinhTrang_dhs.Remove(tinhTrang_dh);
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
