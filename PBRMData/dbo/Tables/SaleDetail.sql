CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantity] int NOT null,
    [PurchasePrice] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_SaleDetail_To_Sale] FOREIGN KEY ([SaleId]) REFERENCES [Sale]([Id]), 
    CONSTRAINT [FK_SaleDetail_To_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id])
)
