SELECT [ProductID]
      ,[ProductName]
      ,[SupplierID]
      ,[CategoryID]
      ,[QuantityPerUnit]
      ,[UnitPrice]
  FROM [dbo].[Products]  
  WHERE [UnitPrice] > (SELECT AVG(UnitPrice) FROM [dbo].[Products])