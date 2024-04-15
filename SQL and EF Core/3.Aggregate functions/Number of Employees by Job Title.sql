USE AdventureWorks2019;

-- Number of Employees by Job Title

SELECT JobTitle,
       count(BusinessEntityID) AS NumbeOfEmployees 
FROM [HumanResources].[Employee]
GROUP BY JobTitle
