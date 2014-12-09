using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Web.Http.ModelBinding;

namespace VolunteerApi
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutofacDI.RegisterIOCContainer(GlobalConfiguration.Configuration);
            var jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            var urlEncoded = GlobalConfiguration.Configuration.Formatters.FormUrlEncodedFormatter;
            var urlFormEncoded = new JQueryMvcFormUrlEncodedFormatter();
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(jsonFormatter);
            GlobalConfiguration.Configuration.Formatters.Add(urlEncoded);
            GlobalConfiguration.Configuration.Formatters.Add(urlFormEncoded);
        }
    }
}