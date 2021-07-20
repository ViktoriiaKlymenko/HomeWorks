INSERT INTO [dbo].[Regions] 
           ([Id], [Name], [Description])
     VALUES
           ([dbo].SetId('Regions', NEWID()), 'Region name', 'Region description')