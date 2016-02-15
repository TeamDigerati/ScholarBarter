CREATE TABLE [dbo].[Users] (
    [UserId]       INT           IDENTITY (1, 1) NOT NULL,
    [Username]     VARCHAR (50)  NOT NULL,
    [EduEmail]     VARCHAR (150) NOT NULL,
    [Email]        VARCHAR (150) NOT NULL,
    [PasswordHash] VARCHAR (MAX) NOT NULL,
    [Enabled]      BIT           CONSTRAINT [DF_Users_Enabled] DEFAULT ((0)) NOT NULL,
    [CreationTime] DATETIME      CONSTRAINT [DF_Users_CreationTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);