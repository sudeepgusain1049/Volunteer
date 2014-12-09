using System.Data.Entity;
using Volunteer.Data.Models;
using VolunteerApi.DataAccess;

namespace Volunteer.Data
{
    public class VolunteerApiDbContext : DbContext
    {
        public VolunteerApiDbContext()
            : base(nameOrConnectionString:  "VolunteerApi")
        { }
        public DbSet<TblApiConsumers> ApiConsumers { get; set; }
        public DbSet<TblApiTokenManager> Tokens { get; set; }
        public DbSet<TblMasterCategories> Categories { get; set; }
        public DbSet<TblMasterCountry> Country { get; set; }
        public DbSet<TblMasterDaysOfWeek> DaysOfWeek { get; set; }
        public DbSet<TblMasterDiploma> Diplomas { get; set; }
        public DbSet<TblMasterOrganizationType> OrganizationTypes { get; set; }
        public DbSet<TblMasterSkills> Skills { get; set; }
        public DbSet<TblMasterWorkArea> WorkAreas { get; set; }
        public DbSet<TblUsers> Users { get; set; }
        public DbSet<TblOrganizationProfiles> OrganizationProfilese { get; set; }
        public DbSet<TblVolunteerProfiles> VolunteerProfiles { get; set; }
        public DbSet<TblApiLog> ApiLog { get; set; }
        public DbSet<TblMasterTimeCommitments> TimeCommitments { get; set; }
        public DbSet<TblMasterLanguages> Languages { get; set; }
        public DbSet<TblMasterScreeningQuestions> SceeningQuestions { get; set; }
        public DbSet<TblMasterJobTypes> JobTypes { get; set; }

        public DbSet<TblJobDetails> JobDetails { get; set; }
        public DbSet<TblJobAttachments> JobAttachments { get; set; }
        public DbSet<TblJobSkills> JobSkills { get; set; }
        public DbSet<TblJobDiplomas> JobDiplomas { get; set; }
        public DbSet<TblJobCommitments> JobCommitments { get; set; }
        public DbSet<TblJobAvailability> JobAvailability { get; set; }
        public DbSet<TblJobLocation> JobLocation { get; set; }
        public DbSet<TblJobQuestions> JobQuestions { get; set; }
        public DbSet<TblJobLanguages> JobLanguages { get; set; }
        public DbSet<TblJobAppropriateFor> JobAppropriateFor { get; set; }
        public DbSet<TblJobIntVolunteer> JobIntVolunteer { get; set; }
        public DbSet<TblJobAdditionalInfo> JobAdditionalInfo { get; set; }
        public DbSet<TblMasterJobAdditionalInfo> MasterJobAdditionalInfo { get; set; }
        public DbSet<TblMasterJobIntVolunteerInfo> MasterJobIntVolunteerInfo { get; set; }
        public DbSet<TblMasterJobAppropriateForInfo> MasterJobAppropriateForInfo { get; set; }
        public DbSet<TblMasterInterval> MasterInterval { get; set; }

        static VolunteerApiDbContext()
        {
            Database.SetInitializer(new VolunteerDatabaseInitializer());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUsers>().Ignore(x => x.VolunteerProfile);
            modelBuilder.Entity<TblJobDetails>().Ignore(x => x.JobAttachments);
    
        }
    }
}