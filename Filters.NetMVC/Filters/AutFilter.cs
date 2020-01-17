using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.NetMVC.Filters
{
    public class AutFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
           if(filterContext.HttpContext.Session["Login"] == null){
                //signin sayfasına yönlendirme yap...
                filterContext.Result = new RedirectResult("/Login/SignIn");
            }
        }
    }
}