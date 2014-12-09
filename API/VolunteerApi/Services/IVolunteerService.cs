
using System.Collections.Generic;
using Volunteer.Data.Models;
using VolunteerApi.Models;

namespace VolunteerApi.Services
{
    public interface IVolunteerService : IDependency
    {
        byte[] EncryptToken(string tokenValues, byte[] key, byte[] iv);
        string DecryptToken(byte[] tokenText, byte[] key, byte[] iv);
        void TestEncryption();
        string GetCallerIp();
        string GenerateRequestToken(string consumerKey, string consumerSecret);
        TokenManager GetTokenValues(string token);
        bool IsTokenMatchDatabaseVersion(TokenManager token);

        IEnumerable<TblMasterCategories> GetMasterCategorieses();
        IEnumerable<TblMasterCountry> GetmaMasterCountries();
        IEnumerable<TblMasterDaysOfWeek> GetmMasterDaysOfWeek();
        IEnumerable<TblMasterDiploma> GetmaMasterDiplomas();
        IEnumerable<TblMasterOrganizationType> GetmTblMasterOrganizationTypes();
        IEnumerable<TblMasterSkills> GetmMasterSkills();
        IEnumerable<TblMasterWorkArea> GetMasterWorkAreas();

        IEnumerable<TblMasterTimeCommitments> GetMasterTimeCommitments();
        IEnumerable<TblMasterLanguages> GetMasterLanguages();
        IEnumerable<TblMasterScreeningQuestions> GetMasterSceeningQuestions();
        IEnumerable<TblMasterJobTypes> GetMasterJobTypes();

        IEnumerable<TblMasterJobAdditionalInfo> GetMasterJobAdditionalInfo();
        IEnumerable<TblMasterJobIntVolunteerInfo> GetMasterJobIntVolunteerInfo();
        IEnumerable<TblMasterJobAppropriateForInfo> GetMasterJobAppropriateForInfo();
        IEnumerable<TblMasterInterval> GetMasterInterval();

        TblJobDetails GetJobDTO(Job job);

        void AddOrganizationProfile(TblOrganizationProfiles organization);
        void AddVolunteerProfile(TblVolunteerProfiles volunteer);
        int AddUser(TblUsers user);
        bool AddLogging(TblApiLog log);
    }
}