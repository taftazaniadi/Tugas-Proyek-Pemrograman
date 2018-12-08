create database Inventory

use Inventory

create table admin
(
	id_admin varchar(5) not null primary key,
	username varchar(20) not null,
	password varchar(20) not null,
	nama varchar(100) not null,
	email varchar(100) not null,
	contact varchar(13)
)

create table member
(
	NIM varchar(10) not null primary key,
	nama varchar(100) not null,
	password varchar(20) not null,
	email varchar(100) not null,
	contact varchar(13) not null,
	jurusan varchar(30)
)

insert into admin values('A0001', 'Melon', 'doto', 'Muhammad Taptazani Adi', 'm.taftazani123@gmail.com', '085393051298')

insert into member values('16.12.8983', 'Muhammad Taptazani Adi', '36456', 'm.taftazani123@gmail.com', '085393051298', 'Sistem Informasi')