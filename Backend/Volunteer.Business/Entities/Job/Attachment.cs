using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Volunteer.Business.Entities
{
    public class Attachment
    {
        public virtual Byte[] AttachmentBytes { get; set; }
        public virtual string AttachmentType { get; set; }
    }
}