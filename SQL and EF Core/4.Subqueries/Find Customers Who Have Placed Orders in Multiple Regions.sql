USE AdventureWorks2019;

-- Find Customers Who Have Placed Orders in Multiple Regions

SELECT DISTINCT CustomerID
FROM [Sales].[Customer]
WHERE CustomerID in (
	SELECT CustomerID
	FROM [Sales].[SalesOrderHeader]
	GROUP BY CustomerID
	HAVING COUNT(DISTINCT TerritoryID) > 1
	);