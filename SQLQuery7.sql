﻿Select [EventName], [RegOnMatch].[CityName], [RegistrationStatus] FROM [RegOnMatch] JOIN [Event] ON [Event].[EventId]=[RegOnMatch].[EventId] JOIN [RegistrationStatus] ON [RegistrationStatus].[RegistrationStatusId]=[RegOnMatch].[RegistrationStatucId]