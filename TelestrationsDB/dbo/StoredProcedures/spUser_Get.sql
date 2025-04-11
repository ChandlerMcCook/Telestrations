CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin
	select Id, Username, [Password]
	from dbo.[User]
	where Id = @Id;
end