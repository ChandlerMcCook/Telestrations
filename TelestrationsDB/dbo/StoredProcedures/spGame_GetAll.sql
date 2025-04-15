CREATE PROCEDURE [dbo].[spGame_GetAll]
AS
begin
	select Id, [Name], CreatedAt, HostId
	from dbo.[Game]
	where [Started] = 0;
end