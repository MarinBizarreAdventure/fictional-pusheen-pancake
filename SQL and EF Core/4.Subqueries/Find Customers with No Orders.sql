USE AdventureWorks2019;

-- Find Customers with No Orders

SELECT CustomerID, AccountNumber
FROM Sales.Customer
WHERE CustomerID NOT IN (
    SELECT DISTINCT CustomerID
    FROM Sales.SalesOrderHeader
);
