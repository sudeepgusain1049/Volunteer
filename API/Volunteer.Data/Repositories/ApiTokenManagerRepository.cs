using System.Data.Entity;
using System.Linq;
using Volunteer.Data.Models;
using VolunteerApi.DataAccess;

namespace Volunteer.Data.Repositories
{
    public class ApiTokenManagerRepository : EFRepository<TblApiTokenManager>, IApiTokenManagerRepository
    {
        public ApiTokenManagerRepository(DbContext dbContext)
            : base(dbContext) { }


        public TblApiTokenManager GetByParams(TokenManager tokenManager)
        {
            return DbSet.FirstOrDefault(e => e.UserId == tokenManager.UserId
                && e.ConsumerKey == tokenManager.ConsumerKey
                && e.ConsumerSecret == tokenManager.ConsumerSecret
                && e.CallerIp == tokenManager.CallerIp);
        }
    }
}