using System.ComponentModel.DataAnnotations;

namespace Volunteer.Data.Models
{
    public class TblMasterCategories
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}