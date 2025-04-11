CREATE PROCEDURE [dbo].[spUser_Insert]
	@Username nvarchar(30),
	@Password nvarchar(255)
AS
begin 
	insert into dbo.[User] (Username, [Password])
	values (@Username, @Password);
end
