using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterOrganizationTypeRepository : EFRepository<TblMasterOrganizationType>
    {
        public MasterOrganizationTypeRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}