Create table ArchiveOperation(
	Id int primary key identity(1,1) not null,
	ClientId int foreign key references Client not null,
	DispenserId int foreign key references Dispenser not null,
	[Date] date default GetDate() not null,
	Amount decimal not null
)
