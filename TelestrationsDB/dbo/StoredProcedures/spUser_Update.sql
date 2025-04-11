CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int, 
	@Username nvarchar(30),
	@Password nvarchar(255)
AS
begin 
	update dbo.[User]
	set Username = @Username, [Password] = @Password
	where Id = @Id;
end