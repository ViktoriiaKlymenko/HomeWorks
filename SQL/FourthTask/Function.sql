CREATE FUNCTION SetId(@TableName nchar(10), @Id nchar(36))
RETURNS nchar(50)
BEGIN
RETURN SUBSTRING(@TableName, 0, 8) + @ID
END