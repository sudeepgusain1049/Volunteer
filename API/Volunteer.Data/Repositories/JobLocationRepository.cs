using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobLocationRepository : EFRepository<TblJobLocation>
    {
        public JobLocationRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}