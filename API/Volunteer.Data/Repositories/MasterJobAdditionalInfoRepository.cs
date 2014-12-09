using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterJobAdditionalInfoRepository : EFRepository<TblMasterJobAdditionalInfo>
    {
        public MasterJobAdditionalInfoRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}