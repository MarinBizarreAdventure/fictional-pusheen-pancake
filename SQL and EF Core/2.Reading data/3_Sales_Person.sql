USE AdventureWorks2019;

WITH SalesPersonInfo AS (
    SELECT ROW_NUMBER() OVER (PARTITION BY a.PostalCode ORDER BY s.SalesYTD DESC) AS RowNum,
           p.LastName,
           s.SalesYTD,
           a.PostalCode
    FROM Sales.SalesPerson s
    JOIN Person.Person p ON s.BusinessEntityID = p.BusinessEntityID
    JOIN Person.BusinessEntityAddress bea ON s.BusinessEntityID = bea.BusinessEntityID
    JOIN Person.Address a ON bea.AddressID = a.AddressID
    WHERE s.TerritoryID IS NOT NULL AND s.SalesYTD != 0
)
SELECT RowNum,
       LastName,
       SalesYTD,
       PostalCode
FROM SalesPersonInfo
ORDER BY PostalCode ASC, SalesYTD DESC;
