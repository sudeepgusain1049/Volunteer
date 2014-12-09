using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace VolunteerApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
              name: "Metadata",
              routeTemplate: "api/metadata/{action}/{token}",
              defaults: new { controller = "Master", token = UrlParameter.Optional }
          );
            config.Routes.MapHttpRoute(
                name: "Authorize",
                routeTemplate: "api/{controller}/{action}/{token}",
                defaults: new { token = UrlParameter.Optional },
                constraints: new { controller = "OAuth" }
            );
            config.Routes.MapHttpRoute(
               name: "Jobs",
                routeTemplate: "api/{controller}/{action}/{token}",
                defaults: new { token = UrlParameter.Optional },
                constraints: new { controller = "Job" }
            );
        }
    }
}
