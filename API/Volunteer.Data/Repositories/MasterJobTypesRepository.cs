using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterJobTypesRepository : EFRepository<TblMasterJobTypes>
    {
        public MasterJobTypesRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}

