using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterDaysOfWeek
    {
        public int Id { get; set; }
        public string DaysOfweek { get; set; }
        public bool IsActive { get; set; }
    }
}