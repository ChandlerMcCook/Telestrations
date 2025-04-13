CREATE PROCEDURE [dbo].[spGame_Update]
	@Id int, 
	@Started bit
AS
begin 
	update dbo.[Game]
	set [Started] = @Started
	where Id = @Id;
end