create database PhonebookDB

use PhonebookDB

create table [Users](
	Id int primary key identity,
	Lgn nvarchar(255),
	Pwd nvarchar(max),	
)


insert into [Users] values ('daniel', 'A4c8kF0zWnc=')
insert into [Users] values ('alina', 'Cq8onC+DZtM=')

create table Contacts(
	Id int primary key identity,
	Phone nvarchar(255),
	Name nvarchar(255),
	UserId int foreign key references [Users](Id) on delete cascade
)

insert into Contacts values ('380935671234', 'Mam', 1)
insert into Contacts values ('380935671235', 'Dad', 1)
insert into Contacts values ('380935777234', 'Max', 1)
insert into Contacts values ('380935222234', 'Ann', 2)
insert into Contacts values ('380935111235', 'Nastya', 2)
insert into Contacts values ('380935333234', 'Tolyan', 2)


select * from Contacts join Users on Contacts.UserId = Users.Id