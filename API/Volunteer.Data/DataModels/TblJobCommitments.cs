using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblJobCommitments")]
    public class TblJobCommitments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual TblJobDetails Job { get; set; }
        public virtual int JobId { get; set; }
        public virtual TblMasterTimeCommitments Commitment { get; set; }
        public virtual int CommitmentId { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
