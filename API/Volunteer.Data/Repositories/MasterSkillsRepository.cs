using System.Data.Entity;
using Volunteer.Data.Models;

namespace Volunteer.Data.Repositories
{
    public class MasterSkillsRepository : EFRepository<TblMasterSkills>
    {
        public MasterSkillsRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}