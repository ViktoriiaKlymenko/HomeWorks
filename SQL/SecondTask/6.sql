USE [Northwind]
GO

SELECT [Region]
      ,[Country]
	  , COUNT(*) AS ProvidersAmount
  FROM [dbo].[Suppliers]
  WHERE REGION IS NOT NULL
  GROUP BY [Region], [Country]
GO


