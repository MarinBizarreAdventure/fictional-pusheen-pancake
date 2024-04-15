USE AdventureWorks2019;

-- Number of orders Placed By Each Customer
SELECT c.CustomerID,
		COUNT(soh.SalesOrderID) AS NumberOfOrders
FROM [Sales].[Customer] c
JOIN [Sales].[SalesOrderHeader] soh ON c.CustomerID = soh.CustomerID
Group BY c.CustomerID
ORDER BY NumberOfOrders DESC;