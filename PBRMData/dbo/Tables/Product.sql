CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL,
    [RetailPrice] MONEY NOT null, 
    [QuantityInStock] INT NOT NULL DEFAULT 1,
    [CreateDate] DATETIME2 NOT NULL DEFAULT getUTCDate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getUTCDate(), 
    [isTaxable] BIT NOT NULL DEFAULT 1
)
