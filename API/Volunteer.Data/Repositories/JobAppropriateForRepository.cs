using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobAppropriateForRepository : EFRepository<TblJobAppropriateFor>
    {
        public JobAppropriateForRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}