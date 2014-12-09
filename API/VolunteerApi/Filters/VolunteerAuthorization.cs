using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using VolunteerApi.Services;

namespace VolunteerApi.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class VolunteerAuthorization : AuthorizationFilterAttribute
    {
        private readonly IVolunteerService _volunteerService;
        readonly bool _active = true;


        public VolunteerAuthorization()
        {
            _volunteerService = new VolunteerService();
        }

        /// <summary>
        /// Overriden constructor to allow explicit disabling of this
        /// filter's behavior. Pass false to disable (same as no filter
        /// but declarative)
        /// </summary>
        /// <param name="active"></param>
        public VolunteerAuthorization(bool active)
        {
            _active = active;
        }


        /// <summary>
        /// Override to Web API filter method to handle Basic Auth check
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (_active)
            {
                var tokenKeyvalues = actionContext.Request.GetQueryNameValuePairs().Where(e => e.Key == "token");
                if (tokenKeyvalues.Any())
                {
                    var token = tokenKeyvalues.FirstOrDefault().Value;
                    
                    // decode token only if it's length is not suffecient base64string
                    if (token.Length%4 != 0 && token.Contains('%'))
                        token = HttpUtility.UrlDecode(token);

                    var tokenManager = _volunteerService.GetTokenValues(token);
                    // check token database version
                    var isIdentical = _volunteerService.IsTokenMatchDatabaseVersion(tokenManager);
                    if (!isIdentical)
                        return;

                    // check token exist
                    var isvalid = _volunteerService.IsTokenMatchDatabaseVersion(tokenManager);

                    if (!isvalid)
                    {
                        actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                        return;
                    }
                    else if (DateTime.Now > tokenManager.ExpirationDate)
                    {
                        actionContext.Request.CreateResponse(HttpStatusCode.BadRequest);
                        return;
                    }
                }


                base.OnAuthorization(actionContext);
            }
        }
        /*
        /// <summary>
        /// Base implementation for user authentication - you probably will
        /// want to override this method for application specific logic.
        /// 
        /// The base implementation merely checks for username and password
        /// present and set the Thread principal.
        /// 
        /// Override this method if you want to customize Authentication
        /// and store user data as needed in a Thread Principle or other
        /// Request specific storage.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected virtual bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            return true;
        }

        /// <summary>
        /// Parses the Authorization header and creates user credentials
        /// </summary>
        /// <param name="actionContext"></param>
        protected virtual BasicAuthenticationIdentity ParseAuthorizationHeader(HttpActionContext actionContext)
        {
            string authHeader = null;
            var auth = actionContext.Request.Headers.Authorization;
            if (auth != null && auth.Scheme == "Basic")
                authHeader = auth.Parameter;

            if (string.IsNullOrEmpty(authHeader))
                return null;

            authHeader = Encoding.Default.GetString(Convert.FromBase64String(authHeader));

            var tokens = authHeader.Split(':');
            if (tokens.Length < 2)
                return null;

            return new BasicAuthenticationIdentity(tokens[0], tokens[1]);
        }


        /// <summary>
        /// Send the Authentication Challenge request
        /// </summary>
        /// <param name="message"></param>
        /// <param name="actionContext"></param>
        void Challenge(HttpActionContext actionContext)
        {
            var host = actionContext.Request.RequestUri.DnsSafeHost;
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            actionContext.Response.Headers.Add("WWW-Authenticate", string.Format("Basic realm=\"{0}\"", host));
        }
        */
    }
      /*  
    public class BasicAuthenticationIdentity : GenericIdentity
    {
        public BasicAuthenticationIdentity(string name, string password)
            : base(name, "Basic")
        {
            this.Password = password;
        }

        /// <summary>
        /// Basic Auth Password for custom authentication
        /// </summary>
        public string Password { get; set; }
    }*/
}