CREATE PROCEDURE [dbo].[spGame_Insert]
	@Name nvarchar(50),
	@HostId int
AS
begin 
	insert into dbo.[Game] ([Name], [HostId])
	values (@Name, @HostId);

	declare @GameId int = SCOPE_IDENTITY();
	insert into dbo.[GamePlayers] ([GameId], [PlayerId])
	values (@GameId, @HostId);

	select @GameId as Id;
end
