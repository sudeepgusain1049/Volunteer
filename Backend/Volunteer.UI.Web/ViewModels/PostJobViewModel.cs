using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Volunteer.UI.Web.ViewModels
{
    public class PostJobViewModel
    {
        public virtual IEnumerable<SelectListItem> JobTypes { get; set; }
        public virtual Int32 JobTypeId { get; set; }

        public virtual String JobTitle { get; set; }
        public virtual String Description { get; set; }
        public virtual Byte[] Attachment { get; set; }
        public virtual String AttachmentType { get; set; }
        public virtual IEnumerable<SelectListItem> Countries { get; set; }

        public virtual String SkillIDs { get; set; }
        public virtual String DiplomaIDs { get; set; }

        public virtual String StartDate { get; set; }

        public virtual String EndDate { get; set; }

        public virtual String CommitmentIDs { get; set; }

        public virtual Nullable<Boolean> IsScheduleFlexible { get; set; }
        public virtual Boolean IsCoverLetterNeeded { get; set; }

        public virtual String DayOfWeekIDs { get; set; }

        public virtual String AppropriateForIDs { get; set; }

        public virtual String IntVolunteerIDs { get; set; }

        public virtual String AdditionalInfoIDs { get; set; }

        public virtual String LanguageIDs { get; set; }

        public virtual String CountryIds { get; set; }

        public virtual String CountryId { get; set; }

        public virtual String Zipcodes { get; set; }

        public virtual String FullAddress { get; set; }

        public virtual String QuestionIDs { get; set; }
        public virtual String AdditionalQuestions { get; set; }

        public virtual int? JobVisibilityId { get; set; }

        public virtual List<_Language> Languages { get; set; }
        public virtual List<_Skill> Skills { get; set; }
        public virtual List<_Diploma> Diplomas { get; set; }
        public virtual List<_Commitment> Commitments { get; set; }
        public virtual List<_DaysOfWeek> DayOfWeeks { get; set; }
        public virtual List<_Interval> Intervals { get; set; }
        public virtual List<_AppropriateFor> AppropriateFor { get; set; }
        public virtual List<_IntVolunteerInfo> IntVolunteerInfo { get; set; }
        public virtual List<_AdditionalInfo> AdditionalInfo { get; set; }
        public virtual List<_Questions> Questions { get; set; }
    }


    public class _Language
    {
        public int Id { get; set; }
        public string Language { get; set; }
    }
    public class _Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
    }
    public class _Diploma
    {
        public int Id { get; set; }
        public string DiplomaName { get; set; }
    }
    public class _Commitment
    {
        public int Id { get; set; }
        public string Commitment { get; set; }
    }
    public class _DaysOfWeek
    {
        public int Id { get; set; }
        public string DaysOfweek { get; set; }
    }
    public class _Interval
    {
        public int Id { get; set; }
        public string Interval { get; set; }
    }
    public class _AppropriateFor
    {
        public int Id { get; set; }
        public string AppropriateForInfo { get; set; }
    }
    public class _IntVolunteerInfo
    {
        public int Id { get; set; }
        public string IntVolunteerInfo { get; set; }
    }
    public class _AdditionalInfo
    {
        public int Id { get; set; }
        public string AdditionalInfo { get; set; }
    }
    public class _Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
    }
}