using System;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using Volunteer.Data.Models;
using VolunteerApi.Services;

namespace VolunteerApi.Filters
{
    /// <summary>
    /// MVC filter for logging all info regarding any API call
    /// </summary>
    public class LoggingFilter : ActionFilterAttribute
    {
        private readonly VolunteerService _volunteerService;

        /// <summary>
        /// Main filter constructor
        /// </summary>
        public LoggingFilter()
        {
            _volunteerService = new VolunteerService();
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var actionDescriptor = actionExecutedContext.ActionContext.ActionDescriptor;
            var action = actionDescriptor.ActionName;
            var controller = actionDescriptor.ControllerDescriptor.ControllerName;
            var methodSupported = actionDescriptor.SupportedHttpMethods.FirstOrDefault();
            if (methodSupported != null)
            {
                var methodType = methodSupported.Method;
            }

            var responseContent = actionExecutedContext.ActionContext.Response.Content;

            var queryStringKeyvalue = actionExecutedContext.ActionContext.Request.GetQueryNameValuePairs()
                .Select(e => string.Format("{0}={1}", e.Key, e.Value));
            var queryString = string.Join("&", queryStringKeyvalue);

            // log using api
            var url = string.Format(@"/api/{0}/{1}?{2}", controller, action, queryString);

            // get token
            var token = string.Empty;
            if (action == "Authorize")
            {
                token = responseContent != null ? responseContent.ReadAsStringAsync().Result : string.Empty;
            }
            else
            {
                token = actionExecutedContext.ActionContext.Request.GetQueryNameValuePairs()
                        .FirstOrDefault(e => e.Key == "token").Value;

            }
            if (token.Length % 4 != 0 && token.Contains('%'))
                token = HttpUtility.UrlDecode(token);

            // get tokenValues
            var tokenManager = _volunteerService.GetTokenValues(token);

            _volunteerService.AddLogging(new TblApiLog
            {
                UserId = tokenManager.UserId,
                ApiUrl = url,
                CallerIp = tokenManager.CallerIp,
                RequestDate = DateTime.Now,
                Token = token
            });

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}