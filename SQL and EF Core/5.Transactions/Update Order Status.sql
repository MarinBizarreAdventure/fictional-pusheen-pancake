USE AdventureWorks2019;
-- Update  Order Status

BEGIN TRANSACTION;

UPDATE Sales.SalesOrderHeader
SET Status = 3
WHERE CustomerID IN (
    SELECT CustomerID
    FROM Sales.Customer
    WHERE TerritoryID = 2
);

COMMIT;
