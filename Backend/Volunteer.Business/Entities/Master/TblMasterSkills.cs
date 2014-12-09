using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterSkills
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public bool IsActive { get; set; }
    }
}