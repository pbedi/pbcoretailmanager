CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] VARCHAR(128) NOT NULL, 
    [SaleDate] DATETIME2 NOT NULL, 
    [SubTotal] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL DEFAULT 0, 
    [Total] MONEY NOT NULL, 
    CONSTRAINT [FK_Sale_To_User] FOREIGN KEY ([CashierId]) REFERENCES [User]([Id]) 
)
