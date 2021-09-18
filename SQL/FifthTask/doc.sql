DECLARE @doc nvarchar(1000)
SET @doc = '<dbo.PastryTypes Id="1" Name="Cake      " />
<dbo.PastryTypes Id="2" Name="Pie       " />
<dbo.PastryTypes Id="3" Name="Croissant " />
<dbo.PastryTypes Id="4" Name="Eclair    " />
<dbo.PastryTypes Id="5" Name="Puff      " />
<dbo.PastryTypes Id="6" Name="Bun       " />'
 EXEC AddDataFromXML @doc