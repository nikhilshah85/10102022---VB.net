create database bankingDB_VB
use bankingDB_VB

	create table Accounts
	( 
		accNo int primary key,
		accName varchar(20),
		accType varchar(20),
		accBalance int,
		accIsActive bit
	)
	insert into Accounts values(101,'Nikhil','Savings',4000,1)
	insert into Accounts values(102,'Priya','Savings',14000,1)
	insert into Accounts values(103,'Riya','Current',42000,0)
	insert into Accounts values(104,'Aman','Savings',300,0)
	insert into Accounts values(105,'Suman','PF',45000,1)
select * from Accounts







create table loginInfo
(
	userName varchar(20) primary key,
	password varchar(20)
	)
	
insert into loginInfo values('Nikhil','Pass@1234')
insert into loginInfo values('Rahul','rahul@1234')
insert into loginInfo values('Jayesh','jayesh@1234')

select * from loginInfo





