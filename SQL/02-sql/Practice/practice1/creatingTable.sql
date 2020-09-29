create table Transactions(
			ID int Primary Key Identity(1,1) not null,
			SourceUserName varchar(100) not null,
			DestinationUserName varchar(1000) not null,
			Amount int not null,
			CreatedAt date default Convert(date,GETDATE()) not null
)