using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public interface IApiTokenManagerRepository:IRepository<TblApiTokenManager>
    {
        TblApiTokenManager GetByParams(TokenManager tokenManager);
    }
}