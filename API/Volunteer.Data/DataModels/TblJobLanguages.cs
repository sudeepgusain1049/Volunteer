﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer.Data.Models
{
    [Table("TblJobLanguages")]
    public class TblJobLanguages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual TblJobDetails Job { get; set; }
        public virtual int JobId { get; set; }
        public virtual TblMasterLanguages Language { get; set; }
        public virtual int LanguageId { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
