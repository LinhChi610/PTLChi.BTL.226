using PTLChi.BTL._226.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
            return View();

        }


        [HttpPost]
        [AllowAnonymous]
        [Obsolete]
        public ActionResult Login(AccountModel acc)

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
                            return RedirectToAction("Index","SanPhams");
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

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["iduser"] = null;
            return RedirectToAction("Login", "AccountModels");
        }
    }
}