using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterJobTypes")]
    public class TblMasterJobTypes
    {
        [Key]
        public int Id { get; set; }
        public string JobType { get; set; }
        public bool IsActive { get; set; }
    }
}
