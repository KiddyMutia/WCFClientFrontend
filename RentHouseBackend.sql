 --initializing
create database RentHouseBackend

use RentHouseBackend

-- Table Customer
create table tb_customer
(
	id int identity(1,1) NOT NULL,
	id_customer AS 'C' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	name varchar(100),
	birthdate date,
	address text,
	phonenumber varchar(20),
	card_type varchar(100),
	card_number varchar(100),
	email varchar(100),
	password varchar(100)
	PRIMARY KEY (id_customer)
);
select * from tb_customer
select * from tb_customer where name LIKE '%hud%'
insert into tb_customer (name,birthdate,address,phonenumber,card_type,card_number) values ('Hudya','1998-01-01','Kebayoran','083878409051','KTP','15100101100');
update tb_customer set name='Hudya Ramadhana', birthdate='1998-01-01',address='Kebayoran, Jakarta',
phonenumber='082382382',card_type='KTP',card_number='0123131' where id_customer = 'C002'
drop table tb_customer
-----------------------------------

-- Table Admin
create table tb_admin (
	id int identity(1,1) NOT NULL,
	id_admin AS 'A' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	name varchar(100),
	username varchar(100),
	password varchar(50),
	address text,
	phonenumber varchar(20),
	admin_type varchar(100),
	PRIMARY KEY (id_admin)
);

select * from tb_admin
select * from tb_admin where name LIKE '%hud%'
insert into tb_admin (name,username,password,address,phonenumber,admin_type) values ('Hudya Ramadhana','hudya','123456','Jakarta','09238232','SuperAdmin');
update tb_admin set name='M Hudya R', username='hudyaa',password='654321',address='Kebayoran, Jakarta',
phonenumber='082382382',admin_type='SuperAdmin' where id_admin = 'A001'
drop table tb_admin
----------------------------------------------


-- Table Room
create table tb_room(
	id int identity(1,1) NOT NULL,
	id_room AS 'R' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	id_room_type varchar(4),
	name varchar(100),
	status varchar(100),
	PRIMARY KEY (id_room)
);


select * from tb_room
select * from tb_room where name LIKE '%%'
select b.name,COUNT(b.name) as jumlah from tb_room a inner join tb_room_type b on a.id_room_type = b.id_room_type where a.status = 'Available' group by b.name


insert into tb_room (id_room_type,name) values ('P002','Kamar 7');
update tb_room set id_room_type='M001', name='Kamar Mentari',price='900000',
status='Aktif' where id_room = 'R001'
drop table tb_room

ALTER TABLE tb_room ADD CONSTRAINT DF_statustbroom DEFAULT 'Available' FOR status
--------------------------------------------

-- Table Room Type
create table tb_room_type(
	id int identity(1,1) NOT NULL,
	id_room_type AS 'P' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	name varchar(100),
	price bigint,
	information text,
	PRIMARY KEY (id_room_type)
);
use renthousebackend

select * from tb_room_type
select * from tb_room_type where name LIKE '%%'
insert into tb_room_type (name,price,information) values ('Tipe 2','1000000','AC Dan Kamar Mandi Dalam');
update tb_room_type set name='Type 1',price = 500000, information='AC Dan Kamar Mandi Dalam' where id_room_type = 'P001'
drop table tb_room_type
-------------------------------

-- Table Transaction
create table tb_transaction(
	id int identity(1,1) NOT NULL,
	id_transaction AS 'T' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	id_room varchar(4),
	id_customer varchar(4),
	datein date,
	dateout date,
	status varchar(100), -- 1 Rent In, 2 Rent Out
	PRIMARY KEY (id_transaction)	
);

select * from tb_transaction
select * from tb_transaction where id_transaction = ''
insert into tb_transaction (id_room,id_customer) values ('R001','C003');
update tb_transaction set dateout = GETDATE(), status = 'Rent Out' where id_transaction = 'T002'
drop table tb_transaction

ALTER TABLE tb_transaction ADD CONSTRAINT DF_datein DEFAULT getdate() FOR datein
ALTER TABLE tb_transaction ADD CONSTRAINT DF_statusrentin DEFAULT 'Rent In' FOR status
-----------------------------------------

-- Table Month Paid
create table tb_monthpaid(
	id int identity(1,1) NOT NULL,
	id_monthpaid AS 'M' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	id_transaction varchar(4),
	date_time datetime,
	total int,
	info text
);

select c.id_transaction,b.name,a.date_time,a.total,a.info from tb_monthpaid a
inner join tb_transaction c on c.id_transaction = a.id_transaction
inner join tb_room b on c.id_room = b.id_room
where c.id_transaction = 'T007'


select * from tb_monthpaid
select * from tb_monthpaid where id_transaction = ''
insert into tb_monthpaid (id_transaction,info) values ('T008','Untuk Pembayaran Bulan November 2017');
drop table tb_monthpaid


ALTER TABLE tb_monthpaid ADD CONSTRAINT DF_monthpaid DEFAULT getdate() FOR date_time
-----------------------------------------------------------------

-- Table Reservation
create table tb_reservation(
	id int identity(1,1) NOT NULL,
	id_reservation AS 'S' + RIGHT('000' + CAST(id as varchar(3)),3) PERSISTED, --varchar 4
	id_room varchar(4),
	id_customer varchar(4),
	date_time datetime,
	status varchar(50),
	info text
	PRIMARY KEY (id_reservation)
);

select c.id_transaction,b.name,a.date_time,a.total,a.info from tb_monthpaid a
inner join tb_transaction c on c.id_transaction = a.id_transaction
inner join tb_room b on c.id_room = b.id_room
where c.id_transaction = 'T007'

select * from tb_reservation
select * from tb_room
select * from tb_room_type

select * from tb_reservation where id_reservation = ''
insert into tb_reservation (id_room,id_customer,info) values ('R003','C003','Saya akan bayar besok');
delete from tb_reservation where id_reservation = 'S002'
--drop table tb_reservation


ALTER TABLE tb_reservation ADD CONSTRAINT DF_statusReservation DEFAULT 'Pending' FOR status
ALTER TABLE tb_reservation ADD CONSTRAINT DF_dateTimeReservation DEFAULT getdate() FOR date_time
-----------------------------------------------------------------


-- Relation between table
ALTER TABLE tb_room
ADD CONSTRAINT fk_Room_Type
FOREIGN KEY (id_room_type)
REFERENCES tb_room_type(id_room_type);

ALTER TABLE tb_transaction
ADD CONSTRAINT fk_idCustomer
FOREIGN KEY (id_customer)
REFERENCES tb_customer(id_customer);

ALTER TABLE tb_transaction
ADD CONSTRAINT fk_customerTransaction
FOREIGN KEY (id_customer)
REFERENCES tb_customer(id_customer);

ALTER TABLE tb_transaction
ADD CONSTRAINT fk_roomTransaction
FOREIGN KEY (id_room)
REFERENCES tb_room(id_room);

ALTER TABLE tb_monthpaid
ADD CONSTRAINT fk_monthTransaction
FOREIGN KEY (id_transaction)
REFERENCES tb_transaction(id_transaction);

ALTER TABLE tb_reservation
ADD CONSTRAINT fk_IDCustomerReservation
FOREIGN KEY (id_customer)
REFERENCES tb_customer(id_customer);

ALTER TABLE tb_reservation --
ADD CONSTRAINT fk_RoomReservation
FOREIGN KEY (id_room)
REFERENCES tb_room(id_room);


---------------------

-- Trigger

-- Trigger set status ke not available --
create trigger trg_action on [dbo].[tb_transaction]
after insert
as
	declare @idroom varchar(5)
	declare @idtransaction varchar(4)
	
	select @idroom = tb_transaction.id_room from inserted tb_transaction;
	select @idtransaction = tb_transaction.id_room from inserted tb_transaction;
	
	update tb_room set status = 'Not Available' where id_room = @idroom
	print 'BERHASIL'
go
	--trigger set status room menjadi available
	create trigger trg_action2 on [dbo].[tb_transaction]
	after update
	as
		declare @idroom varchar(5)
		declare @idtransaction varchar(4)
		
		select @idroom = tb_transaction.id_room from inserted tb_transaction;
		select @idtransaction = tb_transaction.id_transaction from inserted tb_transaction;
		
		update tb_room set status = 'Available' where id_room = @idroom
		--update transactionn set status = 'Rent Out', dateout = GETDATE() where id_transaction = @idtransaction
		print 'BERHASIL'
	go

	create trigger trg_totalHarga on [dbo].[tb_monthpaid]
	after insert
	as
		declare @idroom varchar(5)
		declare @idtransaction varchar(4)
		declare @idtransaction2 varchar(4)
		declare @idmonthlypaid varchar(4)
		declare @price int
		
		select @idroom = tb_transaction.id_room from tb_transaction;
		--select a.id_room,a.price from room a inner join transactionn b on b.id_room = a.id_room where id_transaction = 'P001'
		select @idtransaction = tb_transaction.id_transaction from tb_transaction;
		select @idtransaction2 = tb_monthpaid.id_transaction from inserted tb_monthpaid;
		select @price = c.price from tb_room a inner join tb_room_type c on c.id_room_type = a.id_room_type inner join tb_transaction b on a.id_room = b.id_room where b.id_transaction = @idtransaction2;
		select @idmonthlypaid = tb_monthpaid.id_transaction from inserted tb_monthpaid;
		
		update tb_monthpaid set total = @price where id_transaction = @idtransaction2
		--update transactionn set status = 'Rent Out', dateout = GETDATE() where id_transaction = @idtransaction
		print 'BERHASIL'
	go
	
	drop trigger trg_totalHarga


-- Event Query
CREATE EVENT event_statusBayar 
ON tb_transaction EVERY 1 DAY
STARTS CURRENT_TIMESTAMP + 1 DAY
DO
	declare @tanggal date
	declare @idtrans varchar(4)
	
	select @tanggal = tb_transaction.datein from tb_transaction
	select @idtrans = tb_transaction.id_transaction from inserted tb_transaction
	
	if(@tanggal = GETDATE())
	UPDATE tb_transaction set statusBayar = 'Not Paid' where id_transaction = @idtrans;
	PRINT 'BERHASIL'
END


-- Extra query
select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='tb_room';

