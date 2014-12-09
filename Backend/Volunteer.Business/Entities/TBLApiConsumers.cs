using System;

namespace Volunteer.Business.Entities
{
    public class TblApiConsumers
    {       
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string CallBackUrl { get; set; }
        public string RegistrationDate { get; set; }

    }
}