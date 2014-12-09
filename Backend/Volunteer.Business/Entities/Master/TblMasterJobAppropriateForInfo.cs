using System;
using System.Collections.Generic;
using System.Linq;
namespace Volunteer.Business.Entities
{
    public class TblMasterJobAppropriateForInfo
    {
        public int Id { get; set; }
        public string AppropriateForInfo { get; set; }
        public bool IsActive { get; set; }
    }
}
