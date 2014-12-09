using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterDaysOfWeek")]
    public class TblMasterDaysOfWeek
    {
        [Key]
        public int Id { get; set; }
        public string DaysOfweek { get; set; }
        public bool IsActive { get; set; }
    }
}