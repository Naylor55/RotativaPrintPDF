using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RotativaPrintViewToPDF
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Pdf",
                url: "Download/{orderId}",
                defaults: new { Controller = "RotativaDemo", action = "PdfTemplate", orderId = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "RotativaDemo", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
