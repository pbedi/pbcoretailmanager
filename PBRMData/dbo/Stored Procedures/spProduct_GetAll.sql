CREATE PROCEDURE [dbo].[spProduct_GetAll]
	
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock,CreateDate, LastModified, isTaxable
	FROM dbo.Product
	ORDER BY ProductName;
END
