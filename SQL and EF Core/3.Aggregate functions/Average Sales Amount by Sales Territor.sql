USE AdventureWorks2019;

-- Average Sales Amount by Sales Territory
SELECT st.Name as SalesTerritory,
		AVG(soh.TotalDue) AS AverageSalesAmount
FROM [Sales].[SalesOrderHeader] soh
JOIN [Sales].[SalesTerritory] st ON soh.TerritoryID = st.TerritoryID
GROUP BY ST.Name
ORDER BY  AverageSalesAmount;