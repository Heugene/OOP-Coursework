CREATE TABLE [dbo].[DiscountedItem] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Description] TEXT          NULL,
    [Type]        CHAR (7)      NOT NULL,
    [ShopID]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DiscountedItem_ToShop] FOREIGN KEY ([ShopID]) REFERENCES [dbo].[Shop] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

