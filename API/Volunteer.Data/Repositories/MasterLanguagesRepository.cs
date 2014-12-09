using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterLanguagesRepository : EFRepository<TblMasterLanguages>
    {
        public MasterLanguagesRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}

