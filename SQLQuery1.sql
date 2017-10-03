CREATE TABLE [dbo].[ResultEvant]
(
	[IdResult] INT IDENTITY (1, 1)  NOT NULL PRIMARY KEY, 
    [EventId] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(MAX) NULL, 
    [Result] NVARCHAR(MAX) NULL
)
