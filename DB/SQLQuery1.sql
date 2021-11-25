create database SparrowDB

use SparrowDB
--create a table

create table invoice_add(
id int not null primary key identity(1,1),
customerName varchar(80) null,
customerEmail varchar(80) null,
customerAddress varchar(80)  null,
productDesc varchar(80) not null,
prod_Qty varchar(80) not null,
prod_price float not null,
total_price float not null,
invoice_price float not null,
invoice_id varchar(80)  null,
invoice_Date varchar(90)  null,
due_date varchar(80)  null,

)




create table proforma_add(
id int not null primary key identity(1,1),
customerName varchar(80) null,
customerEmail varchar(80) null,
customerAddress varchar(80)  null,
productDesc varchar(80) not null,
prod_Qty varchar(80) not null,
prod_price float not null,
total_price float not null,
prof_price float not null,
prof_id varchar(80)  null,
prof_Date varchar(90)  null,


)

select * from proforma_add



--users table
create table SparrowUsers(
id int identity(1,1) primary key not null,
username varchar(80) not null,
userrole varchar(80) not null,
passworduser varchar(80) not null
)

--proc to register user
create proc Reguser_sp
@uname varchar(80),
@urole varchar(80),
@upass varchar(80)
AS
BEGIN
insert into SparrowUsers(username,userrole,passworduser) values(@uname,@urole,@upass)
End



--update user
create proc UpdateUser_sp
@id int ,
@uname varchar(80),
@urole varchar(80),
@upass varchar(80)
AS 
BEGIN
update SparrowUsers set username=@uname,userrole=@urole,passworduser=@upass
End


--insert temp user [default]
 insert into SparrowUsers(username,userrole,passworduser)
values('user','Admin','user')

 





/*--store procedure to insert
create proc insertInvoice_sp
@cname varchar(80),
@cemail varchar(80),
@cadd varchar(80),
@proddesc varchar(80),
@prodqty varchar(80),
@prodprice varchar(80), 
@totprice float,
@invid float,
@invdate varchar(80),
@duedate varchar(80)

AS
  BEGIN
  INSERT INTO invoice_add(customerName,customerEmail,customerAddress,productDesc,prod_Qty,prod_price,total_price,invoice_id,invoice_Date,due_date)
  VALUES(@cname,@cemail,@cadd,@proddesc,@prodqty,@prodprice , @totprice,@invid ,@invdate,@duedate)
  end
  */