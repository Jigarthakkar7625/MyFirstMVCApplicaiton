﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstMVCApplicaiton
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //ContollerName / ActionName /{Id}

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "MyFirstMVCApplicaiton.Controllers" }
            );
        }
    }
}
