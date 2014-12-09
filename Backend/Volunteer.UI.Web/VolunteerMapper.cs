using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Volunteer.Business.Entities;
using Volunteer.UI.Web.ViewModels;

namespace Volunteer.UI.Web
{
    public class VolunteerMapper
    {
        public static void Configure()
        {
            Mapper.CreateMap<TblMasterLanguages, _Language>();
            Mapper.CreateMap<TblMasterSkills, _Skill>();
            Mapper.CreateMap<TblMasterDiploma, _Diploma>();
            Mapper.CreateMap<TblMasterTimeCommitments, _Commitment>();
            Mapper.CreateMap<TblMasterDaysOfWeek, _DaysOfWeek>();
            Mapper.CreateMap<TblMasterInterval, _Interval>();
            Mapper.CreateMap<TblMasterJobAppropriateForInfo, _AppropriateFor>();
            Mapper.CreateMap<TblMasterJobIntVolunteerInfo, _IntVolunteerInfo>();
            Mapper.CreateMap<TblMasterJobAdditionalInfo, _AdditionalInfo>();
            Mapper.CreateMap<TblMasterScreeningQuestions, _Questions>();
        }
    }
}