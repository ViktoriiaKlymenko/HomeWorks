SELECT [Region].RegionID, [Region].RegionDescription 
FROM [dbo].[Territories]
JOIN [dbo].[Region]  ON [Region].RegionID = [Territories].RegionID
JOIN [dbo].[EmployeeTerritories] ON [Territories].TerritoryID = [EmployeeTerritories].TerritoryID
WHERE [Territories].TerritoryID IS NULL;