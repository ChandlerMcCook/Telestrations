if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (Username, [Password])
	values ("Test1", "T1pass"),
	("Test2", "T2pass"),
	("Test3", "T3pass");
end
