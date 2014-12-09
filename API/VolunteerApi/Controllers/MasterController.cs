using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Volunteer.Data.Models;
using VolunteerApi.Filters;
using VolunteerApi.Services;

namespace VolunteerApi.Controllers
{
    /// <summary>
    /// Lists for retrieving metadata
    /// </summary>
    public class MasterController : ApiController
    {
        private readonly IVolunteerService _volunteerService;

        /// <summary>
        /// Main metadata constructor
        /// </summary>
        /// <param name="volunteerService">IoC version of the service that handles retrieving the data</param>
        public MasterController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        // GET api/master/categories
        /// <summary>
        /// Get all categories metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata categories</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage Categories(string token)
        {
            var masterCategories = _volunteerService.GetMasterCategorieses();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterCategories>>(masterCategories, new JsonMediaTypeFormatter());
            return response;
        }

        /*
        [HttpGet]
        public HttpResponseMessage CategoriesUnsafe()
        {
            var masterCategories = _volunteerService.GetMasterCategorieses();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterCategories>>(masterCategories, new JsonMediaTypeFormatter());
            return response;
        }
        */
        // GET api/master/countries
        /// <summary>
        /// Get all countries metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata countries</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage Countries(string token)
        {
            var masterCountries = _volunteerService.GetmaMasterCountries();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterCountry>>(masterCountries, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/daysOfWeek
        /// <summary>
        /// Get all days of week metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata days of week</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage DaysOfWeek(string token)
        {
            var masterDaysOfWeek = _volunteerService.GetmMasterDaysOfWeek();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterDaysOfWeek>>(masterDaysOfWeek, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/diplomas
        /// <summary>
        /// Get all diplomas metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata diplomas</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage Diplomas(string token)
        {
            var masterDiploma = _volunteerService.GetmaMasterDiplomas();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterDiploma>>(masterDiploma, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/organizationTypes
        /// <summary>
        /// Get all organization types metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata organization types</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage OrganizationTypes(string token)
        {
            var organizationTypes = _volunteerService.GetmTblMasterOrganizationTypes();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterOrganizationType>>(organizationTypes, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/skills
        /// <summary>
        /// Get all skills metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata skills</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage Skills(string token)
        {
            var masterSkills = _volunteerService.GetmMasterSkills();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterSkills>>(masterSkills, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/workAreas
        /// <summary>
        /// Get all work areas metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata work areas</returns>
        [HttpGet] 
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage WorkAreasFocus(string token)
        {
            var masterWorkAreas = _volunteerService.GetMasterWorkAreas();

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterWorkArea>>(masterWorkAreas, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/timeCommitments
        /// <summary>
        /// Get all time commitments metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata time commitments</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage TimeCommitments(string token)
        {
            var timeCommitments = _volunteerService.GetMasterTimeCommitments();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterTimeCommitments>>(timeCommitments, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/languages
        /// <summary>
        /// Get all languages metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata languages</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage Languages(string token)
        {
            var languages = _volunteerService.GetMasterLanguages();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterLanguages>>(languages, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/sceeningQuestions
        /// <summary>
        /// Get all sceening questions metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata sceening questions</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage StandardScreeningQuestions(string token)
        {
            var sceeningQuestions = _volunteerService.GetMasterSceeningQuestions();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterScreeningQuestions>>(sceeningQuestions, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/jobTypes
        /// <summary>
        /// Get all job types metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata job types</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage JobTypes(string token)
        {
            var jobTypes = _volunteerService.GetMasterJobTypes();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterJobTypes>>(jobTypes, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/jobAdditionalInfo
        /// <summary>
        /// Get all job additional details metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata job additional info</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage JobAdditionalDetails(string token)
        {
            var jobTypes = _volunteerService.GetMasterJobAdditionalInfo();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterJobAdditionalInfo>>(jobTypes, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/jobIntVolunteerInfo
        /// <summary>
        /// Get all international volunteering details metadata 
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata job international volunteering details</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage JobInternationalVolunteeringDetails(string token)
        {
            var jobTypes = _volunteerService.GetMasterJobIntVolunteerInfo();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterJobIntVolunteerInfo>>(jobTypes, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/jobAppropriateForInfo
        /// <summary>
        /// Get all job appropriate for metadata 
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All job appropriate for metadata</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage JobAppropriateFor(string token)
        {
            var jobTypes = _volunteerService.GetMasterJobAppropriateForInfo();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterJobAppropriateForInfo>>(jobTypes, new JsonMediaTypeFormatter());
            return response;
        }

        // GET api/master/interval
        /// <summary>
        /// Get all parts of day metadata
        /// </summary>
        /// <param name="token">Access token</param>
        /// <returns>All metadata parts of day</returns>
        [HttpGet]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage PartsOfDay(string token)
        {
            var jobTypes = _volunteerService.GetMasterInterval();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new ObjectContent<IEnumerable<TblMasterInterval>>(jobTypes, new JsonMediaTypeFormatter());
            return response;
        }
    }
}