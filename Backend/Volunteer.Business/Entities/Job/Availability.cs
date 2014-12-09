using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Volunteer.Business.Entities
{
    public class Availability
    {
        public virtual String IntervalName { get; set; }
        public virtual String DayName { get; set; }
    }
}