using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterCountryRepository : EFRepository<TblMasterCountry>
    {
        public MasterCountryRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}