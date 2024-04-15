USE AdventureWorks2019;

-- Top 5 Products by Sales Quantity

SELECT TOP 5 pp.Name AS ProductName,
       SUM(sod.OrderQty) AS TotalQuantitySold
FROM Sales.SalesOrderDetail sod
JOIN Production.Product pp ON sod.ProductID = pp.ProductID
GROUP BY pp.Name
ORDER BY TotalQuantitySold DESC;
