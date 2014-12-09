using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobAvailabilityRepository : EFRepository<TblJobAvailability>
    {
        public JobAvailabilityRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}