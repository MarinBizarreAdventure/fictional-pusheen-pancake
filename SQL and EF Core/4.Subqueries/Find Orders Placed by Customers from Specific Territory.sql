USE AdventureWorks2019;

-- Find Orders Placed by Customers from Specific Territory

SELECT SalesOrderID, OrderDate
FROM [Sales].[SalesOrderHeader]
WHERE CustomerID IN (
	SELECT CustomerID
	FROM [Sales].[Customer]
	WHERE TerritoryID = 2
	)