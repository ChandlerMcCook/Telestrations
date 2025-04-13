CREATE PROCEDURE [dbo].[spGamePlayers_GetPlayersByGame]
	@GameId int
AS
begin
	select [PlayerId] as Id
	from dbo.[GamePlayers]
	where [GameId] = @GameId;
end