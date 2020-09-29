Begin transaction
	Update dbo.Client set Balance=Balance-50 Where Id=1
	Insert dbo.Operations(ClientId,DispenserId,[Date],Amount)
		VALUES(1,1,GETDATE(),50)
Commit