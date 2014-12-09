using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterSkills")]
    public class TblMasterSkills
    {
        [Key]
        public int Id { get; set; }
        public string SkillName { get; set; }
        public bool IsActive { get; set; }
    }
}