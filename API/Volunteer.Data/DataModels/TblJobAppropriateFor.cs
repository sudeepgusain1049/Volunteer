using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblJobAppropriateFor")]
    public class TblJobAppropriateFor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual TblJobDetails Job { get; set; }
        public virtual int JobId { get; set; }
        public virtual TblMasterJobAppropriateForInfo AppropriateFor { get; set; }
        public virtual int AppropriateForId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
