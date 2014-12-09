using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblJobAdditionalInfo")]
    public class TblJobAdditionalInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual TblJobDetails Job { get; set; }
        public virtual int JobId { get; set; }
        public virtual TblMasterJobAdditionalInfo AdditionalInfo { get; set; }
        public virtual int AdditionalInfoId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
