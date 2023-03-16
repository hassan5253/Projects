sp_tables;
create table tblUsers
(
UserID int identity(100,1) primary key,
UName varchar(100) Unique,
UPass varchar(20),

NewCust varchar(10),
ViewCust varchar(10),
PrintCust varchar(10),

NewProd varchar(10),
ViewProd varchar(10),
PrintProd varchar(10),

AddNew varchar(10),
ViewItem varchar(10),
PrintItem varchar(10),

NewUser varchar(10),
ViewUser varchar(10),
PrintUser varchar(10)
);
Select * from tblUsers
Insert into tblUsers values ('Farooq','123','True','True','True','True','True','True','True','True','True','True','True','True');