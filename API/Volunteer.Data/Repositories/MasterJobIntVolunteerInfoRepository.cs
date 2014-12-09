using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterJobIntVolunteerInfoRepository : EFRepository<TblMasterJobIntVolunteerInfo>
    {
        public MasterJobIntVolunteerInfoRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}