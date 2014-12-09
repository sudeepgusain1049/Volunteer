using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace VolunteerApi.Models
{
    public class AdditionalJobInfo
    {
        [Required]
        public virtual String AdditionalInfo { get; set; }
    }
}