using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer.Business.Services;
using Volunteer.UI.Web.ViewModels;
using AutoMapper;
using Volunteer.Business.Entities;
using System.Globalization;
using System.Web.Script.Serialization;

namespace Volunteer.UI.Web.Controllers
{
    public class JobController : BaseController
    {
        private readonly ITokenManagerService _tokenManagerService;
        private readonly IPostJobService _postJobService;
        public JobController(IPostJobService postJobService, ITokenManagerService tokenManagerService)
        {
            _postJobService = postJobService;
            _tokenManagerService = tokenManagerService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult PostJob()
        {
            PostJobViewModel model = new PostJobViewModel();
           
            var languages = _postJobService.GetMasterLanguages();
            model.Languages = Mapper.Map<List<TblMasterLanguages>, List<_Language>>(languages);

            var skills = _postJobService.GetMasterSkills();
            model.Skills = Mapper.Map<List<TblMasterSkills>, List<_Skill>>(skills);

            var dilpomas = _postJobService.GetMasterDiplomas();
            model.Diplomas = Mapper.Map<List<TblMasterDiploma>, List<_Diploma>>(dilpomas);

            var commitments = _postJobService.GetMasterTimeCommitments();
            model.Commitments = Mapper.Map<List<TblMasterTimeCommitments>, List<_Commitment>>(commitments);

            var days = _postJobService.GetMasterDaysOfWeek();
            model.DayOfWeeks = Mapper.Map<List<TblMasterDaysOfWeek>, List<_DaysOfWeek>>(days);

            var intervals = _postJobService.GetMasterInterval();
            model.Intervals = Mapper.Map<List<TblMasterInterval>, List<_Interval>>(intervals);

            var appropriateFor = _postJobService.GetMasterJobAppropriateForInfo();
            model.AppropriateFor = Mapper.Map<List<TblMasterJobAppropriateForInfo>, List<_AppropriateFor>>(appropriateFor);

            var volunteerInfo = _postJobService.GetMasterJobIntVolunteerInfo();
            model.IntVolunteerInfo = Mapper.Map<List<TblMasterJobIntVolunteerInfo>, List<_IntVolunteerInfo>>(volunteerInfo);

            var addInfo = _postJobService.GetMasterJobAdditionalInfo();
            model.AdditionalInfo = Mapper.Map<List<TblMasterJobAdditionalInfo>, List<_AdditionalInfo>>(addInfo);

            var questions = _postJobService.GetMasterSceeningQuestions().Where(x => x.Question.Trim() != "Additional-Question").ToList();
            model.Questions = Mapper.Map<List<TblMasterScreeningQuestions>, List<_Questions>>(questions);

            var countries = _postJobService.GetMasterCountries();
            model.Countries = countries.Select(c => new SelectListItem { Text = c.Name, Value = c.Id });

            var jobTypes = _postJobService.GetMasterJobTypes();
            model.JobTypes = jobTypes.Select(c => new SelectListItem { Text = c.JobType, Value = c.Id.ToString() });

            return View(model);
        }

        [HttpPost]
        public ActionResult PostJob(FormCollection form, PostJobViewModel viewModel, String hdnQuestions)
        {
            var days = _postJobService.GetMasterDaysOfWeek();
            var intervals = _postJobService.GetMasterInterval();
            String[] chckedValuesTimeCommitment = form.GetValues("TimeCommitment");
            String[] chckedValuesAppropriateFor = form.GetValues("AppropriateFor");
            String[] chckedValuesIntVolunteer = form.GetValues("IntVolunteerInfo");
            String[] chckedValuesAdditionalInfo = form.GetValues("AdditionalInfo");

            var serializer = new JavaScriptSerializer();
            var questionsList = serializer.Deserialize<List<ScreeningQuestion>>(hdnQuestions);

            var _postJobDTO = GetPostJobDTO(viewModel, days, intervals, chckedValuesTimeCommitment, chckedValuesAppropriateFor, chckedValuesIntVolunteer, chckedValuesAdditionalInfo);
            _postJobService.AddJob(_postJobDTO);
            return RedirectToAction("PostJob");
        }

        public Job GetPostJobDTO(PostJobViewModel model, List<TblMasterDaysOfWeek> masterDaysOfWeek, List<TblMasterInterval> masterIntervals,
            String[] chckedValuesTimeCommitment, String[] chckedValuesAppropriateFor, String[] chckedValuesIntVolunteer, String[] chckedValuesAdditionalInfo)
        {
            var postJobDTO = new Job();

            postJobDTO.Description = model.Description;
            postJobDTO.JobTypeId = model.JobTypeId;
            postJobDTO.JobTitle = model.JobTitle;

            if (!String.IsNullOrEmpty(model.SkillIDs))
            {
                List<Skill> lstSkills = new List<Skill>();
                List<String> skillIds = model.SkillIDs.Split(',').ToList();
                foreach (String skill in skillIds)
                {
                    var _skill = new Skill();
                    _skill.SkillName = skill;
                    lstSkills.Add(_skill);
                }
                postJobDTO._Skills = lstSkills;
            }

            if (!String.IsNullOrEmpty(model.DiplomaIDs))
            {
                List<Diploma> lstDiplomas = new List<Diploma>();
                List<String> diplomaIds = model.DiplomaIDs.Split(',').ToList();
                foreach (String diploma in diplomaIds)
                {
                    var _diploma = new Diploma();
                    _diploma.DiplomaName = diploma;
                    lstDiplomas.Add(_diploma);
                }
                postJobDTO._Diplomas = lstDiplomas;
            }

            if (!String.IsNullOrEmpty(model.LanguageIDs))
            {
                List<Language> lstLanguages = new List<Language>();
                List<String> languageIds = model.LanguageIDs.Split(',').ToList();
                foreach (String language in languageIds)
                {
                    var _language = new Language();
                    _language.LanguageName = language;
                    lstLanguages.Add(_language);
                }
                postJobDTO._Languages = lstLanguages;
            }

            if (!String.IsNullOrEmpty(model.DayOfWeekIDs))
            {
                List<Availability> lstAvailability = new List<Availability>();
                List<String> availabilityIDs = model.DayOfWeekIDs.Split(',').ToList();
                foreach (String availability in availabilityIDs)
                {
                    var _availability = new Availability();
                    List<String> dayInterval = availability.Split('-').ToList();
                    var _day = dayInterval[0].Trim();
                    var _interval = dayInterval[1].Trim();
                    

                    if (_day.Equals("Weekends"))
                    {
                        var weekends = masterDaysOfWeek.Where(x => x.DaysOfweek == "Sunday" || x.DaysOfweek == "Saturday").ToList();
                        foreach (var __day in weekends)
                        {
                            _availability = new Availability();
                            _availability.DayName = __day.DaysOfweek;
                            _availability.IntervalName = _interval;
                            lstAvailability.Add(_availability);
                        }
                    }
                    else if (_day.Equals("All Weekdays"))
                    {
                        var weekdays = masterDaysOfWeek.Where(x => x.DaysOfweek != "Sunday" && x.DaysOfweek != "Saturday").ToList();
                        foreach (var __day in weekdays)
                        {
                            _availability = new Availability();
                            _availability.DayName = __day.DaysOfweek;
                            _availability.IntervalName = _interval;
                            lstAvailability.Add(_availability);
                        }
                    }
                    else
                    {
                        _availability = new Availability();
                        var __day = masterDaysOfWeek.Where(x => x.DaysOfweek == _day).FirstOrDefault();
                        _availability.DayName = __day.DaysOfweek;
                        _availability.IntervalName = _interval;
                        lstAvailability.Add(_availability);
                    }

                    
                }
                postJobDTO._Availabilities = lstAvailability;
            }
            if (model.IsScheduleFlexible != null)
            {
                postJobDTO.IsScheduleFlexible = model.IsScheduleFlexible;
            }
            postJobDTO.IsCoverLetterNeeded = model.IsCoverLetterNeeded;
           
            if (!String.IsNullOrEmpty(model.StartDate))
            {
                DateTime dtStart = DateTime.ParseExact(model.StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                postJobDTO.StartDate = dtStart;
            }
            if (!String.IsNullOrEmpty(model.EndDate))
            {
                DateTime dtEnd = DateTime.ParseExact(model.EndDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                postJobDTO.EndDate = dtEnd;
            }
            if (model.JobVisibilityId != null)
            {
                postJobDTO.JobVisibilityId = model.JobVisibilityId.Value;
            }

            if (chckedValuesTimeCommitment != null)
            {
                List<Commitment> lstCommitments = new List<Commitment>();
                foreach (var id in chckedValuesTimeCommitment)
                {
                    var _commitment = new Commitment();
                    _commitment.CommitmentName = Convert.ToString(id);
                    lstCommitments.Add(_commitment);
                }
                postJobDTO._Commitments = lstCommitments;
            }
            if (chckedValuesAppropriateFor != null)
            {
                List<AppropriateFor> lstApporpriateFor = new List<AppropriateFor>();
                foreach (var id in chckedValuesAppropriateFor)
                {
                    var _appFor = new AppropriateFor();
                    _appFor.AppropriateForText = Convert.ToString(id);
                    lstApporpriateFor.Add(_appFor);
                }
                postJobDTO._AppropriateFor = lstApporpriateFor;
            }
            if (chckedValuesIntVolunteer != null)
            {
                List<InternationalVolunteerInfo> lstIntVolunteer = new List<InternationalVolunteerInfo>();
                foreach (var id in chckedValuesIntVolunteer)
                {
                    var _IntVolunteer = new InternationalVolunteerInfo();
                    _IntVolunteer.VolunteerInfo = Convert.ToString(id);
                    lstIntVolunteer.Add(_IntVolunteer);
                }
                postJobDTO._InternationalVolunteerInfo = lstIntVolunteer;
            }
            if (chckedValuesAdditionalInfo != null)
            {
                List<AdditionalJobInfo> lstAdditionalInfo = new List<AdditionalJobInfo>();
                foreach (var id in chckedValuesAdditionalInfo)
                {
                    var _AddInfo = new AdditionalJobInfo();
                    _AddInfo.AdditionalInfo = Convert.ToString(id);
                    lstAdditionalInfo.Add(_AddInfo);
                }
                postJobDTO._AdditionalJobInfo = lstAdditionalInfo;
            }

            return postJobDTO;
        }


    }
}
