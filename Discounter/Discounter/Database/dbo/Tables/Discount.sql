CREATE TABLE [dbo].[Discount] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Description]   TEXT          NULL,
    [ItemID]        INT           NOT NULL,
    [OldPrice]      MONEY         NOT NULL,
    [NewPrice]      MONEY         NOT NULL,
    [StartDateTime] DATETIME      NOT NULL,
    [EndDateTime]   DATETIME      NOT NULL,
    [IsApproved]    BIT           DEFAULT ((0)) NOT NULL,
    [WasRejected]   BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Discount_ToItem] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[DiscountedItem] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

