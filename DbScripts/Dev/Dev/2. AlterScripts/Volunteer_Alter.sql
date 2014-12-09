


ALTER TABLE [dbo].[TblOrganizationProfiles]  WITH CHECK ADD  CONSTRAINT [FK_tblOrganizationProfiles_TblMasterOrganizationType] FOREIGN KEY([OrganizationTypeid])
REFERENCES [dbo].[TblMasterOrganizationType] ([Id])
GO
ALTER TABLE [dbo].[TblOrganizationProfiles] CHECK CONSTRAINT [FK_tblOrganizationProfiles_TblMasterOrganizationType]
GO
ALTER TABLE [dbo].[TblOrganizationProfiles]  WITH CHECK ADD  CONSTRAINT [FK_tblOrganizationProfiles_tblUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[TblUsers] ([Id])
GO
ALTER TABLE [dbo].[TblOrganizationProfiles] CHECK CONSTRAINT [FK_tblOrganizationProfiles_tblUsers]
GO
ALTER TABLE [dbo].[TblVolunteerProfileJobs]  WITH CHECK ADD  CONSTRAINT [FK_TblVolunteerProfileJobs_TblVolunteerProfiles] FOREIGN KEY([volunteerprofileid])
REFERENCES [dbo].[TblVolunteerProfiles] ([Id])
GO
ALTER TABLE [dbo].[TblVolunteerProfileJobs] CHECK CONSTRAINT [FK_TblVolunteerProfileJobs_TblVolunteerProfiles]
GO
ALTER TABLE [dbo].[TblVolunteerProfileProject]  WITH CHECK ADD  CONSTRAINT [FK_TblVolunteerProfileProject_TblVolunteerProfiles] FOREIGN KEY([volunteerprofileid])
REFERENCES [dbo].[TblVolunteerProfiles] ([Id])
GO
ALTER TABLE [dbo].[TblVolunteerProfileProject] CHECK CONSTRAINT [FK_TblVolunteerProfileProject_TblVolunteerProfiles]
GO
ALTER TABLE [dbo].[TblVolunteerProfiles]  WITH CHECK ADD  CONSTRAINT [FK_TblVolunteerProfiles_tblUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[TblUsers] ([Id])
GO
ALTER TABLE [dbo].[TblVolunteerProfiles] CHECK CONSTRAINT [FK_TblVolunteerProfiles_tblUsers]
GO
ALTER TABLE [dbo].[TblVolunteerProfileSchools]  WITH CHECK ADD  CONSTRAINT [FK_TblVolunteerProfileSchools_TblVolunteerProfiles] FOREIGN KEY([volunteerprofileid])
REFERENCES [dbo].[TblVolunteerProfiles] ([Id])
GO
ALTER TABLE [dbo].[TblVolunteerProfileSchools] CHECK CONSTRAINT [FK_TblVolunteerProfileSchools_TblVolunteerProfiles]
GO


------------

ALTER TABLE [dbo].[TblJobDetails]  WITH CHECK ADD  CONSTRAINT [FK_TblJobDetails_TblMasterJobTypes] FOREIGN KEY([JobTypeId])
REFERENCES [dbo].[TblMasterJobTypes] ([Id])
GO
ALTER TABLE [dbo].[TblJobDetails] CHECK CONSTRAINT [FK_TblJobDetails_TblMasterJobTypes]
GO



ALTER TABLE [dbo].[TblJobAttachments]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAttachments_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobAttachments] CHECK CONSTRAINT [FK_TblJobAttachments_TblJobDetails]
GO

ALTER TABLE [dbo].[TblJobSkills]  WITH CHECK ADD  CONSTRAINT [FK_TblJobSkills_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobSkills] CHECK CONSTRAINT [FK_TblJobSkills_TblJobDetails]
GO


ALTER TABLE [dbo].[TblJobSkills]  WITH CHECK ADD  CONSTRAINT [FK_TblJobSkills_TblMasterSkills] FOREIGN KEY([SkillId])
REFERENCES [dbo].[TblMasterSkills] ([Id])
GO
ALTER TABLE [dbo].[TblJobSkills] CHECK CONSTRAINT [FK_TblJobSkills_TblMasterSkills]
GO




ALTER TABLE [dbo].[TblJobDiplomas]  WITH CHECK ADD  CONSTRAINT [FK_TblJobDiplomas_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobDiplomas] CHECK CONSTRAINT [FK_TblJobDiplomas_TblJobDetails]
GO

ALTER TABLE [dbo].[TblJobDiplomas]  WITH CHECK ADD  CONSTRAINT [FK_TblJobDiplomas_TblMasterDiploma] FOREIGN KEY([DiplomaId])
REFERENCES [dbo].[TblMasterDiploma] ([Id])
GO
ALTER TABLE [dbo].[TblJobDiplomas] CHECK CONSTRAINT [FK_TblJobDiplomas_TblMasterDiploma]
GO





ALTER TABLE [dbo].[TblJobCommitments]  WITH CHECK ADD  CONSTRAINT [FK_TblJobCommitments_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobCommitments] CHECK CONSTRAINT [FK_TblJobCommitments_TblJobDetails]
GO

ALTER TABLE [dbo].[TblJobCommitments]  WITH CHECK ADD  CONSTRAINT [FK_TblJobCommitments_TblMasterTimeCommitments] FOREIGN KEY([CommitmentId])
REFERENCES [dbo].[TblMasterTimeCommitments] ([Id])
GO
ALTER TABLE [dbo].[TblJobCommitments] CHECK CONSTRAINT [FK_TblJobCommitments_TblMasterTimeCommitments]
GO




ALTER TABLE [dbo].[TblJobAvailability]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAvailability_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobAvailability] CHECK CONSTRAINT [FK_TblJobAvailability_TblJobDetails]
GO

ALTER TABLE [dbo].[TblJobAvailability]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAvailability_TblMasterDaysOfWeek] FOREIGN KEY([DayId])
REFERENCES [dbo].[TblMasterDaysOfWeek] ([Id])
GO
ALTER TABLE [dbo].[TblJobAvailability] CHECK CONSTRAINT [FK_TblJobAvailability_TblMasterDaysOfWeek]
GO


ALTER TABLE [dbo].[TblJobAvailability]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAvailability_TblMasterInterval] FOREIGN KEY([IntervalId])
REFERENCES [dbo].[TblMasterInterval] ([Id])
GO
ALTER TABLE [dbo].[TblJobAvailability] CHECK CONSTRAINT [FK_TblJobAvailability_TblMasterInterval]
GO





ALTER TABLE [dbo].[TblJobLocation]  WITH CHECK ADD  CONSTRAINT [FK_TblJobLocation_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobLocation] CHECK CONSTRAINT [FK_TblJobLocation_TblJobDetails]
GO


ALTER TABLE [dbo].[TblJobLocation]  WITH CHECK ADD  CONSTRAINT [FK_TblJobLocation_TblMasterCountry] FOREIGN KEY([CountryId])
REFERENCES [dbo].[TblMasterCountry] ([Id])
GO
ALTER TABLE [dbo].[TblJobLocation] CHECK CONSTRAINT [FK_TblJobLocation_TblMasterCountry]
GO



ALTER TABLE [dbo].[TblJobQuestions]  WITH CHECK ADD  CONSTRAINT [FK_TblJobQuestions_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobQuestions] CHECK CONSTRAINT [FK_TblJobQuestions_TblJobDetails]
GO


ALTER TABLE [dbo].[TblJobQuestions]  WITH CHECK ADD  CONSTRAINT [FK_TblJobQuestions_TblMasterScreeningQuestions] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[TblMasterScreeningQuestions] ([Id])
GO
ALTER TABLE [dbo].[TblJobQuestions] CHECK CONSTRAINT [FK_TblJobQuestions_TblMasterScreeningQuestions]
GO



ALTER TABLE [dbo].[TblJobLanguages]  WITH CHECK ADD  CONSTRAINT [FK_TblJobLanguages_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobLanguages] CHECK CONSTRAINT [FK_TblJobLanguages_TblJobDetails]
GO



ALTER TABLE [dbo].[TblJobLanguages]  WITH CHECK ADD  CONSTRAINT [FK_TblJobLanguages_TblMasterLanguages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[TblMasterLanguages] ([Id])
GO
ALTER TABLE [dbo].[TblJobLanguages] CHECK CONSTRAINT [FK_TblJobLanguages_TblMasterLanguages]
GO




ALTER TABLE [dbo].[TblJobAppropriateFor]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAppropriateFor_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobAppropriateFor] CHECK CONSTRAINT [FK_TblJobAppropriateFor_TblJobDetails]
GO


ALTER TABLE [dbo].[TblJobAppropriateFor]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAppropriateFor_TblMasterJobAppropriateForInfo] FOREIGN KEY([AppropriateForId])
REFERENCES [dbo].[TblMasterJobAppropriateForInfo] ([Id])
GO
ALTER TABLE [dbo].[TblJobAppropriateFor] CHECK CONSTRAINT [FK_TblJobAppropriateFor_TblMasterJobAppropriateForInfo]
GO




ALTER TABLE [dbo].[TblJobIntVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_TblJobIntVolunteer_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobIntVolunteer] CHECK CONSTRAINT [FK_TblJobIntVolunteer_TblJobDetails]
GO


ALTER TABLE [dbo].[TblJobIntVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_TblJobIntVolunteer_TblMasterJobIntVolunteerInfo] FOREIGN KEY([IntVolunteerId])
REFERENCES [dbo].[TblMasterJobIntVolunteerInfo] ([Id])
GO
ALTER TABLE [dbo].[TblJobIntVolunteer] CHECK CONSTRAINT [FK_TblJobIntVolunteer_TblMasterJobIntVolunteerInfo]
GO




ALTER TABLE [dbo].[TblJobAdditionalInfo]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAdditionalInfo_TblJobDetails] FOREIGN KEY([JobId])
REFERENCES [dbo].[TblJobDetails] ([Id])
GO
ALTER TABLE [dbo].[TblJobAdditionalInfo] CHECK CONSTRAINT [FK_TblJobAdditionalInfo_TblJobDetails]
GO


ALTER TABLE [dbo].[TblJobAdditionalInfo]  WITH CHECK ADD  CONSTRAINT [FK_TblJobAdditionalInfo_TblMasterJobAdditionalInfo] FOREIGN KEY([AdditionalInfoId])
REFERENCES [dbo].[TblMasterJobAdditionalInfo] ([Id])
GO
ALTER TABLE [dbo].[TblJobAdditionalInfo] CHECK CONSTRAINT [FK_TblJobAdditionalInfo_TblMasterJobAdditionalInfo]
GO










