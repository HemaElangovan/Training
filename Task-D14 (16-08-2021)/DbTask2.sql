create database Shop

use Shop

create table Customer
(
CustomerId int, Name varchar(50), City varchar(50), Email varchar(50), Phone varchar(10),
constraint PK_Cid primary key (CustomerId)
)
select * from Customer
drop table Customer

insert into Customer values (01,'Ross', 'Kolkata', 'ross@gmail.com', '8564123568');
insert into Customer values (02,'Rachel', 'Chennai', 'rach@yahoo.com', '9142950708');
insert into Customer(CustomerId, Name, City,Email,Phone)values (03,'Monica', 'Kochi', 'mon@yahoo.com', '9523818794');
insert into Customer(CustomerId, Name, City,Email,Phone)values (04,'Chandler', 'Bangalore', 'chan@gmail.com', '8441234568');



create table Product(
ProductCode int, Name varchar(50), Price int,
constraint PK_Pcode primary key (ProductCode)
)
insert into Product values (100, 'Jaggery', 75);
insert into Product values (101, 'WhiteSugar', 55);
insert into Product values (102, 'Channa Dal', 88);
insert into Product values (103, 'Health Mix', 63);
insert into Product values (104, 'Garam Masala', 45);
insert into Product values (105, 'Chilly Powder', 40);
insert into Product values (106, 'Hand wash', 55);

select * from Product

update Product set Price = 42 where Name ='Chilly Powder'; 

delete from Product where Name='Hand Wash'

drop table Product

create table Orders 
(
OrderId int, CustomerId int, OrderDate Date,
constraint PK_Oid primary key (OrderId),
constraint FK_Cid Foreign key (CustomerId) references Customer(CustomerId)
)
Insert into Orders values (1001,01,GETDATE());
Insert into Orders values (1002,03,GETDATE());
Insert into Orders values (1003,04,GETDATE());
Insert into Orders values (1004,02,GETDATE());
Insert into Orders values (1005,02,GETDATE());

select OrderID, CustomerId, cast (GetDate() as Date) as OrderDate 
from Orders

drop table Orders

create table OrderItems(
TNo int,OrderID int, Productcode int, Quantity int
constraint PK_Tno primary key(TNo),
constraint FK_Oid Foreign key(OrderID) references Orders(OrderId),
constraint FK_Pc Foreign key(Productcode) references Product(ProductCode)
)

insert into OrderItems values (2,1004,104,3)
insert into OrderItems values (3,1001,102,19)
insert into OrderItems values (5,1002,101,24)
insert into OrderItems values (4,1005,103,5)
insert into OrderItems values (1,1004,101,32)

select * from OrderItems

update OrderItems set Quantity=13 where Quantity=3

drop table OrderItems

select oi.TNo, oi.OrderID, oi.Productcode, oi.Quantity, cus.CustomerId, pro.Price, od.OrderDate
from OrderItems oi
join Orders od 
on oi.OrderID = od.OrderId
join Customer cus
on cus.CustomerId =od.CustomerId
join Product pro
on pro.ProductCode = oi.Productcode;

select od.OrderId,cus.CustomerId, od.OrderDate, SUM(pro.Price) as Total_Price
from Orders od 
join OrderItems oi
on oi.OrderID = od.OrderId
join Customer cus
on cus.CustomerId = od.CustomerId
join Product pro
on pro.ProductCode = oi.Productcode
group by od.OrderId, cus.CustomerId, od.OrderDate
  






