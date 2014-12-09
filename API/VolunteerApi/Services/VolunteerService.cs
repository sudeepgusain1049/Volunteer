using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Volunteer.Data;
using Volunteer.Data.Models;
using Volunteer.Data.Repositories;
using VolunteerApi.Models;

namespace VolunteerApi.Services
{
    public class VolunteerService : IVolunteerService
    {
        public DbContext DbContext { get; set; }

        private readonly IApiTokenManagerRepository _tokenRepository;
        private readonly IApiConsumerRepository _consumerRepository;
        private readonly IRepository<TblMasterCategories> _categoryRepository;
        private readonly IRepository<TblMasterCountry> _CountryRepository;
        private readonly IRepository<TblMasterDaysOfWeek> _daysOfWeekRepository;
        private readonly IRepository<TblMasterDiploma> _diplomaRepository;
        private readonly IRepository<TblMasterOrganizationType> _organizationTypeRepository;
        private readonly IRepository<TblMasterSkills> _skillsRepository;
        private readonly IRepository<TblMasterWorkArea> _workAreaRepository;
        private readonly IRepository<TblOrganizationProfiles> _organizationRepository;
        private readonly IRepository<TblVolunteerProfiles> _volunteeRepository;
        private readonly IRepository<TblUsers> _usersRepository;
        private readonly IRepository<TblApiLog> _apiLogRepository;

        private readonly IRepository<TblMasterTimeCommitments> _timeCommitments;
        private readonly IRepository<TblMasterLanguages> _languages;
        private readonly IRepository<TblMasterScreeningQuestions> _sceeningQuestions;
        private readonly IRepository<TblMasterJobTypes> _jobTypes;

        private readonly IRepository<TblMasterJobAdditionalInfo> _jobAdditionalInfo;
        private readonly IRepository<TblMasterJobIntVolunteerInfo> _jobIntVolunteerInfo;
        private readonly IRepository<TblMasterJobAppropriateForInfo> _jobAppropriateForInfo;
        private readonly IRepository<TblMasterInterval> _interval;

        const string AesKey = "VolunteerApiABCD9876541230123654";
        const string IV = "9876541230123654";

        static readonly char[] padding = { '=' };

        public VolunteerService()
        {
            CreateDbContext();
            _consumerRepository = new ApiConsumerRepository(DbContext);
            _tokenRepository = new ApiTokenManagerRepository(DbContext);
            _categoryRepository = new MasterCategoriesRepository(DbContext);
            _CountryRepository = new MasterCountryRepository(DbContext);
            _daysOfWeekRepository = new MasterDaysOfWeekRepository(DbContext);
            _diplomaRepository = new MasterDiplomaRepository(DbContext);
            _organizationTypeRepository = new MasterOrganizationTypeRepository(DbContext);
            _skillsRepository = new MasterSkillsRepository(DbContext);
            _workAreaRepository = new MasterWorkAreaRepository(DbContext);
            _organizationRepository = new OrganizationProfilesRepository(DbContext);
            _volunteeRepository = new VolunteerProfilesRepository(DbContext);
            _usersRepository = new UsersRepository(DbContext);
            _apiLogRepository = new ApiLogRepository(DbContext);
            _timeCommitments = new MasterTimeCommitmentsRepository(DbContext);
            _languages = new MasterLanguagesRepository(DbContext);
            _sceeningQuestions = new MasterSceeningQuestionsRepository(DbContext);
            _jobTypes = new MasterJobTypesRepository(DbContext);
            _jobAdditionalInfo = new MasterJobAdditionalInfoRepository(DbContext);
            _jobIntVolunteerInfo = new MasterJobIntVolunteerInfoRepository(DbContext);
            _jobAppropriateForInfo = new MasterJobAppropriateForInfoRepository(DbContext);
            _interval = new MasterIntervalRepository(DbContext);
        }

        public byte[] EncryptToken(string tokenValues, byte[] key, byte[] iv)
        {
            // Check arguments. 
            if (tokenValues == null || tokenValues.Length <= 0)
                throw new ArgumentNullException("tokenValues");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("key");
            byte[] encrypted;
            // Create an Aes object 
            // with the specified key and IV. 
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                // Create a decrytor to perform the stream transform.
                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption. 
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(tokenValues);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream. 
            return encrypted;

        }

        public string DecryptToken(byte[] tokenText, byte[] key, byte[] iv)
        {
            // Check arguments. 
            if (tokenText == null || tokenText.Length <= 0)
                throw new ArgumentNullException("tokenText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("key");

            // Declare the string used to hold 
            // the decrypted text. 
            string plaintext = null;

            // Create an Aes object 
            // with the specified key and IV. 
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                // Create a decrytor to perform the stream transform.
                var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption. 
                using (var msDecrypt = new MemoryStream(tokenText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;
        }

        public void TestEncryption()
        {
            string original = "1_key_secret_127.0.0.1_ExpireDate";

            using (Aes myAes = Aes.Create())
            {

                byte[] encrypted = EncryptToken(original, Encoding.ASCII.GetBytes(AesKey), Encoding.ASCII.GetBytes(IV));

                string decrypted = DecryptToken(encrypted, Encoding.ASCII.GetBytes(AesKey), Encoding.ASCII.GetBytes(IV));
            }
        }

        public string GetCallerIp()
        {
            var ip = HttpContext.Current.Request.RequestContext.HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null ? HttpContext.Current.Request.RequestContext.HttpContext.Request["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.RequestContext.HttpContext.Request["REMOTE_ADDR"];
            return ip;
        }

        public string GenerateRequestToken(string consumerKey, string consumerSecret)
        {
            var consumer = _consumerRepository.GetByParams(consumerKey, consumerSecret);
            // check consumer secret is the same as passed
            if (consumer == null)
                return string.Empty;

            var callerIp = GetCallerIp();
            var expirationDate = DateTime.Now.AddMinutes(10);

            var originalRequestToken = string.Format("{0}_{1}_{2}_{3}_{4}", consumer.UserId, consumer.ConsumerKey,
                consumer.ConsumerSecret, callerIp, expirationDate);

            var encryptedToken = EncryptToken(originalRequestToken, Encoding.ASCII.GetBytes(AesKey), Encoding.ASCII.GetBytes(IV));
            //var token = Convert.ToBase64String(encryptedToken);
            var token = Convert.ToBase64String(encryptedToken).TrimEnd(padding).Replace('+', '-').Replace('/', '_');

            //  get token from database if exist
            var tokenManger = _tokenRepository.GetByParams(new TokenManager
            {
                UserId = consumer.UserId,
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret,
                CallerIp = callerIp
            });
           

            if (tokenManger == null)
            {
                //  add token to database
                _tokenRepository.Add(new TblApiTokenManager
                {
                    UserId = consumer.UserId,
                    ConsumerKey = consumer.ConsumerKey,
                    ConsumerSecret = consumer.ConsumerSecret,
                    CallerIp = callerIp,
                    ExpirationDate = expirationDate,
                    Token = token
                });
                _tokenRepository.Commit();
            }
            else
            { // update current instace of token manager
                tokenManger.ExpirationDate = expirationDate;
                tokenManger.Token = token;
                _tokenRepository.Update(tokenManger);
                _tokenRepository.Commit();
            }

            return HttpUtility.UrlEncode(token);
        }

        /// <summary>
        /// Gets token internal values
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public TokenManager GetTokenValues(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return new TokenManager
                {
                    UserId = 0,
                    ConsumerKey = string.Empty,
                    ConsumerSecret = string.Empty,
                    CallerIp = string.Empty,
                    ExpirationDate = DateTime.Now,
                    Token = token
                };

            string incoming = token.Replace('_', '/').Replace('-', '+');
            switch (token.Length % 4)
            {
                case 2: incoming += "=="; break;
                case 3: incoming += "="; break;
            }
            token = incoming;

            var decryptedToken = DecryptToken(Convert.FromBase64String(token), Encoding.ASCII.GetBytes(AesKey), Encoding.ASCII.GetBytes(IV));
            var values = decryptedToken.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            var tokenManager = new TokenManager
            {
                UserId = int.Parse(values[0]),
                ConsumerKey = values[1],
                ConsumerSecret = values[2],
                CallerIp = values[3],
                ExpirationDate = DateTime.Parse(values[4]),
                Token = token
            };
            // todo: get user from datbase to check active and 

           // in action check expiration and return expired or not

            return tokenManager;
        }

        public bool IsTokenMatchDatabaseVersion(TokenManager token)
        {
            var tokenManager = _tokenRepository.GetByParams(token);
            if (tokenManager != null)
            {
                return tokenManager.Token == token.Token;
            }

            return false;
        }

        public IEnumerable<TblMasterCategories> GetMasterCategorieses()
        {
            IEnumerable<TblMasterCategories> lst = new List<TblMasterCategories>();
            try
            {
                lst = _categoryRepository.GetAll();
                if (lst != null)
                {
                    lst = lst.Where(x => x.IsActive);
                }
            }
            catch (Exception ex)
            {
            }
            return lst;
        }

        public IEnumerable<TblMasterCountry> GetmaMasterCountries()
        {
            return _CountryRepository.GetAll();
        }

        public IEnumerable<TblMasterDaysOfWeek> GetmMasterDaysOfWeek()
        {
            return _daysOfWeekRepository.GetAll();
        }

        public IEnumerable<TblMasterDiploma> GetmaMasterDiplomas()
        {
            var lst = _diplomaRepository.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterOrganizationType> GetmTblMasterOrganizationTypes()
        {
            var lst = _organizationTypeRepository.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterSkills> GetmMasterSkills()
        {
            var lst = _skillsRepository.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterWorkArea> GetMasterWorkAreas()
        {
            var lst = _workAreaRepository.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterTimeCommitments> GetMasterTimeCommitments()
        {
            var lst = _timeCommitments.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterLanguages> GetMasterLanguages()
        {
            var lstLanguages = _languages.GetAll();
            return lstLanguages.Where(x => x.IsActive);
        }

        public IEnumerable<TblMasterScreeningQuestions> GetMasterSceeningQuestions()
        {
            var lst = _sceeningQuestions.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterJobTypes> GetMasterJobTypes()
        {
            var lst = _jobTypes.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterJobAdditionalInfo> GetMasterJobAdditionalInfo()
        {
            var lst = _jobAdditionalInfo.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterJobIntVolunteerInfo> GetMasterJobIntVolunteerInfo()
        {
            var lst = _jobIntVolunteerInfo.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterJobAppropriateForInfo> GetMasterJobAppropriateForInfo()
        {
            var lst = _jobAppropriateForInfo.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public IEnumerable<TblMasterInterval> GetMasterInterval()
        {
            var lst = _interval.GetAll();
            if (lst != null)
            {
                lst = lst.Where(x => x.IsActive);
            }
            return lst;
        }

        public TblJobDetails GetJobDTO(Job job)
        {
            var jobDTO = new TblJobDetails
            {
                JobTypeId = job.JobTypeId,
                JobTitle = job.JobTitle,
                Description = job.Description,
                StartDate = job.StartDate,
                EndDate = job.EndDate,
                JobVisibilityId = job.JobVisibilityId,
                IsCoverLetterNeeded = job.IsCoverLetterNeeded,
                IsScheduleFlexible = job.IsScheduleFlexible
            };

            if (job._Attachment != null)
            {
                var jobAttachments = new TblJobAttachments
                {
                    Attachment = job._Attachment.AttachmentBytes,
                    AttachmentType = job._Attachment.AttachmentType
                };
                jobDTO.JobAttachments = jobAttachments;
            }

            if (job._Skills != null)
            {
                List<TblJobSkills> jobSkills = new List<TblJobSkills>();
                foreach (Skill skill in job._Skills)
                {
                    if (!String.IsNullOrEmpty(skill.SkillName))
                    {
                        var _skill = GetmMasterSkills().Where(x => x.SkillName.ToUpper() == skill.SkillName.ToUpper()).FirstOrDefault();
                        if (_skill != null)
                        {
                            var jobSKill = new TblJobSkills { SkillId = _skill.Id };
                            jobSkills.Add(jobSKill);
                        }
                    }
                }
                jobDTO.JobSkills = jobSkills;
            }

            if (job._Diplomas != null)
            {
                List<TblJobDiplomas> jobDiplomas = new List<TblJobDiplomas>();
                foreach (Diploma diploma in job._Diplomas)
                {
                    if (!String.IsNullOrEmpty(diploma.DiplomaName))
                    {
                        var _diploma = GetmaMasterDiplomas().Where(x => x.DiplomaName.ToUpper() == diploma.DiplomaName.ToUpper()).FirstOrDefault();
                        if (_diploma != null)
                        {
                            var joDiploma = new TblJobDiplomas { DiplomaId = _diploma.Id };
                            jobDiplomas.Add(joDiploma);
                        }
                    }
                }
                jobDTO.JobDiplomas = jobDiplomas;
            }
            if (job._Commitments != null)
            {
                List<TblJobCommitments> jobCommitments = new List<TblJobCommitments>();
                foreach (Commitment commitment in job._Commitments)
                {
                    if (!String.IsNullOrEmpty(commitment.CommitmentName))
                    {
                        var _commitment = GetMasterTimeCommitments().Where(x => x.Commitment.ToUpper() == commitment.CommitmentName.ToUpper()).FirstOrDefault();
                        if (_commitment != null)
                        {
                            var jobCommitment = new TblJobCommitments { CommitmentId = _commitment.Id };
                            jobCommitments.Add(jobCommitment);
                        }
                    }
                }
                jobDTO.JobCommitments = jobCommitments;
            }
            if (job._Availabilities != null)
            {
                List<TblJobAvailability> jobAvailabillities = new List<TblJobAvailability>();
                foreach (Availability availability in job._Availabilities)
                {
                    if (!String.IsNullOrEmpty(availability.DayName) && !String.IsNullOrEmpty(availability.IntervalName))
                    {
                        var _day = GetmMasterDaysOfWeek().Where(x => x.DaysOfweek.ToUpper() == availability.DayName.ToUpper()).FirstOrDefault();
                        var _interval = GetMasterInterval().Where(x => x.Interval.ToUpper() == availability.IntervalName.ToUpper()).FirstOrDefault();
                        if (_day != null && _interval != null)
                        {
                            var jobAvailability = new TblJobAvailability { DayId = _day.Id, IntervalId = _interval.Id };
                            jobAvailabillities.Add(jobAvailability);
                        }
                    }
                }
                jobDTO.JobAvailability = jobAvailabillities;
            }
            if (job._Languages != null)
            {
                List<TblJobLanguages> jobLanguages = new List<TblJobLanguages>();
                foreach (Language language in job._Languages)
                {
                    if (!String.IsNullOrEmpty(language.LanguageName))
                    {
                        var _language = GetMasterLanguages().Where(x => x.Language.ToUpper() == language.LanguageName.ToUpper()).FirstOrDefault();
                        if (_language != null)
                        {
                            var jobLanguage = new TblJobLanguages { LanguageId = _language.Id };
                            jobLanguages.Add(jobLanguage);
                        }
                    }
                }
                jobDTO.JobLanguages = jobLanguages;
            }
            if (job._AppropriateFor != null)
            {
                List<TblJobAppropriateFor> jobAppropriateFors = new List<TblJobAppropriateFor>();
                foreach (AppropriateFor appropriateFor in job._AppropriateFor)
                {
                    if (!String.IsNullOrEmpty(appropriateFor.AppropriateForText))
                    {
                        var _appropriateFor = GetMasterJobAppropriateForInfo().Where(x => x.AppropriateForInfo.ToUpper() == appropriateFor.AppropriateForText.ToUpper()).FirstOrDefault();
                        if (_appropriateFor != null)
                        {
                            var jobAppropriateFor = new TblJobAppropriateFor { AppropriateForId = _appropriateFor.Id };
                            jobAppropriateFors.Add(jobAppropriateFor);
                        }
                    }
                }
                jobDTO.JobAppropriateFor = jobAppropriateFors;
            }
            if (job._InternationalVolunteerInfo != null)
            {
                List<TblJobIntVolunteer> jobIntVolunteer = new List<TblJobIntVolunteer>();
                foreach (InternationalVolunteerInfo intVolunteer in job._InternationalVolunteerInfo)
                {
                    if (!String.IsNullOrEmpty(intVolunteer.VolunteerInfo))
                    {
                        var _intVolunteer = GetMasterJobIntVolunteerInfo().Where(x => x.IntVolunteerInfo.ToUpper() == intVolunteer.VolunteerInfo.ToUpper()).FirstOrDefault();
                        if (_intVolunteer != null)
                        {
                            var jobInternationalVolunteer = new TblJobIntVolunteer { IntVolunteerId = _intVolunteer.Id };
                            jobIntVolunteer.Add(jobInternationalVolunteer);
                        }
                    }
                }
                jobDTO.JobIntVolunteer = jobIntVolunteer;
            }
            if (job._AdditionalJobInfo != null)
            {
                List<TblJobAdditionalInfo> jobAdditionalInfo = new List<TblJobAdditionalInfo>();
                foreach (AdditionalJobInfo additionalInfo in job._AdditionalJobInfo)
                {
                    if (!String.IsNullOrEmpty(additionalInfo.AdditionalInfo))
                    {
                        var _AdditionalInfo = GetMasterJobAdditionalInfo().Where(x => x.AdditionalInfo.ToUpper() == additionalInfo.AdditionalInfo.ToUpper()).FirstOrDefault();
                        if (_AdditionalInfo != null)
                        {
                            var jobAdditional = new TblJobAdditionalInfo { AdditionalInfoId = _AdditionalInfo.Id };
                            jobAdditionalInfo.Add(jobAdditional);
                        }
                    }
                }
                jobDTO.JobAdditionalInfo = jobAdditionalInfo;
            }

            //Location
            //Screening
            jobDTO.IsActive = true;

            return jobDTO;
        }



        public void AddOrganizationProfile(TblOrganizationProfiles organization)
        {
            var organizations = _organizationRepository.GetAll();
            var orgId = organizations.Any() ? (organizations.Select(e => e.Id).Max() + 1) : 1;
            organization.Id = orgId;

            _organizationRepository.Add(organization);

        }

        public void AddVolunteerProfile(TblVolunteerProfiles volunteer)
        {

            var volunteers = _volunteeRepository.GetAll();
            var volunteerId = volunteers.Any() ? (volunteers.Select(e => e.Id).Max() + 1) : 1;

            volunteer.Id = volunteerId;

            _volunteeRepository.Add(volunteer);
        }

        public int AddUser(TblUsers user)
        {
            if (user.Id == 0)
            {
                var users = _usersRepository.GetAll();
                user.Id = users.Any() ? users.Select(e => e.Id).Max() + 1 : 1;
            }

            _usersRepository.Add(user);

            if (user.VolunteerProfile != null)
            {
                user.VolunteerProfile.User = user;
                user.VolunteerProfile.ProfileImage = user.VolunteerProfile.ProfileImage;
                AddVolunteerProfile(user.VolunteerProfile);
            }

            if (user.OrganizationProfiles.Any())
                foreach (var org in user.OrganizationProfiles)
                {
                    org.User = user;
                    AddOrganizationProfile(org);
                }

            _usersRepository.Commit();

            return user.Id;
        }

        public bool AddLogging(TblApiLog log)
        {
            var added = false;
            if (log != null)
            {
                _apiLogRepository.Add(log);
                added = log.Id > 0;
            }
            _apiLogRepository.Commit();
            return added;
        }

        private void CreateDbContext()
        {
            DbContext = new VolunteerApiDbContext();
            //to make serialize
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
        }

        ~VolunteerService()
        {
            DbContext.Dispose();
        }
    }
}