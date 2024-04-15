USE AdventureWorks2019;

-- Find Orders with More Than One Product

SELECT SalesOrderID, OrderDate
FROM [Sales].[SalesOrderHeader]
WHERE SalesOrderID IN (
		SELECT SalesOrderID
		FROM [Sales].[SalesOrderDetail]
		GROUP BY SalesOrderID
		HAVING COUNT(*) > 1
	);

