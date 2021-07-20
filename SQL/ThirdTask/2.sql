SELECT [CategoryName], MAX(UnitPrice) AS MaxPrice
  FROM [dbo].[Categories] INNER JOIN [dbo].[Products] ON [Categories].[CategoryID] = [Products].[CategoryID]
  GROUP BY [CategoryName]