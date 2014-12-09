using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Volunteer.Business.Entities
{
    public class Job
    {
        
        public virtual int JobTypeId { get; set; }
        
        public virtual string JobTitle { get; set; }
        
        public virtual string Description { get; set; }
       
        public virtual DateTime? StartDate { get; set; }
       
        public virtual DateTime? EndDate { get; set; }
     
        public virtual int? JobVisibilityId { get; set; }
        public virtual bool? IsCoverLetterNeeded { get; set; }
        public virtual bool? IsScheduleFlexible { get; set; }

        public virtual Attachment _Attachment { get; set; }
        public virtual ICollection<Skill> _Skills { get; set; }
        public virtual ICollection<Diploma> _Diplomas { get; set; }
        public virtual ICollection<Commitment> _Commitments { get; set; }
        public virtual ICollection<Availability> _Availabilities { get; set; }
        public virtual ICollection<Location> _Locations { get; set; }
        public virtual ICollection<ScreeningQuestion> _ScreeningQuestions { get; set; }
        public virtual ICollection<Language> _Languages { get; set; }
        public virtual ICollection<AppropriateFor> _AppropriateFor { get; set; }
        public virtual ICollection<InternationalVolunteerInfo> _InternationalVolunteerInfo { get; set; }
        public virtual ICollection<AdditionalJobInfo> _AdditionalJobInfo { get; set; }
    }
}