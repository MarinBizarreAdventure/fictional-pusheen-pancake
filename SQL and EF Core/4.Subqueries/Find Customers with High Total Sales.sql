USE AdventureWorks2019;

-- Find Customers with High Total Sales

SELECT CustomerID, AccountNumber, TotalDue
FROM [Sales].[SalesOrderHeader]
WHERE TotalDue > (SELECT AVG(TotalDue) FROM [Sales].[SalesOrderHeader])