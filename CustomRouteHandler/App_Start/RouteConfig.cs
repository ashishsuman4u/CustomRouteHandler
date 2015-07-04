using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomRouteHandler
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteValueDictionary defaults = new RouteValueDictionary();
            defaults.Add("controller", "Home");
            defaults.Add("action", "Index");
            defaults.Add("id", "");
            var customRoute = new Route("{controller}/{action}/{id}", defaults, new RouteHandler.CustomRouteHandler());
            routes.Add(customRoute);
        }
    }
}
