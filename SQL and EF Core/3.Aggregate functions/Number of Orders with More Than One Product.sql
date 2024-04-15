USE AdventureWorks2019;

-- Number of Orders with More Than One Product

SELECT COUNT(sod.SalesOrderDetailID) AS NumberOfOrdersWithMultipleProducts
FROM Sales.SalesOrderHeader soh
JOIN Sales.SalesOrderDetail sod ON soh.SalesOrderID = sod.SalesOrderID
GROUP BY soh.SalesOrderID
HAVING COUNT(sod.SalesOrderDetailID) > 1;
