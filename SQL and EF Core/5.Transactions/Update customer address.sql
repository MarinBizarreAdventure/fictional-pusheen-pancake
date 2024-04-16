use AdventureWorks2019;

-- Update customer address

BEGIN TRANSACTION;
UPDATE [Person].[Address]
SET AddressLine1 = '123 Main St',
    City = 'New City',
    StateProvinceID = 1,
    PostalCode = '12345'
WHERE AddressID = 1;

COMMIT;