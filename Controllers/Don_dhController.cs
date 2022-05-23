﻿using System;
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
    public class Don_dhController : Controller
    {
        private BTLDbContext db = new BTLDbContext();

        // GET: Don_dh
        public ActionResult Index()
        {
            return View(db.Don_Dhs.ToList());
        }

        // GET: Don_dh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_dh don_dh = db.Don_Dhs.Find(id);
            if (don_dh == null)
            {
                return HttpNotFound();
            }
            return View(don_dh);
        }

        // GET: Don_dh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Don_dh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_HoaDon,ID_KhachHang,Ten_KhachHang,Ngay_lap,Tong_Gia,Dia_Chi_Nhan,Chi_chu")] Don_dh don_dh)
        {
            if (ModelState.IsValid)
            {
                db.Don_Dhs.Add(don_dh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(don_dh);
        }

        // GET: Don_dh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_dh don_dh = db.Don_Dhs.Find(id);
            if (don_dh == null)
            {
                return HttpNotFound();
            }
            return View(don_dh);
        }

        // POST: Don_dh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_HoaDon,ID_KhachHang,Ten_KhachHang,Ngay_lap,Tong_Gia,Dia_Chi_Nhan,Chi_chu")] Don_dh don_dh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(don_dh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(don_dh);
        }

        // GET: Don_dh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Don_dh don_dh = db.Don_Dhs.Find(id);
            if (don_dh == null)
            {
                return HttpNotFound();
            }
            return View(don_dh);
        }

        // POST: Don_dh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Don_dh don_dh = db.Don_Dhs.Find(id);
            db.Don_Dhs.Remove(don_dh);
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
