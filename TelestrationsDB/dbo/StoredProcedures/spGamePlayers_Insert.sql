CREATE PROCEDURE [dbo].[spGamePlayers_Insert]
	@GameId int,
	@PlayerId int
AS
begin
	insert into dbo.[GamePlayers] ([GameId], [PlayerId])
	values (@GameId, @PlayerId);
end