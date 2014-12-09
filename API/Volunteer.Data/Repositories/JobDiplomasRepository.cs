using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobDiplomasRepository : EFRepository<TblJobDiplomas>
    {
        public JobDiplomasRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}