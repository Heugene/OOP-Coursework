CREATE TABLE [dbo].[DiscountRequest] (
    [Id]              INT      IDENTITY (1, 1) NOT NULL,
    [ManagerID]       INT      NOT NULL,
    [DiscountID]      INT      NOT NULL,
    [CreatedDateTime] DATETIME NOT NULL,
    [ViewedDateTime]  DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DiscountRequest_ToDiscount] FOREIGN KEY ([DiscountID]) REFERENCES [dbo].[Discount] ([Id]),
    CONSTRAINT [FK_DiscountRequest_ToManager] FOREIGN KEY ([ManagerID]) REFERENCES [dbo].[ShopManager] ([Id])
);