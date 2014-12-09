using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterTimeCommitmentsRepository : EFRepository<TblMasterTimeCommitments>
    {
        public MasterTimeCommitmentsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}
