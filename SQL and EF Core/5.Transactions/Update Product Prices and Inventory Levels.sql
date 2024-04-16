USE AdventureWorks2019;

-- Update Product Prices and Inventory Levels

BEGIN TRANSACTION;

UPDATE [Production].[Product]
SET ListPrice = ListPrice * 1.1
WHERE ProductSubcategoryID = 1;

UPDATE [Production].[ProductInventory]
SET Quantity = Quantity - 10
WHERE ProductID IN (
	SELECT ProductID
	FROM [Production].[Product]
	WHERE ProductSubcategoryID = 1
);

COMMIT;
