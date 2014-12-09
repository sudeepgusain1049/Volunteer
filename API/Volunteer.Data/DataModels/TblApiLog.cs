using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblApiLog")]
    public class TblApiLog
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ApiUrl { get; set; }
        public string CallerIp { get; set; }
        public string Token { get; set; }
        public DateTime RequestDate { get; set; }
    }
}