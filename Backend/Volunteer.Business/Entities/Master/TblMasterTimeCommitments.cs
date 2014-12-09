using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterTimeCommitments
    {
        public int Id { get; set; }
        public string Commitment { get; set; }
        public bool IsActive { get; set; }
    }
}
