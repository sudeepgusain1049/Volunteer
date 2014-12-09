using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobDetailsRepository : EFRepository<TblJobDetails>
    {
        public JobDetailsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}