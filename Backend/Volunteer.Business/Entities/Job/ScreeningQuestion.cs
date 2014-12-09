using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Volunteer.Business.Entities
{
    public class ScreeningQuestion
    {
        public virtual Int32 QuestionId { get; set; }
        public virtual String QuestionName { get; set; }
    }
}