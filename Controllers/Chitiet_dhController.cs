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
    [Authorize]
    public class Chitiet_dhController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Chitiet_dh
        public ActionResult Index()
        {
            var chitiet_dhs = db.Chitiet_dhs.Include(c => c.Don_dhs).Include(c => c.Sanphams);
            return View(chitiet_dhs.ToList());
        }

        // GET: Chitiet_dh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_dh = db.Chitiet_dhs.Find(id);
            if (chitiet_dh == null)
            {
                return HttpNotFound();
            }
            return View(chitiet_dh);
        }

        // GET: Chitiet_dh/Create
        public ActionResult Create()
        {
            ViewBag.ID_HoaDon = new SelectList(db.Don_dhs, "ID_HoaDon", "Bao_hanh");
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc");
            return View();
        }

        // POST: Chitiet_dh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ChitietHoaDon,ID_HoaDon,ID_Sanpham,So_luong_mua,Don_gia")] Chitiet_dh chitiet_dh)
        {
            if (ModelState.IsValid)
            {
                db.Chitiet_dhs.Add(chitiet_dh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_HoaDon = new SelectList(db.Don_dhs, "ID_HoaDon", "Bao_hanh", chitiet_dh.ID_HoaDon);
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", chitiet_dh.ID_Sanpham);
            return View(chitiet_dh);
        }

        // GET: Chitiet_dh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_dh = db.Chitiet_dhs.Find(id);
            if (chitiet_dh == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_HoaDon = new SelectList(db.Don_dhs, "ID_HoaDon", "Bao_hanh", chitiet_dh.ID_HoaDon);
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", chitiet_dh.ID_Sanpham);
            return View(chitiet_dh);
        }

        // POST: Chitiet_dh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ChitietHoaDon,ID_HoaDon,ID_Sanpham,So_luong_mua,Don_gia")] Chitiet_dh chitiet_dh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chitiet_dh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_HoaDon = new SelectList(db.Don_dhs, "ID_HoaDon", "Bao_hanh", chitiet_dh.ID_HoaDon);
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", chitiet_dh.ID_Sanpham);
            return View(chitiet_dh);
        }

        // GET: Chitiet_dh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_dh = db.Chitiet_dhs.Find(id);
            if (chitiet_dh == null)
            {
                return HttpNotFound();
            }
            return View(chitiet_dh);
        }

        // POST: Chitiet_dh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chitiet_dh chitiet_dh = db.Chitiet_dhs.Find(id);
            db.Chitiet_dhs.Remove(chitiet_dh);
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
