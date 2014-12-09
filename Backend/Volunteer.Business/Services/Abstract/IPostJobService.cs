using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volunteer.Business.Entities;

namespace Volunteer.Business.Services
{
    public interface IPostJobService
    {
        List<TblMasterLanguages> GetMasterLanguages();
        List<TblMasterCountry> GetMasterCountries();
        List<TblMasterDaysOfWeek> GetMasterDaysOfWeek();
        List<TblMasterDiploma> GetMasterDiplomas();
        List<TblMasterSkills> GetMasterSkills();
        List<TblMasterTimeCommitments> GetMasterTimeCommitments();
        List<TblMasterScreeningQuestions> GetMasterSceeningQuestions();
        List<TblMasterJobTypes> GetMasterJobTypes();
        List<TblMasterJobAdditionalInfo> GetMasterJobAdditionalInfo();
        List<TblMasterJobIntVolunteerInfo> GetMasterJobIntVolunteerInfo();
        List<TblMasterJobAppropriateForInfo> GetMasterJobAppropriateForInfo();
        List<TblMasterInterval> GetMasterInterval();
        void AddJob(Job jObject);

    }
}
