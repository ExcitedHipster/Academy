Begin transaction
	insert into Dbo.ArchiveOperation(ClientId,DispenserId,[Date],Amount)
	Select Top (3) ClientId,DispenserId,[Date],Amount from dbo.Operations ORDER BY ID DESC
	delete top (3)  from dbo.Operations
commit