using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobAttachmentsRepository : EFRepository<TblJobAttachments>
    {
        public JobAttachmentsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}