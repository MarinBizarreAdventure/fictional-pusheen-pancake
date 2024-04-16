USE AdventureWorks2019;

-- Transfer Products Between Warehouses

BEGIN TRANSACTION;

UPDATE Production.ProductInventory
SET Quantity = Quantity - 50
WHERE ProductID = 123 AND LocationID = 1;

UPDATE Production.ProductInventory
SET Quantity = Quantity + 50
WHERE ProductID = 123 AND LocationID = 2;

COMMIT;
