CREATE TABLE [dbo].[ItemPicture] (
    [ItemID]  INT             NOT NULL,
    [Picture] VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ItemID] ASC),
    CONSTRAINT [FK_ItemPicture_ToItem] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[DiscountedItem] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

