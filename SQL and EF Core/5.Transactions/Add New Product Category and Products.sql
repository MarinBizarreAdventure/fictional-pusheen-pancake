USE AdventureWorks2019;

-- Add New Product Category and Products

BEGIN TRANSACTION;


INSERT INTO Production.ProductCategory (Name)
VALUES ('Electronics');

DECLARE @CategoryID INT;
SET @CategoryID = SCOPE_IDENTITY();

INSERT INTO Production.Product (Name, ProductNumber, ProductSubcategoryID, ListPrice)
VALUES 
    ('Laptop', 'LT100', @CategoryID, 1200),
    ('Smartphone', 'SP200', @CategoryID, 800);

COMMIT;
