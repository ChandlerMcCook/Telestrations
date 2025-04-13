CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select Id, Username
	from dbo.[User];
end
