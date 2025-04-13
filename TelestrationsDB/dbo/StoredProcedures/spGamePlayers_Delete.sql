CREATE PROCEDURE [dbo].[spGamePlayers_Delete]
	@GameId int,
	@PlayerId int
AS
begin
	delete 
	from dbo.[GamePlayers]
	where [GameId] = @GameId and [PlayerId] = @PlayerId;
end