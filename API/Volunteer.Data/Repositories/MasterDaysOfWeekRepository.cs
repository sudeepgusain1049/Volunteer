using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterDaysOfWeekRepository : EFRepository<TblMasterDaysOfWeek>
    {
        public MasterDaysOfWeekRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}