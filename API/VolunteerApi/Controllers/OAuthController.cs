using System.Net;
using System.Net.Http;
using System.Web.Http;
using VolunteerApi.Filters;
using VolunteerApi.Models;
using VolunteerApi.Services;

namespace VolunteerApi.Controllers
{
    /// <summary>
    /// oAuth category for authenticating and authorizing API consumers
    /// </summary>
    public class OAuthController : ApiController
    {
        private readonly IVolunteerService _volunteerService;

        /// <summary>
        /// oAuth main constructor
        /// </summary>
        /// <param name="volunteerService">IoC version of the service that handles retrieving the data</param>
        public OAuthController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        /// <summary>
        /// Authorize consumer to use Volunteer API
        /// </summary>
        /// <param name="consumer">
        ///     JSON object representing your consumer key and secret.
        ///     It should have "consumerKey" attribute holding your consumer key, and "consumerSecret" attribute holding your consumer secret
        /// </param>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <returns>Access token to be used in future API calss</returns>
        [System.Web.Mvc.HttpPost]
        [AllowAnonymous]
        [LoggingFilter]
        public HttpResponseMessage Authorize([FromBody]Conusmer consumer)
        {
            if (consumer == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            var token = _volunteerService.GenerateRequestToken(consumer.consumerKey, consumer.consumerSecret);

            if (token == string.Empty)
                return Request.CreateResponse(HttpStatusCode.Unauthorized);

            var successResponse = Request.CreateResponse(HttpStatusCode.OK);
            successResponse.Content = new StringContent(token);
            return successResponse;
        }
    }
}
