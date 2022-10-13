CREATE TABLE [dbo].[Passport]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [applicant_id] INT NOT NULL, 
    [appointment_id] INT NOT NULL, 
    [is_complete] BIT NOT NULL, 
    CONSTRAINT [FK_Passport_Applicant] FOREIGN KEY ([applicant_id]) REFERENCES [Applicant]([Id]), 
    CONSTRAINT [FK_Passport_Appointment] FOREIGN KEY ([appointment_id]) REFERENCES [Appointment]([Id])
)
