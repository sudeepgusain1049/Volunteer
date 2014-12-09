using System.Net;
using System.Net.Http;
using System.Web.Http;
using Volunteer.Data.Models;
using VolunteerApi.Filters;
using VolunteerApi.Services;

namespace VolunteerApi.Controllers
{
    /// <summary>
    /// Register category that handles new registrations
    /// </summary>
    public class RegisterController : ApiController
    {
        private readonly IVolunteerService _volunteerService;

        /// <summary>
        /// Main registration constructor
        /// </summary>
        /// <param name="volunteerService">IoC version of the service that handles retrieving the data</param>
        public RegisterController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        // POST api/register/user
        /// <summary>
        /// Registers a new user as a volunteer or an organization member
        /// </summary>
        /// <param name="token">Access token</param>
        /// <param name="user">User details with a single profile or collection of organizations' profiles</param>
        /// <returns>The newly created user id with a message of 'User Created With Id: xx'</returns>
        [HttpPost]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage User(string token, [FromBody] TblUsers user)
        {
            var userId = _volunteerService.AddUser(user);

            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.Content = new StringContent(string.Format("User Created With Id: {0}", userId));
            return response;
        }
    }
}