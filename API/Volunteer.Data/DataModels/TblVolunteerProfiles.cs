using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblVolunteerProfiles")]
    public class TblVolunteerProfiles
    {
        //[Key, ForeignKey("User")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Id { get; set; }
        public virtual TblUsers User { get; set; }
        public virtual int UserId { get; set; }

        [Column(TypeName = "image")]
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