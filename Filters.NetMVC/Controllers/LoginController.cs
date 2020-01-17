using Filters.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.NetMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View(new SiteUsers());
        }
        [HttpPost]
        public ActionResult SignIn(SiteUsers model)
        {
            Model1 db = new Model1();
            SiteUsers user = db.SiteUsers.FirstOrDefault(x =>
            x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre);

            if(user == null)
            {
                ModelState.AddModelError("", "Hata : Kullanıcı Adı ya da Şifre hatalı! ");
                return View(model);
            }
            else
            {
                Session["Login"] = user;
                return RedirectToAction("Index","Home");
            }

        }

        public ActionResult Error()
        {
            if (TempData["error"] == null)
            {
                return RedirectToAction("Index","Home");
            }
            Exception model = TempData["error"] as Exception;
            return View(model);
        }
    }
}