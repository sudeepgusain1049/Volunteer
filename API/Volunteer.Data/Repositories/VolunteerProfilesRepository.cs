using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class VolunteerProfilesRepository : EFRepository<TblVolunteerProfiles>
    {
        public VolunteerProfilesRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}