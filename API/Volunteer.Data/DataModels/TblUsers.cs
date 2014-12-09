using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblUsers")]
    public class TblUsers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string City { get; set; }
        public virtual int Country { get; set; }
        public virtual bool? IsEmailSubsription { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual TblVolunteerProfiles VolunteerProfile { get; set; }
        public virtual ICollection<TblOrganizationProfiles> OrganizationProfiles { get; set; }
    }
}