DECLARE @Id nchar(50)
EXECUTE [AddNewId] @Id, 'Regions'

INSERT INTO [dbo].[Regions] 
           ([Id], [Name], [Description])
     VALUES
           (@Id, 'Region name', 'Region description')