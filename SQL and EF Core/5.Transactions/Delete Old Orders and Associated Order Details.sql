USE AdventureWorks2019;

--Delete Old Orders and Associated Order Details

BEGIN TRANSACTION;

DELETE FROM Sales.SalesOrderHeader
WHERE OrderDate < DATEADD(MONTH, -3, GETDATE());

DELETE FROM Sales.SalesOrderDetail
WHERE SalesOrderID NOT IN (
    SELECT SalesOrderID
    FROM Sales.SalesOrderHeader
);

COMMIT;
