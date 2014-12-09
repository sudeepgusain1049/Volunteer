using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobIntVolunteerRepository : EFRepository<TblJobIntVolunteer>
    {
        public JobIntVolunteerRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}