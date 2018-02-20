using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GreenFabLab
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AcquireRequestState()
        {
            HttpContext context = HttpContext.Current;
            if (context != null && context.Request.Cookies != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["Language"];
                if (cookie != null && cookie.Value != null)
                {
                 

                    if (context != null && context.Session != null)
                        Session["Language"] = cookie.Value;
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(cookie.Value);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(cookie.Value);
                }
                else
                {

                    if (context != null && context.Session != null)
                        Session["Language"] = "en";
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                }

            }
        }
    }
}
