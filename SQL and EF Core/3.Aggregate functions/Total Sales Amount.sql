USE AdventureWorks2019;

-- Total Sales Amount by Product Category

SELECT pc.Name AS ProductCategory,
     SUM(soh.TotalDue) AS TotalSalesAmount
FROM [Sales].[SalesOrderHeader] soh
JOIN [Sales].[SalesOrderDetail] sod ON soh.SalesOrderID = sod.SalesOrderID
JOIN [Production].[Product] pp ON sod.ProductID = pp.ProductID
JOIN [Production].[ProductSubcategory] psc ON pp.ProductSubcategoryID = psc.ProductSubcategoryID
JOIN [Production].[ProductCategory] pc ON psc.ProductCategoryID = pc.ProductCategoryID
GROUP BY pc.Name
ORDER BY TotalSalesAmount DESC;
