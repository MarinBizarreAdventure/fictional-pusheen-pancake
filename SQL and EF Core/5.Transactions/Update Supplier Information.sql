USE AdventureWorks2019;
-- Update Supplier Information 

BEGIN TRANSACTION;
	UPDATE [Purchasing].[Vendor]
	SET Name = 'hehe'
	WHERE BusinessEntityID = 1492;

COMMIT;