using System;
using System.Collections.Generic;
using System.Linq;

namespace Volunteer.Business.Entities
{
    public class TblMasterScreeningQuestions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public bool IsActive { get; set; }
    }
}
