using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Volunteer.Data.Models
{
    [Table("TblJobDetails")]
    public class TblJobDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual TblMasterJobTypes JobType { get; set; }
        [Required]
        public virtual int JobTypeId { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual int? JobVisibilityId { get; set; }
        public virtual bool? IsCoverLetterNeeded { get; set; }
        public virtual bool? IsScheduleFlexible { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
        public virtual bool IsActive { get; set; }
        //References
        public virtual TblJobAttachments JobAttachments { get; set; }
        public virtual ICollection<TblJobSkills> JobSkills { get; set; }

        public virtual ICollection<TblJobDiplomas> JobDiplomas { get; set; }
        public virtual ICollection<TblJobCommitments> JobCommitments { get; set; }
        public virtual ICollection<TblJobAvailability> JobAvailability { get; set; }
        public virtual ICollection<TblJobLocation> JobLocation { get; set; }
        public virtual ICollection<TblJobQuestions> JobQuestions { get; set; }
        public virtual ICollection<TblJobLanguages> JobLanguages { get; set; }
        public virtual ICollection<TblJobAppropriateFor> JobAppropriateFor { get; set; }
        public virtual ICollection<TblJobIntVolunteer> JobIntVolunteer { get; set; }
        public virtual ICollection<TblJobAdditionalInfo> JobAdditionalInfo { get; set; }

    }
}
