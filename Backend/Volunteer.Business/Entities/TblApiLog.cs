using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{

    public class TblApiLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ApiUrl { get; set; }
        public string CallerIp { get; set; }
        public string Token { get; set; }
        public DateTime RequestDate { get; set; }
    }
}