using System;
using System.ComponentModel.DataAnnotations;

namespace Volunteer.Data.Models
{
    public class TblApiTokenManager
    {       
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; } 
        public string ConsumerKey { get; set; } 
        public string ConsumerSecret { get; set; } 
        public string CallerIp { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Token { get; set; }
    }
}