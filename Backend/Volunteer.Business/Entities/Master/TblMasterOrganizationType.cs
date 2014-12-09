using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterOrganizationType
    {
        public int Id { get; set; }
        public string OrganizationType { get; set; }
        public bool IsActive { get; set; }
    }
}