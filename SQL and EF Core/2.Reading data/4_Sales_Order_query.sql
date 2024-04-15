USE AdventureWorks2019;

SELECT SalesOrderID,
		SUM(LineTotal) AS TotalCost
FROM [Sales].[SalesOrderDetail] SOD
GROUP BY SalesOrderID
HAVING SUM(LineTotal) > 100000;