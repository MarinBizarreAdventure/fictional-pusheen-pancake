USE AdventureWorks2019;

-- Delete SalariedFlag = 0 Employees and Their Department Assignments

BEGIN TRANSACTION;

DELETE [HumanResources].[Employee]
WHERE SalariedFlag = 0

DELETE FROM [HumanResources].[EmployeeDepartmentHistory]
WHERE BusinessEntityID NOT IN (
    SELECT BusinessEntityID
    FROM [HumanResources].[Employee]
);

COMMIT;