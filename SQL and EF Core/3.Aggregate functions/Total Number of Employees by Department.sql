USE AdventureWorks2019;

-- Total Number of Employees by Department

SELECT d.Name AS DepartmentTitle,
       COUNT(e.BusinessEntityID) AS NumberOfEmployees
FROM HumanResources.Employee e
JOIN HumanResources.EmployeeDepartmentHistory edh ON e.BusinessEntityID = edh.BusinessEntityID
JOIN HumanResources.Department d ON edh.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY NumberOfEmployees DESC;
