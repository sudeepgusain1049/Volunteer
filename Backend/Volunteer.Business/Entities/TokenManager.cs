using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TokenManager
    {
        public int UserId { get; set; } 
        public string ConsumerKey { get; set; } 
        public string ConsumerSecret { get; set; } 
        public string CallerIp { get; set; } 
        public DateTime ExpirationDate { get; set; } 
        public string Token { get; set; } 
    }
}