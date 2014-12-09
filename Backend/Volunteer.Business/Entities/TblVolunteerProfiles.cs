using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
   
    public class TblVolunteerProfiles
    {
        public virtual int Id { get; set; }
        public virtual TblUsers User { get; set; }
        public virtual int UserId { get; set; }
        public virtual byte[] ProfileImage { get; set; }
        public virtual string AboutmeText { get; set; }
        public virtual string LookingForText { get; set; }
        public virtual string Categories { get; set; }
        public virtual string DesiredWorkArea { get; set; }
        public virtual string Skills { get; set; }
        public virtual string Diploma { get; set; }
        public virtual string TimeAvailability { get; set; }
        public virtual string DaysOfWeek { get; set; }
        public virtual string ProfileVisibility { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
        public virtual bool IsActive { get; set; }
    }
}