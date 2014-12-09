using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblMasterCountry")]
    public class TblMasterCountry
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}