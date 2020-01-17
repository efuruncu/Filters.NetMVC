using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using Filters.NetMVC.Models;

namespace Filters.NetMVC.Filters
{
    public class ActionFilter : FilterAttribute, IActionFilter
    {
        Model1 db = new Model1();
        //Action çalıştıktan sonra
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {     
            db.Logs.Add(new Logs()
            { 
                KullaniciAdi =(filterContext.HttpContext.Session["Login"] as SiteUsers).KullaniciAdi,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "onActionExecuted"
            });

            db.SaveChanges();
        }
        //Action çalışmadan önce
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Logs.Add(new Logs()
            {
                KullaniciAdi = (filterContext.HttpContext.Session["Login"] as SiteUsers).KullaniciAdi,
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "onActionExecuting"
            });


            db.SaveChanges();
        }
    }
}