using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterWorkArea
    {
        public int Id { get; set; }
        public string WorkAreaName { get; set; }
        public bool IsActive { get; set; }
    }
}