using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class UsersRepository : EFRepository<TblUsers>
    {
        public UsersRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}