using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterInterval")]
    public class TblMasterInterval
    {
        [Key]
        public int Id { get; set; }
        public string Interval { get; set; }
        public bool IsActive { get; set; }
    }
}
