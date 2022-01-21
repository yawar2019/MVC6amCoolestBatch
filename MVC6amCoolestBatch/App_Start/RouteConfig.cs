using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC6amCoolestBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //Convention based Routing MVC1
            routes.MapRoute(
                name: "Test1",
                url: "pistahouse/burger",
                defaults: new { controller = "new", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Test2",
                url: "Playing/cricket",
                defaults: new { controller = "new", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "new", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
