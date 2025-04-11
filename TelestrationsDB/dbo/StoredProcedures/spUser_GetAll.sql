CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select Id, Username, [Password]
	from dbo.[User];
end
