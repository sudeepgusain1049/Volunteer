using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace VolunteerApi.Models
{
    public class Attachment
    {
        [Required]
        public virtual Byte[] AttachmentBytes { get; set; }
        [Required]
        public virtual string AttachmentType { get; set; }
    }
}