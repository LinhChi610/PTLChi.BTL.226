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
    public class DanhGiasController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: DanhGias
        public ActionResult Index()
        {
            var danhgias = db.Danhgias.Include(d => d.SanPhams);
            return View(danhgias.ToList());
        }

        // GET: DanhGias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhGia danhGia = db.Danhgias.Find(id);
            if (danhGia == null)
            {
                return HttpNotFound();
            }
            return View(danhGia);
        }

        // GET: DanhGias/Create
        public ActionResult Create()
        {
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc");
            return View();
        }

        // POST: DanhGias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_DanhGia,ID_Sanpham,HoTen,Ngay_Gio,Noi_dung,Dien_thoai")] DanhGia danhGia)
        {
            if (ModelState.IsValid)
            {
                db.Danhgias.Add(danhGia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", danhGia.ID_Sanpham);
            return View(danhGia);
        }

        // GET: DanhGias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhGia danhGia = db.Danhgias.Find(id);
            if (danhGia == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", danhGia.ID_Sanpham);
            return View(danhGia);
        }

        // POST: DanhGias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_DanhGia,ID_Sanpham,HoTen,Ngay_Gio,Noi_dung,Dien_thoai")] DanhGia danhGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", danhGia.ID_Sanpham);
            return View(danhGia);
        }

        // GET: DanhGias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhGia danhGia = db.Danhgias.Find(id);
            if (danhGia == null)
            {
                return HttpNotFound();
            }
            return View(danhGia);
        }

        // POST: DanhGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanhGia danhGia = db.Danhgias.Find(id);
            db.Danhgias.Remove(danhGia);
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
