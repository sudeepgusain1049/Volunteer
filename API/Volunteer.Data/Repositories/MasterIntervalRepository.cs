using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterIntervalRepository : EFRepository<TblMasterInterval>
    {
        public MasterIntervalRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}