create table tblEMP
(
	Eid int identity(100, 1)primary key,
	Name varchar(50),
	Phone varchar(50),
	Email varchar(50),
	Address varchar(50),
	HomeNo varchar(50),
);

select * from tblEMP

insert into tblEMP values('Aamir','0345-1234567','aamirashrafh@gmail.com','Karachi','021-3112344566')_