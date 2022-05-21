﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PTLChi.BTL._226.Models;

namespace PTLChi.BTL._226.Controllers
{
    public class AccountModelsController : Controller
    {
        private BTLDbContext db = new BTLDbContext();
        Encrytion ecy = new Encrytion();

        // GET: Accounts
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [Obsolete]
        public ActionResult Register(AccountModel acc)
        {
            if (ModelState.IsValid)
            {
                //Mã Hóa mật khẩu trước khi cho vào database
                acc.Password = ecy.PassWordEncrytion(acc.Password);
                db.AccountModels.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "AccountModels");
            }
            return View(acc);
        }
        public ActionResult Login(string returnUrl)

        {
            if (CheckSession() == 1)

            {

                return RedirectToAction("Index", "SanPhams", new { Area = "" });
            }
            else if (CheckSession() == 2)

            {
                return RedirectToAction("Index", "Home", new { Area = "" });

            }
            ViewBag.ReturnUrl = returnUrl;
            return View();

        }

        private int CheckSession()
        {
            using (var db = new BTLDbContext())
            {
                var user = HttpContext.Session["idUser"];
                if (user != null)
                {
                    var role = db.AccountModels.Find(user.ToString()).Roleid;
                    if (role != null)
                    {
                        if (role.ToString() == "Admin")
                        {
                            return 1;
                        }
                        else if (role.ToString() == "Client")
                        {
                            return 2;
                        }
                    }
                }
            }
            return 0;
        }
        [HttpPost]
        [AllowAnonymous]
        [Obsolete]
        public ActionResult Login(AccountModel acc, string returnUrl)

        {
            try
            {
                if (!string.IsNullOrEmpty(acc.Username) && !string.IsNullOrEmpty(acc.Password))
                {

                    using (var db = new BTLDbContext())

                    {
                        var passTo12345 = ecy.PassWordEncrytion(acc.Password);
                        var account = db.AccountModels.Where(m => m.Username.Equals(acc.Username) && m.Password.Equals(passTo12345)).Count();
                        if (account == 1)
                        {
                            FormsAuthentication.SetAuthCookie(acc.Username, false);
                            Session["idUser"] = acc.Username;
                            return RedirectTolocal(returnUrl);
                        }

                        ModelState.AddModelError("", "Thông tin đăng nhập chưa chính xác");

                    }
                }
                ModelState.AddModelError("", "Username and password is required.");
            }

            catch
            {
                ModelState.AddModelError("", "Hệ thống đang được bảo trì, vui lòng liên hệ với quản trị viên");
            }
            return View(acc);
        }

        private ActionResult RedirectTolocal(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || returnUrl == "/")
            {
                if (CheckSession() == 1)
                {
                    return RedirectToAction("Index", "SanPhams", new { Area = "" });
                }
                else if (CheckSession() == 2)
                {
                    return RedirectToAction("Index", "Home", new { Area = "" });
                }
            }
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["iduser"] = null;
            return RedirectToAction("Login", "AccountModels");
        }
    }
}

