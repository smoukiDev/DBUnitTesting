CREATE FUNCTION [dbo].[GetSearchTermCount]
(	
	@SearchTerm varchar(50)	 
)
RETURNS int 
AS begin
    declare @Count Int
	Select @Count =  count(*) FROM [dbo].[Department] WHERE [DepartmentName] LIKE '%' + @SearchTerm + '%'
	RETURN @Count;
end