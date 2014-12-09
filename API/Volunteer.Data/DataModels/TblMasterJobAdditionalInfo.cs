using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterJobAdditionalInfo")]
    public class TblMasterJobAdditionalInfo
    {
        [Key]
        public int Id { get; set; }
        public string AdditionalInfo { get; set; }
        public bool IsActive { get; set; }
    }
}
