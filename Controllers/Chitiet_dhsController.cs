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
    public class Chitiet_dhsController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Chitiet_dhs
        public ActionResult Index()
        {
            var chitiet_dhs = db.Chitiet_dhs.Include(c => c.Don_dhs).Include(c => c.Sanphams);
            return View(chitiet_dhs.ToList());
        }

        // GET: Chitiet_dhs/Details/5
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

        // GET: Chitiet_dhs/Create
        public ActionResult Create()
        {
            ViewBag.ID_HoaDon = new SelectList(db.Don_Dhs, "ID_HoaDon", "Dia_Chi_Nhan");
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc");
            return View();
        }

        // POST: Chitiet_dhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ChitietHoaDon,ID_HoaDon,ID_KhachHang,Ten_KhachHang,ID_Sanpham,Ten_Sanpham,So_luong_mua,Bao_hanh,Gia_khuyen_mai,Dia_Chi_Nhan,Chi_chu,Ngay_lap,Id_NhanvienGH,Ten_NhanvienGH,Don_gia")] Chitiet_dh chitiet_dh)
        {
            if (ModelState.IsValid)
            {
                db.Chitiet_dhs.Add(chitiet_dh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_HoaDon = new SelectList(db.Don_Dhs, "ID_HoaDon", "Dia_Chi_Nhan", chitiet_dh.ID_HoaDon);
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", chitiet_dh.ID_Sanpham);
            return View(chitiet_dh);
        }

        // GET: Chitiet_dhs/Edit/5
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
            ViewBag.ID_HoaDon = new SelectList(db.Don_Dhs, "ID_HoaDon", "Dia_Chi_Nhan", chitiet_dh.ID_HoaDon);
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", chitiet_dh.ID_Sanpham);
            return View(chitiet_dh);
        }

        // POST: Chitiet_dhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ChitietHoaDon,ID_HoaDon,ID_KhachHang,Ten_KhachHang,ID_Sanpham,Ten_Sanpham,So_luong_mua,Bao_hanh,Gia_khuyen_mai,Dia_Chi_Nhan,Chi_chu,Ngay_lap,Id_NhanvienGH,Ten_NhanvienGH,Don_gia")] Chitiet_dh chitiet_dh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chitiet_dh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_HoaDon = new SelectList(db.Don_Dhs, "ID_HoaDon", "Dia_Chi_Nhan", chitiet_dh.ID_HoaDon);
            ViewBag.ID_Sanpham = new SelectList(db.SanPhams, "ID_Sanpham", "ID_Danhmuc", chitiet_dh.ID_Sanpham);
            return View(chitiet_dh);
        }

        // GET: Chitiet_dhs/Delete/5
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

        // POST: Chitiet_dhs/Delete/5
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
