create database PhonebookDB


create table [Users](
	Id int primary key identity,
	Lgn nvarchar(255),
	Pwd nvarchar(max),	
)


insert into [Users] values ('daniel', '123')

create table Contacts(
	Id int primary key identity,
	Phone nvarchar(255),
	Name nvarchar(255),
	UserId int foreign key references [Users](Id) on delete cascade
)

insert into Contacts values ('+380935671234', 'Mam', 1)
insert into Contacts values ('+380935671235', 'Dad', 1)

select * from Contacts join Users on Contacts.UserId = Users.Id