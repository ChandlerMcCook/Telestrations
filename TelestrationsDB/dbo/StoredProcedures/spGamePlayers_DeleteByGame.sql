CREATE PROCEDURE [dbo].[spGamePlayers_DeleteByGame]
	@GameId int
AS
begin
	delete
	from dbo.[GamePlayers]
	where [GameId] = @GameId;
end