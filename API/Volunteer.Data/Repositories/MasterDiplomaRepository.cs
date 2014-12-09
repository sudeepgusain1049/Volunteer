using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterDiplomaRepository : EFRepository<TblMasterDiploma>
    {
        public MasterDiplomaRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}