using Filters.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.NetMVC.Filters
{
    public class ResultFilter : FilterAttribute, IResultFilter
    {
        //View çalışmadan önceki sonraki işlemler
        Model1 db = new Model1();
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

            db.Logs.Add(new Logs()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["Login"] as SiteUsers).KullaniciAdi,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                Tarih = DateTime.Now,
                Bilgi = "onResultExecuted"
            });

            db.SaveChanges();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

            db.Logs.Add(new Logs()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["Login"] as SiteUsers).KullaniciAdi,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                Tarih = DateTime.Now,
                Bilgi = "onResultExecuting"
            });

            db.SaveChanges();
        }
    }
}