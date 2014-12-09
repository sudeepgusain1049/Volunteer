using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public interface IApiConsumerRepository : IRepository<TblApiConsumers>
    {
        TblApiConsumers GetByParams(string conusumerKey, string consumerSecret);
    }
}