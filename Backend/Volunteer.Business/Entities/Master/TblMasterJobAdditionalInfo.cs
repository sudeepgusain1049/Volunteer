using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{

    public class TblMasterJobAdditionalInfo
    {
        public int Id { get; set; }
        public string AdditionalInfo { get; set; }
        public bool IsActive { get; set; }
    }
}
