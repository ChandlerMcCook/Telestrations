CREATE PROCEDURE [dbo].[spGame_Delete]
	@Id int
AS
begin 
	delete
	from dbo.[Game]
	where Id = @Id;
end
