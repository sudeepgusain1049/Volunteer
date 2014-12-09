using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Volunteer.Business.Entities
{
    public class Location
    {
        public virtual String Address { get; set; }
        public virtual String ZipCode { get; set; }
        public virtual String Country { get; set; }
    }
}