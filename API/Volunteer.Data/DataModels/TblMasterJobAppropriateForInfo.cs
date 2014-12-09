using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterJobAppropriateForInfo")]
    public class TblMasterJobAppropriateForInfo
    {
        [Key]
        public int Id { get; set; }
        public string AppropriateForInfo { get; set; }
        public bool IsActive { get; set; }
    }
}
