Create table Client(
	Id int primary key identity(1,1) not null,
	[Name] nvarchar(50) not null,
	CardNumber nvarchar(50) not null,
	Balance decimal not null,
)
GO

Create table Dispenser(
	Id int primary key identity(1,1) not null,
	[Address] nvarchar(50) not null,
)
GO

Create table Operations(
	Id int primary key identity(1,1) not null,
	ClientId int foreign key references Client not null,
	DispenserId int foreign key references Dispenser not null,
	[Date] date default GetDate() not null,
	Amount decimal not null
)
