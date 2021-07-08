ALTER PROCEDURE [dbo].[AddNewId] 
@Name nchar(10),
@Description nchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Region] VALUES (NEWID(), @Name, @Description)
END
