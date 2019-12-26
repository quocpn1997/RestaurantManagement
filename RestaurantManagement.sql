--Create database
CREATE DATABASE RestaurantManagement
USE RestaurantManagement
--drop database RestaurantManagement

--Create table
CREATE TABLE [USER]
(
	USERNAME	varchar(25) not null primary key,
	PASSWORD	varchar(25) not null,
	ROLE		varchar(10),
	NAME		varchar(40),
	GENDER		bit,
	BIRTHDAY	date,
	PHONE		varchar(15),
	ADDRESS		varchar(40),
)

CREATE TABLE [TABLE]
(
	TABLEID varchar(2) not null primary key,
	STATUS	varchar(5)
)

CREATE TABLE [FOOD]
(
	FOODID	int identity(1,1) primary key,
	NAME	varchar(50),
	PRICE	integer
)

CREATE TABLE [ORDER]
(
	ORDERID		int identity(1000,1) primary key,
	TABLEID		varchar(2),
	TIME		date,
	STATUS		varchar(10),
	TOTAL		int
)

CREATE TABLE [ORDERDETAIL]
(
	ORDERID		int not null,
	FOODID		int not null,
	QUANTITY	int,
	CONSTRAINT PK_ORDERDATAIL PRIMARY KEY (ORDERID, FOODID)
)

--INSERT DATA
INSERT INTO [USER](USERNAME, PASSWORD, NAME, ROLE) VALUES ('quanly', '123456', 'Pham Nguyen Quoc', 'Manager'); 
INSERT INTO [USER](USERNAME, PASSWORD, NAME) VALUES ('nhanvien', '123456', 'Nhan Vien');

INSERT INTO [TABLE] VALUES ('01', 'Empty');
INSERT INTO [TABLE] VALUES ('02', 'Empty');
INSERT INTO [TABLE] VALUES ('03', 'Empty');
INSERT INTO [TABLE] VALUES ('04', 'Empty');
INSERT INTO [TABLE] VALUES ('05', 'Empty');
INSERT INTO [TABLE] VALUES ('06', 'Empty');
INSERT INTO [TABLE] VALUES ('07', 'Empty');
INSERT INTO [TABLE] VALUES ('08', 'Empty');
INSERT INTO [TABLE] VALUES ('09', 'Empty');
INSERT INTO [TABLE] VALUES ('10', 'Empty');

INSERT INTO [FOOD] VALUES ('Hot Dog', 20000);
INSERT INTO [FOOD] VALUES ('Burger', 40000);
INSERT INTO [FOOD] VALUES ('Pho', 50000);
INSERT INTO [FOOD] VALUES ('Beefsteak', 200000);
INSERT INTO [FOOD] VALUES ('Noodle', 50000);
INSERT INTO [FOOD] VALUES ('Fry Chicken', 100000);
INSERT INTO [FOOD] VALUES ('Coca-cola', 10000);
INSERT INTO [FOOD] VALUES ('Chicken', 10000);

INSERT into [ORDER] values ('03', convert(date, '01/01/2018', 103), 'Done', 180000);
INSERT into [ORDER] values ('01', convert(date, '13/01/2018', 103), 'Done', 50000);
INSERT into [ORDER] values ('07', convert(date, '12/02/2018', 103), 'Done', 70000);
INSERT into [ORDER] values ('01', convert(date, '20/02/2018', 103), 'Done', 200000);
INSERT into [ORDER] values ('05', convert(date, '01/03/2018', 103), 'Done', 50000);
INSERT into [ORDER] values ('02', convert(date, '05/04/2018', 103), 'Done', 500000);
INSERT into [ORDER] values ('04', convert(date, '26/04/2018', 103), 'Done', 10000);
INSERT into [ORDER] values ('09', convert(date, '12/05/2018', 103), 'Done', 70000);
INSERT into [ORDER] values ('10', convert(date, '20/05/2018', 103), 'Done', 200000);
INSERT into [ORDER] values ('09', convert(date, '12/05/2018', 103), 'Done', 80000);
INSERT into [ORDER] values ('01', convert(date, '21/05/2018', 103), 'Done', 120000);

--drop table [USER]
--drop table [TABLE]
--drop table [ORDER]
--drop table [ORDERDETAIL]
--drop table [FOOD]