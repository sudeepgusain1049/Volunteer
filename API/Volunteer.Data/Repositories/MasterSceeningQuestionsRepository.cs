using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterSceeningQuestionsRepository : EFRepository<TblMasterScreeningQuestions>
    {
        public MasterSceeningQuestionsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}

