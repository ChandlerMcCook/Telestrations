CREATE PROCEDURE [dbo].[spGame_Get]
	@Id int
AS
begin
	select Id, [Name], [Started], [CreatedAt], HostId
	from dbo.[Game]
	where Id = @Id;
end