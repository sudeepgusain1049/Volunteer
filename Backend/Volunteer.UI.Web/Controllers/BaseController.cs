using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer.UI.Web.Models;
using Volunteer.Business.Services;


namespace Volunteer.UI.Web.Controllers
{
    public class BaseController : Controller
    {
     
        public BaseController()
        {
        }

        /// <summary>
        /// Gets the current site session.
        /// </summary>
        public SiteSession CurrentSiteSession
        {
            get
            {
                SiteSession siteSession = (SiteSession)this.Session["SiteSession"];
                return siteSession;
            }
        }


         protected override void OnActionExecuting(ActionExecutingContext filterContext)
         {
            int culture = 0;
            if (Session["CurrentUICulture"] == null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                Session["CurrentUICulture"] = culture;
            }
            else
            {
                culture = (int)Session["CurrentUICulture"];
            }
            SiteSession.CurrentUICulture = culture;
         }

        

        //protected MvcBasicSiteEntities _db = new MvcBasicSiteEntities();
        /// <summary>
        /// Dispose the used resource.
        /// </summary>
        /// <param name="disposing">The disposing flag.</param>
        protected override void Dispose(bool disposing)
        {
           // _db.Dispose();
           base.Dispose(disposing);
        }

        
        /// <summary>
        /// Called when an unhandled exception occurs in the action.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is UnauthorizedAccessException)
            {
                filterContext.ExceptionHandled = true;
                filterContext.Result = RedirectToAction("Job", "Index");
            }
            //
            base.OnException(filterContext);
        }


    }
}
