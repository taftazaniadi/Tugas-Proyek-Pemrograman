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

insert into status_barang values(1, 'Baik')
insert into status_barang values(2, 'Rusak')
insert into status_barang values(3, 'Masih Bisa')

insert into status_transaksi values(1, 'Dipinjam')
insert into status_transaksi values(2, 'Dikembalikan')

insert into jenis_barang values('J0001', 'Kayu')

insert into barang values('B0001', 'Meja', 'J0001', 5, 1)

select * from status_transaksi

create table Jenis_Barang
(
	id_jenis varchar(5) not null primary key,
	nama varchar(50) not null,
)

create table status_barang
(
	id_status int not null primary key,
	nama varchar(15) not null,
)

create table status_transaksi
(
	id_status_transaksi int not null primary key,
	nama varchar(15) not null,
)

create table barang
(
	id_barang varchar(5) not null primary key,
	nama varchar(50) not null,
	id_jenis varchar(5) not null foreign key references Jenis_Barang(id_jenis),
	stock int not null,
	id_status int not null foreign key references status_barang(id_status)
)

create table Transaksi
(
	id_transaksi varchar(5) primary key not null,
	NIM varchar(10) foreign key references member(NIM) not null,
	id_barang varchar(5) foreign key references barang(id_barang) not null,
	tgl_pinjam date not null,
	tgl_kembali date not null,
	jumlah int not null,
	id_status_transaksi int foreign key references status_transaksi(id_status_transaksi) not null,
)

SELECT b.id_barang, b.nama, j.nama, b.stock, s.nama FROM barang AS b JOIN jenis_barang AS j ON b.id_jenis = j.id_jenis JOIN status_barang AS s ON b.id_status = s.id_status