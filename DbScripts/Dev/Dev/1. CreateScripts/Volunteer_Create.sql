
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[TblApiConsumers]    Script Date: 15-11-2014 18:06:42 ******/

IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblApiConsumers' )
BEGIN

CREATE TABLE [dbo].[TblApiConsumers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ConsumerKey] [nvarchar](max) NULL,
	[ConsumerSecret] [nvarchar](max) NULL,
	[CallBackUrl] [nvarchar](max) NULL,
	[RegistrationDate] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.TblApiConsumers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblApiLog' )
BEGIN
/****** Object:  Table [dbo].[TblApiLog]    Script Date: 15-11-2014 18:06:43 ******/

CREATE TABLE [dbo].[TblApiLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ApiUrl] [nvarchar](1000) NOT NULL,
	[RequestDate] [datetime] NOT NULL,
	[CallerIp] [nvarchar](100) NOT NULL,
	[Token] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblApiLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
END
GO






IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblApiTokenManagers' )
BEGIN

CREATE TABLE [dbo].[TblApiTokenManagers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ConsumerKey] [nvarchar](max) NULL,
	[ConsumerSecret] [nvarchar](max) NULL,
	[CallerIp] [nvarchar](max) NULL,
	[ExpirationDate] [datetime] NOT NULL,
	[Token] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.TblApiTokenManagers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterCategories' )
BEGIN
/****** Object:  Table [dbo].[TblMasterCategories]    Script Date: 15-11-2014 18:06:45 ******/

CREATE TABLE [dbo].[TblMasterCategories](
	[Id] [int] NOT NULL,
	[CategoryName] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterCountry' )
BEGIN

CREATE TABLE [dbo].[TblMasterCountry](
	[Id] [nvarchar](2) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO






IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterDaysOfWeek' )
BEGIN


CREATE TABLE [dbo].[TblMasterDaysOfWeek](
	[Id] [int] NOT NULL,
	[DaysOfWeek] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterDaysofWeek] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO






IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterDiploma' )
BEGIN

CREATE TABLE [dbo].[TblMasterDiploma](
	[Id] [int] NOT NULL,
	[DiplomaName] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterDiploma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterOrganizationType' )
BEGIN
CREATE TABLE [dbo].[TblMasterOrganizationType](
	[Id] [int] NOT NULL,
	[OrganizationType] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterOrganizationType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterSkills' )
BEGIN

CREATE TABLE [dbo].[TblMasterSkills](
	[Id] [int] NOT NULL,
	[SkillName] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterSkills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterWorkArea' )
BEGIN

CREATE TABLE [dbo].[TblMasterWorkArea](
	[Id] [int] NOT NULL,
	[WorkAreaName] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterWorkArea] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO







IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblOrganizationProfiles' )
BEGIN

CREATE TABLE [dbo].[TblOrganizationProfiles](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[OrganizatioName] [nvarchar](250) NULL,
	[OrganizationNickName] [nvarchar](250) NULL,
	[IsRegistered] [bit] NULL,
	[RegisterationNumber] [nvarchar](50) NULL,
	[OrganizationTypeid] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_tblOrganizationProfiles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblUsers' )
BEGIN

CREATE TABLE [dbo].[TblUsers](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Country] [int] NOT NULL,
	[IsEmailSubsription] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblVolunteerProfileJobs' )
BEGIN

CREATE TABLE [dbo].[TblVolunteerProfileJobs](
	[Id] [int] NOT NULL,
	[volunteerprofileid] [int] NULL,
	[organization] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Country] [int] NULL,
	[title] [nvarchar](100) NULL,
	[datefrom] [datetime] NULL,
	[dateto] [datetime] NULL,
	[iscurrentlyworking] [bit] NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblVolunteerProfileJobs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblVolunteerProfileProject' )
BEGIN

CREATE TABLE [dbo].[TblVolunteerProfileProject](
	[Id] [int] NOT NULL,
	[volunteerprofileid] [int] NULL,
	[projectname] [nvarchar](100) NULL,
	[organization] [nvarchar](100) NULL,
	[datefrom] [date] NULL,
	[dateto] [date] NULL,
	[projecturl] [nvarchar](250) NULL,
	[teammembers] [varchar](4000) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblVolunteerProfileProject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblVolunteerProfiles' )
BEGIN

CREATE TABLE [dbo].[TblVolunteerProfiles](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[profileimage] [image] NULL,
	[aboutmetext] [nvarchar](max) NULL,
	[lookingfortext] [nvarchar](max) NULL,
	[categories] [varchar](250) NULL,
	[desiredworkarea] [varchar](250) NULL,
	[skills] [varchar](250) NULL,
	[diploma] [varchar](250) NULL,
	[timeavailability] [varchar](50) NULL,
	[DaysOfWeek] [varchar](250) NULL,
	[profilevisibility] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblVolunteerProfiles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO






IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblVolunteerProfileSchools' )
BEGIN

CREATE TABLE [dbo].[TblVolunteerProfileSchools](
	[Id] [int] NOT NULL,
	[VolunteerProfileId] [int] NULL,
	[SchoolName] [nvarchar](250) NULL,
	[DateFrom] [int] NULL,
	[DateTo] [int] NULL,
	[Degree] [nvarchar](100) NULL,
	[AreaOfStudy] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblVolunteerProfileSchools] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO


IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterTimeCommitments' )
BEGIN

CREATE TABLE [dbo].[TblMasterTimeCommitments](
	[Id] [int] NOT NULL,
	[Commitment] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterTimeCommitments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterLanguages' )
BEGIN

CREATE TABLE [dbo].[TblMasterLanguages](
	[Id] [int] NOT NULL,
	[Language] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterLanguages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO



IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterScreeningQuestions' )
BEGIN

CREATE TABLE [dbo].[TblMasterScreeningQuestions](
	[Id] [int] NOT NULL,
	[Question] [varchar](500) NULL,
	[IsActive] [bit]  NOT NULL,
 CONSTRAINT [PK_TblMasterSceeningQuestions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO






IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobTypes' )
BEGIN

CREATE TABLE [dbo].[TblMasterJobTypes](
	[Id] [int] NOT NULL,
	[JobType] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterJobTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobAdditionalInfo' )
BEGIN

CREATE TABLE [dbo].[TblMasterJobAdditionalInfo](
	[Id] [int]  NOT NULL,
	[AdditionalInfo] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterJobAdditionalInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobIntVolunteerInfo' )
BEGIN

CREATE TABLE [dbo].[TblMasterJobIntVolunteerInfo](
	[Id] [int]  NOT NULL,
	[IntVolunteerInfo] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterJobIntVolunteerInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO



IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterJobAppropriateForInfo' )
BEGIN

CREATE TABLE [dbo].[TblMasterJobAppropriateForInfo](
	[Id] [int]  NOT NULL,
	[AppropriateForInfo] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterJobAppropriateForInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblMasterInterval' )
BEGIN

CREATE TABLE [dbo].[TblMasterInterval](
	[Id] [int]  NOT NULL,
	[Interval] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblMasterInterval] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO






IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobDetails' )
BEGIN

CREATE TABLE [dbo].[TblJobDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobTypeId] [int] NOT NULL,
	[JobTitle] [varchar](250) NULL,
	[Description] [varchar](2000) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[JobVisibilityId] [int] NULL,
	[IsScheduleFlexible] [bit] NULL,
	[IsCoverLetterNeeded] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TblJobDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO



IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobAttachments' )
BEGIN

CREATE TABLE [dbo].[TblJobAttachments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[Attachment] [varbinary](8000) NULL,
	[AttachmentType] [varchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobAttachments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO



IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobSkills' )
BEGIN

CREATE TABLE [dbo].[TblJobSkills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[SkillId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobSkills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO



IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobDiplomas' )
BEGIN

CREATE TABLE [dbo].[TblJobDiplomas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[DiplomaId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobDiplomas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobCommitments' )
BEGIN

CREATE TABLE [dbo].[TblJobCommitments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[CommitmentId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobCommitments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO





IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobAvailability' )
BEGIN

CREATE TABLE [dbo].[TblJobAvailability](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[DayId] [int] NOT NULL,
	[IntervalId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobAvailability] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobLocation' )
BEGIN

CREATE TABLE [dbo].[TblJobLocation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[Address] [varchar](500) NULL,
	[CountryId] [nvarchar](2) NOT NULL,
	[ZipCode] [varchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobLocation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobQuestions' )
BEGIN

CREATE TABLE [dbo].[TblJobQuestions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
	[Questions] [varchar](4000) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobQuestions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO


IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobLanguages' )
BEGIN

CREATE TABLE [dbo].[TblJobLanguages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobLanguages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobAppropriateFor' )
BEGIN

CREATE TABLE [dbo].[TblJobAppropriateFor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[AppropriateForId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobAppropriateFor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO



IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobIntVolunteer' )
BEGIN

CREATE TABLE [dbo].[TblJobIntVolunteer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[IntVolunteerId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobIntVolunteer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO




IF not EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'TblJobAdditionalInfo' )
BEGIN

CREATE TABLE [dbo].[TblJobAdditionalInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[AdditionalInfoId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_TblJobAdditionalInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) 
)
END
GO













