CREATE TABLE [dbo].[RegOnMatch] (
    [IdReg]                INT           IDENTITY (1, 1) NOT NULL,
    [EmailSportsmen]       NVARCHAR (100) NOT NULL,
    [EventId]              NCHAR(6)           NOT NULL,
    [CityName]             NCHAR (50)    NOT NULL,
    [RegistrationStatucId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([IdReg] ASC)
);
