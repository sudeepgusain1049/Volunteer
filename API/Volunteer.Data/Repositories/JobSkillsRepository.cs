using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class JobSkillsRepository : EFRepository<TblJobSkills>
    {
        public JobSkillsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}