using System.Data.Entity;
using Volunteer.Data;

namespace VolunteerApi.DataAccess
{
    public class VolunteerDatabaseInitializer : CreateDatabaseIfNotExists<VolunteerApiDbContext>
    {
    }
}