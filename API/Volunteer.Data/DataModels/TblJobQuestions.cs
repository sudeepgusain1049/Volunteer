using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblJobQuestions")]
    public class TblJobQuestions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual TblJobDetails Job { get; set; }
        public virtual int JobId { get; set; }
        public virtual TblMasterScreeningQuestions Question { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual string Questions { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
