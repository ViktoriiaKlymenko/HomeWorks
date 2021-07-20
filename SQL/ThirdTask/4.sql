USE [Northwind]
GO

SELECT [Region].RegionID, [Region].RegionDescription 
FROM [dbo].[Territories]
INNER JOIN [dbo].[EmployeeTerritories] ON [Territories].TerritoryID = [EmployeeTerritories].TerritoryID
RIGHT JOIN [dbo].[Region]  ON [Region].RegionID = [Territories].RegionID
WHERE [Territories].TerritoryID IS NULL; 

GO


