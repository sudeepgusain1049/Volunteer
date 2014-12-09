using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Volunteer.Business.Entities;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;

namespace Volunteer.Business.Services
{
    public class PostJobService : IPostJobService
    {
        private readonly ITokenManagerService _tokenManagerService;
        private readonly RestClient _client;
        private readonly string _url = ConfigurationManager.AppSettings["WebAPIBaseUrl"];
        private String token;

        public PostJobService(ITokenManagerService tokenManagerService)
        {
            _tokenManagerService = tokenManagerService;
            _client = new RestClient { BaseUrl = new Uri(_url) };
            token = _tokenManagerService.GetWebAPIToken();
        }


        public List<TblMasterLanguages> GetMasterLanguages()
        {
            var request = new RestRequest("api/metadata/Languages", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterLanguages>>(request);
            return response.Data;
        }
        public List<TblMasterCountry> GetMasterCountries()
        {
            var request = new RestRequest("api/metadata/Countries", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterCountry>>(request);
            return response.Data;
        }
        public List<TblMasterDaysOfWeek> GetMasterDaysOfWeek()
        {
            var request = new RestRequest("api/metadata/DaysOfWeek", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterDaysOfWeek>>(request);
            return response.Data;
        }
        public List<TblMasterDiploma> GetMasterDiplomas()
        {
            var request = new RestRequest("api/metadata/Diplomas", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterDiploma>>(request);
            return response.Data;
        }
        public List<TblMasterSkills> GetMasterSkills()
        {
            var request = new RestRequest("api/metadata/Skills", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterSkills>>(request);
            return response.Data;
        }
        public List<TblMasterTimeCommitments> GetMasterTimeCommitments()
        {
            var request = new RestRequest("api/metadata/TimeCommitments", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterTimeCommitments>>(request);
            return response.Data;
        }
        public List<TblMasterScreeningQuestions> GetMasterSceeningQuestions()
        {
            var request = new RestRequest("api/metadata/StandardScreeningQuestions", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterScreeningQuestions>>(request);
            return response.Data;
        }
        public List<TblMasterJobTypes> GetMasterJobTypes()
        {
            var request = new RestRequest("api/metadata/JobTypes", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterJobTypes>>(request);
            return response.Data;
        }
        public List<TblMasterJobAdditionalInfo> GetMasterJobAdditionalInfo()
        {
            var request = new RestRequest("api/metadata/JobAdditionalDetails", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterJobAdditionalInfo>>(request);
            return response.Data;
        }
        public List<TblMasterJobIntVolunteerInfo> GetMasterJobIntVolunteerInfo()
        {
            var request = new RestRequest("api/metadata/JobInternationalVolunteeringDetails", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterJobIntVolunteerInfo>>(request);
            return response.Data;
        }
        public List<TblMasterJobAppropriateForInfo> GetMasterJobAppropriateForInfo()
        {
            var request = new RestRequest("api/metadata/JobAppropriateFor", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterJobAppropriateForInfo>>(request);
            return response.Data;
        }
        public List<TblMasterInterval> GetMasterInterval()
        {
            var request = new RestRequest("api/metadata/PartsOfDay", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token);
            var response = _client.Execute<List<TblMasterInterval>>(request);
            return response.Data;
        }

        public void AddJob(Job jObject)
        {
            var json = JsonConvert.SerializeObject(jObject);

            var request = new RestRequest("api/Job/PostJob?{token}", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddParameter("token", token, ParameterType.QueryString);
            request.AddParameter("text/json", json, ParameterType.RequestBody);
            //request.AddBody(serverData);
            var response = _client.Execute<Job>(request);

            //if (response.StatusCode != HttpStatusCode.Created)
            //    throw new Exception(response.ErrorMessage);
        }
    }
}
