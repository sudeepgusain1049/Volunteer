using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterJobAppropriateForInfoRepository : EFRepository<TblMasterJobAppropriateForInfo>
    {
        public MasterJobAppropriateForInfoRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}