using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterWorkArea")]
    public class TblMasterWorkArea
    {
        [Key]
        public int Id { get; set; }
        public string WorkAreaName { get; set; }
        public bool IsActive { get; set; }
    }
}