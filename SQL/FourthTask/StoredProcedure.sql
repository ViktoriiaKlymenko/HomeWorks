ALTER PROCEDURE [dbo].[AddNewId] 
@Id nchar(50) OUTPUT,
@TableName nchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT @Id = (CAST(NEWID()as nchar(50)) + @TableName)
END
