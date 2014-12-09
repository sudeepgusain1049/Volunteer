using System.Data.Entity;
using System.Linq;
using Volunteer.Data.Models;


namespace Volunteer.Data.Repositories
{
    public class MasterCategoriesRepository : EFRepository<TblMasterCategories>
    {
        public MasterCategoriesRepository(DbContext dbContext)
            : base(dbContext)
        {}
    }
}