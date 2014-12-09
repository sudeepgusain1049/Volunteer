using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobQuestionsRepository : EFRepository<TblJobQuestions>
    {
        public JobQuestionsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}