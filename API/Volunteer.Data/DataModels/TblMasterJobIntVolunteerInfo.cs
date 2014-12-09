using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterJobIntVolunteerInfo")]
    public class TblMasterJobIntVolunteerInfo
    {
        [Key]
        public int Id { get; set; }
        public string IntVolunteerInfo { get; set; }
        public bool IsActive { get; set; }
    }
}
