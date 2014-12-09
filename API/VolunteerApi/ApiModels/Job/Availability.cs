using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace VolunteerApi.Models
{
    public class Availability
    {
        [Required]
        public virtual String IntervalName { get; set; }
        [Required]
        public virtual String DayName { get; set; }
    }
}