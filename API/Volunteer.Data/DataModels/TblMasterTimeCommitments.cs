using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterTimeCommitments")]
    public class TblMasterTimeCommitments
    {
        [Key]
        public int Id { get; set; }
        public string Commitment { get; set; }
        public bool IsActive { get; set; }
    }
}
