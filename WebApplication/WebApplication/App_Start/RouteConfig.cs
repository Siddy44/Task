﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            //Attribute Routing
            
            routes.MapMvcAttributeRoutes();
            
            
            //Conventional Routing
            //routes.MapRoute(
           //name: "Default1", 
            //url: "movie/released/{year}/{month}",
            //defaults: new { controller = "Movie", action = "Index" },
            //new { year = @"\d{4}", month = @"\d{2}" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
