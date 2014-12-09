using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterScreeningQuestions")]
    public class TblMasterScreeningQuestions
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public bool IsActive { get; set; }
    }
}
