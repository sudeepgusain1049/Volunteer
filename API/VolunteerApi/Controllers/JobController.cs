using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Volunteer.Data.Models;
using VolunteerApi.Filters;
using VolunteerApi.Services;
using VolunteerApi.Models;
using Newtonsoft.Json.Linq;

namespace VolunteerApi.Controllers
{
    public class JobController : ApiController
    {
       
        private readonly IJobService _jobService;
        private readonly IVolunteerService _volunteerService;
        /// <summary>
        /// Main job constructor
        /// </summary>
        /// <param name="jobService"></param>
        public JobController(IJobService jobService, IVolunteerService volunteerService)
        {
            _jobService = jobService;
            _volunteerService = volunteerService;
        }

        // POST api/job/addJob
        /// <summary>
        /// Post a Job
        /// </summary>
        /// <param name="token">Access token</param>
        /// <param name="job"></param>
        /// <returns>Success message</returns>
        [HttpPost]
        [VolunteerAuthorization]
        [LoggingFilter]
        public HttpResponseMessage PostJob(string token, [FromBody]Job job) 
        {
            var jobDetails = _volunteerService.GetJobDTO(job);
            var jobId = _jobService.AddJob(jobDetails);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.Content = new StringContent(string.Format("Job Created With Id: {0}", jobId));
            return response;
        }




    }
}