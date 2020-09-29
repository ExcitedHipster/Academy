create table Blog(
	ID int Primary Key Identity(1,1) not null,
	Name varchar(10) not null,
	Description varchar(40),
	CreatedAt date default convert(date,GETDATE()) not null
)