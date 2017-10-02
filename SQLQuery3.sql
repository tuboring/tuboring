CREATE TABLE [dbo].[RegistrationSportsmen]
(
	[RegId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EventId] INT NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL
)