UPDATE [dbo].[Pastries]
   SET [Amount] *= 2
   FROM [dbo].[Pastries]
    JOIN [dbo].[PastryTypes] ON [PastryTypes].[Id] = [Pastries].[TypeId]
 WHERE [PastryTypes].[Id] = 2
 SELECT * FROM [dbo].[Pastries]