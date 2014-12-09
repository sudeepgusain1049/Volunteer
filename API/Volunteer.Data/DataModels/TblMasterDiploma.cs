using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterDiploma")]
    public class TblMasterDiploma
    {
        [Key]
        public int Id { get; set; }
        public string DiplomaName { get; set; }
        public bool IsActive { get; set; }
    }
}