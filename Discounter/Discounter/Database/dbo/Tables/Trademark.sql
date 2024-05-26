CREATE TABLE [dbo].[Trademark] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Description] TEXT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

