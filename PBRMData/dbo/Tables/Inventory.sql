CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [PurchaseDate] DATETIME2 NOT NULL DEFAULT getUTCDate(), 
    CONSTRAINT [FK_Inventory_To_Product] FOREIGN KEY (ProductId) REFERENCES Product(Id)
)
