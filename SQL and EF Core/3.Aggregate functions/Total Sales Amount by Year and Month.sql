USE AdventureWorks2019;

-- Total Sales Amount by Year and Month
 
SELECT YEAR(OrderDate) AS OrderYear,
	   MONTH(OrderDate) AS OrderMonth,
	   SUM(TotalDue) AS TotalSalesAmount
FROM [Sales].[SalesOrderHeader]
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY OrderYear, OrderMonth;
