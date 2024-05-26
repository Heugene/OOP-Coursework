CREATE TABLE [dbo].[ShopManager] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Role]        CHAR (11)     NOT NULL,
    [Email]       VARCHAR (255) NOT NULL,
    [PhoneNumber] NCHAR (13)    NOT NULL,
    [Password]    NVARCHAR (50) DEFAULT ('0000') NOT NULL,
    [ShopID]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ShopManager_ToShop] FOREIGN KEY ([ShopID]) REFERENCES [dbo].[Shop] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

