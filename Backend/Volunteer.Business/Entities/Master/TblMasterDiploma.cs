using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterDiploma
    {
        public int Id { get; set; }
        public string DiplomaName { get; set; }
        public bool IsActive { get; set; }
    }
}