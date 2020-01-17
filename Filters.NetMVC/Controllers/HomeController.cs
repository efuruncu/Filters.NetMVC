using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.NetMVC.Filters;

namespace Filters.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       [ActionFilter,ResultFilter, AutFilter,ExceptionFilter]
        public ActionResult Index()
        {
            return View();
        }
        [ActionFilter,ResultFilter, AutFilter,ExceptionFilter]
        public ActionResult Index2()
        {
            object sayi = 0;
            int deger = 100 / (int)sayi;

           // throw new Exception("Kullanıcı yetkisiz giriş yaptı..");
            return View();
        }
        [ActionFilter,ResultFilter, AutFilter,ExceptionFilter]
        public ActionResult Index3()
        {
            return View();
        }
    }

}