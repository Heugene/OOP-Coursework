CREATE TABLE [dbo].[Shop] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Address]     NVARCHAR (255) NOT NULL,
    [TrademarkID] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Shop_ToTrademark] FOREIGN KEY ([TrademarkID]) REFERENCES [dbo].[Trademark] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

