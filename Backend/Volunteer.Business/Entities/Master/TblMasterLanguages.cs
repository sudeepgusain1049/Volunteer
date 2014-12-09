using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterLanguages
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
    }
}
