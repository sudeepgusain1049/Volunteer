using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace VolunteerApi.Models
{
    public class ScreeningQuestion
    {
        [Required]
        public virtual List<Int32> ExistingQuestionIDs { get; set; }
        [Required]
        public virtual List<String> AdditionalQuestions { get; set; }
    }
}