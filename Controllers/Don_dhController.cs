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
    public class Don_dhController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Don_DH
        public ActionResult Index()
        {
            var don_DH = db.Don_DH.Include(d => d.Khach_hangs).Include(d => d.nhanvien_GHs);
            return View(don_DH.ToList());
        }

        // GET: Don_DH/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_dh don_DH = db.Don_DH.Find(id);
            if (don_DH == null)
            {
                return HttpNotFound();
            }
            return View(don_DH);
        }

        // GET: Don_DH/Create
        public ActionResult Create()
        {
            ViewBag.ID_kh = new SelectList(db.Khach_hang, "ID_kh", "Ten_kh");
            ViewBag.Id_nvgh = new SelectList(db.Nhanvien_GH, "ID_nvgh", "Ten_nvgh");
            return View();
        }

        // POST: Don_DH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_hd,ID_kh,ID_tinhtrang,Id_nvgh,Ngay_lap,Tong_gia,Noi_nhan,Chi_chu")] Don_dh don_DH)
        {
            if (ModelState.IsValid)
            {
                db.Don_DH.Add(don_DH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_kh = new SelectList(db.Khach_hang, "ID_kh", "Ten_kh", don_DH.ID_kh);
            ViewBag.Id_nvgh = new SelectList(db.Nhanvien_GH, "ID_nvgh", "Ten_nvgh", don_DH.Id_nvgh);
            return View(don_DH);
        }

        // GET: Don_DH/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_dh don_DH = db.Don_DH.Find(id);
            if (don_DH == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_kh = new SelectList(db.Khach_hang, "ID_kh", "Ten_kh", don_DH.ID_kh);
            ViewBag.Id_nvgh = new SelectList(db.Nhanvien_GH, "ID_nvgh", "Ten_nvgh", don_DH.Id_nvgh);
            return View(don_DH);
        }

        // POST: Don_DH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_hd,ID_kh,ID_tinhtrang,Id_nvgh,Ngay_lap,Tong_gia,Noi_nhan,Chi_chu")] Don_dh don_DH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(don_DH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_kh = new SelectList(db.Khach_hang, "ID_kh", "Ten_kh", don_DH.ID_kh);
            ViewBag.Id_nvgh = new SelectList(db.Nhanvien_GH, "ID_nvgh", "Ten_nvgh", don_DH.Id_nvgh);
            return View(don_DH);
        }

        // GET: Don_DH/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_dh don_DH = db.Don_DH.Find(id);
            if (don_DH == null)
            {
                return HttpNotFound();
            }
            return View(don_DH);
        }

        // POST: Don_DH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Don_dh don_DH = db.Don_DH.Find(id);
            db.Don_DH.Remove(don_DH);
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
