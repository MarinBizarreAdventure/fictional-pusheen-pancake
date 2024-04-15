USE AdventureWorks2019;

-- Find Products with Sales Quantity Greater Than 1000

SELECT ProductID, Name, ProductNumber
FROM [Production].[Product]
WHERE ProductID IN (
	SELECT ProductID
	FROM [Sales].[SalesOrderDetail]
	GROUP BY ProductID
	HAVING SUM(OrderQty) > 1000
);