USE AdventureWorks2019;

-- Find Employees Who Are Managers

SELECT BusinessEntityID, JobTitle
FROM [HumanResources].[Employee]
WHERE BusinessEntityID IN (
	SELECT BusinessEntityID
	FROM [HumanResources].[Employee]
	WHERE JobTitle LIKE '%Manager%'
	)