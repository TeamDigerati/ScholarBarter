CREATE TABLE [dbo].[ListingTypes]
(
	[ListingType] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1
)