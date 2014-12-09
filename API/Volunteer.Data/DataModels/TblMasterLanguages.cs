using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterLanguages")]
    public class TblMasterLanguages
    {
        [Key]
        public int Id { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
    }
}
