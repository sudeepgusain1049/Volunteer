using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{

    public class TblMasterJobTypes
    {
        public int Id { get; set; }
        public string JobType { get; set; }
        public bool IsActive { get; set; }
    }
}
