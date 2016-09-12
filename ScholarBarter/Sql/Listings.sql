CREATE TABLE [dbo].[Listings] (
    [ListingId]    INT           NOT NULL IDENTITY,
    [UserId]       INT           NOT NULL,
    [Active]       BIT           DEFAULT ((1)) NOT NULL,
    [Type]         VARCHAR (10)  NOT NULL,
    [Description]  VARCHAR (MAX) NOT NULL,
    [CreationTime] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ListingId] ASC),
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);