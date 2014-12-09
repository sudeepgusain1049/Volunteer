using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class ApiLogRepository : EFRepository<TblApiLog>
    {
        public ApiLogRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}