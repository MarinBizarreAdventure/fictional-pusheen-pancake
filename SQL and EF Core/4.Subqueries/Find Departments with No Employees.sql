USE AdventureWorks2019;

-- Find Departments with No Employees

SELECT DepartmentID, Name
FROM [HumanResources].[Department]
WHERE DepartmentID NOT IN (
	SELECT DepartmentID
	FROM [HumanResources].[EmployeeDepartmentHistory]
	GROUP BY DepartmentID
)