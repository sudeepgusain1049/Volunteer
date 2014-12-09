
using System.Collections.Generic;
using Volunteer.Data.Models;

namespace VolunteerApi.Services
{
    public interface IJobService : IDependency
    {

        int AddJob(TblJobDetails job);
        void AddJobAttachments(TblJobAttachments attachment);
        void AddJobSkills(TblJobSkills jobSkill);
        void AddJobDiplomas(TblJobDiplomas jobDiploma);
        void AddJobCommitments(TblJobCommitments jobCommitment);
        void AddJobAvailability(TblJobAvailability jobAvailability);
        void AddJobLocation(TblJobLocation jobLocation);
        void AddJobQuestions(TblJobQuestions jobQuestion);
        void AddJobLanguages(TblJobLanguages jobLanguage);
        void AddJobAppropriateFor(TblJobAppropriateFor jobAppropriateFor);
        void AddJobIntVolunteer(TblJobIntVolunteer jobIntVolunteer);
        void AddJobAdditionalInfo(TblJobAdditionalInfo jobAdditionalInfo);
    }
}