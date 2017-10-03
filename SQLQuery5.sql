CREATE TABLE [dbo].[RegOnMatch]
(
	[IdReg] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmailSportsmen] NVARCHAR(10) NOT NULL, 
    [EventId] INT NOT NULL, 
    [CityName] NCHAR(10) NOT NULL, 
    [RegistrationStatucId] INT NOT NULL
)