CREATE PROCEDURE [dbo].[spGame_GetAll]
AS
begin
	select Id, [Name], CreatedAt, [Started], HostId
	from dbo.[Game];
end