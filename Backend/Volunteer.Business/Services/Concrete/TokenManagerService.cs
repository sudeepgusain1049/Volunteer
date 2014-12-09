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

namespace Volunteer.Business.Services
{
    public class TokenManagerService : ITokenManagerService
    {
        private readonly RestClient _client;
        private readonly string _url = ConfigurationManager.AppSettings["WebAPIBaseUrl"];
        private readonly string _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
        private readonly string _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        private static string token;

        public TokenManagerService()
        {
            _client = new RestClient { BaseUrl = new Uri(_url) };
         }

        public String GetWebAPIToken()
        {
            String token = String.Empty;
            token = GetToken(_consumerKey, _consumerSecret);
            return token;
        }

        public String GetToken(String Key, String Secret)
        {
            Conusmer _consumer = new Conusmer();
            _consumer.consumerKey = Key;
            _consumer.consumerSecret = Secret;
            var request = new RestRequest("api/OAuth/Authorize", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddBody(_consumer);
            var response = _client.Execute<Conusmer>(request);
            return response.Content;
        }



    }
}
