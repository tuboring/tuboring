CREATE TABLE [dbo].[TicketsSales]
(
	[IdTicketsSales] INT NOT NULL PRIMARY KEY, 
    [EventId] INT NOT NULL, 
    [UserId] NVARCHAR(MAX) NOT NULL, 
    [Amount] NCHAR(10) NOT NULL
)
