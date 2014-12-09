using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterOrganizationType")]
    public class TblMasterOrganizationType
    {
        [Key]
        public int Id { get; set; }
        public string OrganizationType { get; set; }
        public bool IsActive { get; set; }
    }
}