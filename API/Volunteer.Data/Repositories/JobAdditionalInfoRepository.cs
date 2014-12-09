using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobAdditionalInfoRepository : EFRepository<TblJobAdditionalInfo>
    {
        public JobAdditionalInfoRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}