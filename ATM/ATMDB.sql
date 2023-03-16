create database ATMDB;
use ATMDB;

create table tblCustomer
(
AccountNo int identity(1000,2) primary key,
PinNo int,
FullName varchar(100),
PhoneNo  varchar(20) unique,
N_I_C    varchar(20) unique,
Adress   varchar(100),
Date_Time Date
);


Insert into tblCustomer values ('1010','Muhammad Nouman','0300-1234567','42101-1234',' Karachi',GETDATE());
Insert into tblCustomer values ('1000','Hassan','0300-12345','42101-1234567',' Karachi',GETDATE());
Insert into tblCustomer values ('1212','Muffasil','0300-1234567','42101-1234567-9',' Karachi',GETDATE());
Insert into tblCustomer values ('1234','Sohail','0300-12367','4211-1234567-9',' Karachi',GETDATE());
select * from tblCustomer




----------------------------------------
create table tblUsers
(
UName varchar(50) primary key,
UPass varchar(20),
Roll varchar(10)
);
Insert into tblUsers values ('Admin', 'abc123','Admin');
Insert into tblUsers values ('Farooq','abc123','Admin');
Insert into tblUsers values ('User1', 'abcdef','Normal');
Insert into tblUsers values ('User2', '123456','Normal');
Select * from tblUsers;
----------------------------------------------------------------------
create table tblTransactions
(
	AID int   identity(100,1) primary key,
	AccountNo int,
	Balance   int,
	Deposit   int,
	WithDraw  int,
	Remarks   varchar(50),
	Date_Time date
)
Select * from tblTransactions;
Insert into tblTransactions values (1000,500,500,0,'Deposit Amount',GETDATE());
Insert into tblTransactions values (1000,10500,10000,0,'Deposit Amount',GETDATE());
Insert into tblTransactions values (1000,8500,0,2000,'WithDraw Amount',GETDATE());
Insert into tblTransactions values (1000,14500,6000,0,'Deposit Amount',GETDATE());
insert into tblTransactions values (1000,10500,0,4000,'WithDraw Amount',GETDATE());
