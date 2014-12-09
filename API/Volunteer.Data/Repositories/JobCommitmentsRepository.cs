using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobCommitmentsRepository : EFRepository<TblJobCommitments>
    {
        public JobCommitmentsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}