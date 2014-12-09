using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace VolunteerApi.Models
{
    public class Location
    {
        [Required]
        public virtual String Address { get; set; }
        [Required]
        public virtual String ZipCode { get; set; }
        [Required]
        public virtual String Country { get; set; }
    }
}