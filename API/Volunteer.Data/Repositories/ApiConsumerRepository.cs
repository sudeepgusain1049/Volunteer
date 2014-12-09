using System.Data.Entity;
using System.Linq;
using Volunteer.Data.Models;


namespace Volunteer.Data.Repositories
{
    public class ApiConsumerRepository : EFRepository<TblApiConsumers>, IApiConsumerRepository
    {
        public ApiConsumerRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public TblApiConsumers GetByParams(string conusumerKey, string consumerSecret)
        {
            return DbSet.FirstOrDefault(e => e.ConsumerKey == conusumerKey && e.ConsumerSecret == consumerSecret);
        }
    }
}