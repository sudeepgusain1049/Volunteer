using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblOrganizationProfiles")]
    public class TblOrganizationProfiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Id { get; set; }
        public virtual TblUsers User { get; set; }
        public virtual int UserId { get; set; }
        public virtual string OrganizatioName { get; set; }
        public virtual string OrganizationNickName { get; set; }
        public virtual bool? IsRegistered { get; set; }
        public virtual string RegisterationNumber { get; set; }
        public virtual int? OrganizationTypeId { get; set; }
        public virtual bool? IsActive { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}