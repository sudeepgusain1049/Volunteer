using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterWorkAreaRepository : EFRepository<TblMasterWorkArea>
    {
        public MasterWorkAreaRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}