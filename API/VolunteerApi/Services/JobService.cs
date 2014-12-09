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


namespace VolunteerApi.Services
{
    public class JobService : IJobService
    {
        public DbContext DbContext { get; set; }


        private readonly IRepository<TblJobDetails> _jobDetails;
        private readonly IRepository<TblJobAttachments> _jobAttachments;
        private readonly IRepository<TblJobSkills> _jobSkills;
        private readonly IRepository<TblJobDiplomas> _jobDiplomas;
        private readonly IRepository<TblJobCommitments> _jobCommitments;
        private readonly IRepository<TblJobAvailability> _jobAvailability;
        private readonly IRepository<TblJobLocation> _jobLocation;
        private readonly IRepository<TblJobQuestions> _jobQuestions;
        private readonly IRepository<TblJobLanguages> _jobLanguages;
        private readonly IRepository<TblJobAppropriateFor> _jobAppropriateFor;
        private readonly IRepository<TblJobIntVolunteer> _jobIntVolunteer;
        private readonly IRepository<TblJobAdditionalInfo> _jobAdditionalInfo;



        public JobService()
        {
            CreateDbContext();

            _jobDetails = new JobDetailsRepository(DbContext);
            _jobAttachments = new JobAttachmentsRepository(DbContext);
            _jobSkills = new JobSkillsRepository(DbContext);
            _jobDiplomas = new JobDiplomasRepository(DbContext);
            _jobCommitments = new JobCommitmentsRepository(DbContext);
            _jobAvailability = new JobAvailabilityRepository(DbContext);
            _jobLocation = new JobLocationRepository(DbContext);
            _jobQuestions = new JobQuestionsRepository(DbContext);
            _jobLanguages = new JobLanguagesRepository(DbContext);
            _jobAppropriateFor = new JobAppropriateForRepository(DbContext);
            _jobIntVolunteer = new JobIntVolunteerRepository(DbContext);
            _jobAdditionalInfo = new JobAdditionalInfoRepository(DbContext);
        }

        public void AddJobAttachments(TblJobAttachments attachment)
        {
            var attachments = _jobAttachments.GetAll();
            attachment.CreatedDate = DateTime.Now;
            _jobAttachments.Add(attachment);
        }
        public void AddJobSkills(TblJobSkills jobSkill)
        {
            var skills = _jobSkills.GetAll();
            jobSkill.CreatedDate = DateTime.Now;
            _jobSkills.Add(jobSkill);
        }
        public void AddJobDiplomas(TblJobDiplomas jobDiploma)
        {
            var diplomas = _jobDiplomas.GetAll();
            jobDiploma.CreatedDate = DateTime.Now;
            _jobDiplomas.Add(jobDiploma);
        }
        public void AddJobCommitments(TblJobCommitments jobCommitment)
        {
            var commitments = _jobCommitments.GetAll();
            jobCommitment.CreatedDate = DateTime.Now;
            _jobCommitments.Add(jobCommitment);
        }
        public void AddJobAvailability(TblJobAvailability jobAvailability)
        {
            var avilability = _jobAvailability.GetAll();
            jobAvailability.CreatedDate = DateTime.Now;
            _jobAvailability.Add(jobAvailability);
        }
        public void AddJobLocation(TblJobLocation jobLocation)
        {
            var locations = _jobLocation.GetAll();
            jobLocation.CreatedDate = DateTime.Now;
            _jobLocation.Add(jobLocation);
        }
        public void AddJobQuestions(TblJobQuestions jobQuestion)
        {
            var questions = _jobQuestions.GetAll();
            jobQuestion.CreatedDate = DateTime.Now;
            _jobQuestions.Add(jobQuestion);
        }
        public void AddJobLanguages(TblJobLanguages jobLanguage)
        {
            var languages = _jobLanguages.GetAll();
            jobLanguage.CreatedDate = DateTime.Now;
            _jobLanguages.Add(jobLanguage);
        }
        public void AddJobAppropriateFor(TblJobAppropriateFor jobAppropriateFor)
        {
            var appropriateFors = _jobAppropriateFor.GetAll();
            jobAppropriateFor.CreatedDate = DateTime.Now;
            _jobAppropriateFor.Add(jobAppropriateFor);
        }
        public void AddJobIntVolunteer(TblJobIntVolunteer jobIntVolunteer)
        {
            var jobIntVolunteers = _jobIntVolunteer.GetAll();
            jobIntVolunteer.CreatedDate = DateTime.Now;
            _jobIntVolunteer.Add(jobIntVolunteer);
        }
        public void AddJobAdditionalInfo(TblJobAdditionalInfo jobAdditionalInfo)
        {
            var jobAdditionalInfos = _jobAdditionalInfo.GetAll();
            jobAdditionalInfo.CreatedDate = DateTime.Now;
            _jobAdditionalInfo.Add(jobAdditionalInfo);
        }

        public int AddJob(TblJobDetails job)
        {
            if (job.Id == 0)
            {
                var jobs = _jobDetails.GetAll();
                job.CreatedDate = DateTime.Now;
            }
            else
            {
                job.UpdatedDate = DateTime.Now;
            }

            _jobDetails.Add(job);

            if (job.JobAttachments != null)
            {
                job.JobAttachments.Job = job;
                job.JobAttachments.JobId = job.Id;
                AddJobAttachments(job.JobAttachments);
            }

            if (job.JobSkills != null)
            {
                if (job.JobSkills.Any())
                {
                    foreach (var skill in job.JobSkills)
                    {
                        skill.Job = job;
                        skill.JobId = job.Id;
                        AddJobSkills(skill);
                    }
                }
            }

            if (job.JobDiplomas != null)
            {
                if (job.JobDiplomas.Any())
                {
                    foreach (var diploama in job.JobDiplomas)
                    {
                        diploama.Job = job;
                        diploama.JobId = job.Id;
                        AddJobDiplomas(diploama);
                    }
                }
            }

            if (job.JobCommitments != null)
            {
                if (job.JobCommitments.Any())
                {
                    foreach (var commitment in job.JobCommitments)
                    {
                        commitment.Job = job;
                        commitment.JobId = job.Id;
                        AddJobCommitments(commitment);
                    }
                }
            }

            if (job.JobAvailability != null)
            {
                if (job.JobAvailability.Any())
                {
                    foreach (var availability in job.JobAvailability)
                    {
                        availability.Job = job;
                        availability.JobId = job.Id;
                        AddJobAvailability(availability);
                    }
                }
            }

            if (job.JobLocation != null)
            {
                if (job.JobLocation.Any())
                {
                    foreach (var location in job.JobLocation)
                    {
                        location.Job = job;
                        location.JobId = job.Id;
                        AddJobLocation(location);
                    }
                }
            }

            if (job.JobQuestions != null)
            {
                if (job.JobQuestions.Any())
                {
                    foreach (var question in job.JobQuestions)
                    {
                        question.Job = job;
                        question.JobId = job.Id;
                        AddJobQuestions(question);
                    }
                }
            }

            if (job.JobLanguages != null)
            {
                if (job.JobLanguages.Any())
                {
                    foreach (var language in job.JobLanguages)
                    {
                        language.Job = job;
                        language.JobId = job.Id;
                        AddJobLanguages(language);
                    }
                }
            }

            if (job.JobAppropriateFor != null)
            {
                if (job.JobAppropriateFor.Any())
                {
                    foreach (var appropriateFor in job.JobAppropriateFor)
                    {
                        appropriateFor.Job = job;
                        appropriateFor.JobId = job.Id;
                        AddJobAppropriateFor(appropriateFor);
                    }
                }
            }

            if (job.JobIntVolunteer != null)
            {
                if (job.JobIntVolunteer.Any())
                {
                    foreach (var intVolunteer in job.JobIntVolunteer)
                    {
                        intVolunteer.Job = job;
                        intVolunteer.JobId = job.Id;
                        AddJobIntVolunteer(intVolunteer);
                    }
                }
            }

            if (job.JobAdditionalInfo != null)
            {
                if (job.JobAdditionalInfo.Any())
                {
                    foreach (var addInfo in job.JobAdditionalInfo)
                    {
                        addInfo.Job = job;
                        addInfo.JobId = job.Id;
                        AddJobAdditionalInfo(addInfo);
                    }
                }
            }

            _jobDetails.Commit();
            return job.Id;
        }




        private void CreateDbContext()
        {
            DbContext = new VolunteerApiDbContext();
            //to make serialize
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
        }

        ~JobService()
        {
            DbContext.Dispose();
        }

    }
}