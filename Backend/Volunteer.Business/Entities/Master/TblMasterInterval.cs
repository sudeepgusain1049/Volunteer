using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterInterval
    {
        public int Id { get; set; }
        public string Interval { get; set; }
        public bool IsActive { get; set; }
    }
}
