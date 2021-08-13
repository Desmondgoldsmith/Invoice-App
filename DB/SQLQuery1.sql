create database SparrowDB

use SparrowDB
--create a table

create table invoice_add(
id int not null primary key identity(1,1),
customerName varchar(80) not null,
customerEmail varchar(80) null,
customerAddress varchar(80)  null,
productDesc varchar(80) not null,
prod_Qty varchar(80) not null,
prod_price float not null,
total_price float not null,
invoice_price varchar(80) not null,
invoice_id varchar(80) not null,
invoice_Date varchar(90) not null,
due_date varchar(80) not null,

)



--store procedure to insert
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