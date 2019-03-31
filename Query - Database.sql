create database Inventory

use Inventory

create table personal
(
	id_personal int identity(1,1) not null primary key,
	tipe char(1) not null,
	nama varchar(100) not null,
	email varchar(100) not null,
	contact varchar(20),
	company varchar(100),
	password varchar(20) not null
)
go

create table admin 
(
	id_personal int identity(1,1) not null primary key references personal(id_personal),
	username varchar(20) not null,
)
go

create table member
(
	id_personal int identity(1,1) not null primary key references personal(id_personal),
	NIM varchar(10) not null,
)
go

create table barang
(
	id_barang varchar(5) not null primary key,
	id_personal int not null foreign key references personal(id_personal),
	nama_barang varchar(50) not null,
	jenis_barang varchar(20) not null,
	stock int not null,
	satuan varchar(30) not null,
	keterangan varchar(15),
	tempat varchar(50) not null,
	status_barang varchar(30) not null
)
go

create table transaksi
(
	id_transaksi varchar(5) primary key not null,
	id_personal int not null references personal(id_personal),
	id_barang varchar(5) foreign key references barang(id_barang) not null,
	tgl_pinjam date not null,
	tgl_kembali date not null,
	jumlah int not null,
	deskripsi text,
	surat text not null,
	status_transaksi varchar(30) not null,
)
go

--Constraint Barang
alter table barang add constraint cek_barang check(jenis_barang IN('Kayu', 'Besi', 'Aluminium', 'Plastik', 'Lain-lain'))
go
alter table barang add constraint cek_status check(status_barang IN('Baik', 'Rusak', 'Masih bisa digunakan'))
go
alter table barang add constraint cek_tempat check(tempat IN('Camp', 'Sekre', 'Gudang'))
go
alter table barang add constraint cek_satuan check(satuan IN('Pcs', 'Kg', 'Packs'))
go
alter table barang add constraint cek_ket check(keterangan IN('Dipinjam', 'Tersedia'))
go

--Constraint transaksi
alter table transaksi add constraint cek_transaksi check(status_transaksi IN('Diterima','Ditolak', 'Menunggu', 'Dikembalikan', 'Belum Dikembalikan'))
go

--Procedure Insert Data
CREATE PROC InsertPersonal(@tipe char(1), @nama VARCHAR(100), @email VARCHAR(100), @contact varchar(13), @company VARCHAR(30), @password VARCHAR(20), @username varchar(20), @NIM varchar(10))
AS
  DECLARE @newID AS INT
  INSERT INTO personal(tipe, nama, email, contact, company, password) VALUES(@tipe, @nama, @email, @contact, @company, @password)
  SET @newID = SCOPE_IDENTITY()
  IF (@tipe = 'A')
	BEGIN
		SET IDENTITY_INSERT member OFF
		SET IDENTITY_INSERT admin ON
		INSERT INTO admin(id_personal, username) VALUES(@newID, @username)
	END
  ELSE
	BEGIN
		SET IDENTITY_INSERT admin OFF
		SET IDENTITY_INSERT member ON
		INSERT INTO member(id_personal, NIM) VALUES(@newID, @NIM)
	END
go

exec InsertPersonal 'A', 'Muhammad Taptazani Adi', 'm.taftazani123@gmail.com', '085393051298', 'Sistem Informasi', 'doto', 'melon', NULL
go
exec InsertPersonal 'M', 'Muhammad Taptazani Adi', 'm.taftazani123@gmail.com', '085393051298', 'Sistem Informasi', '36456', NULL, '16.12.8983'
go
exec InsertPersonal 'M', 'Intan Disty Anggraini', 'intandistyanggraini@gmail.com', '0895604565563', 'Ilmu Komunikasi', '54360', NULL, '17.96.0165'
go

--Procedure Update Data
CREATE PROC UpdateData (@nama VARCHAR(100), @email VARCHAR(100), @contact varchar(13), @company VARCHAR(30), @password VARCHAR(20),@username varchar(20), @NIM varchar(10), @tipe CHAR(1), @id_personal int)
AS
	UPDATE personal SET nama = @nama, email = @email, contact = @contact, company = @company, password = @password WHERE tipe = @tipe AND id_personal = @id_personal
	IF (@tipe = 'A')
		BEGIN
			UPDATE Admin SET username = @username FROM admin, personal
		END
	ELSE
		BEGIN
			UPDATE member SET NIM = @NIM FROM member, personal WHERE member.NIM = @NIM
		END
go

exec UpdateData 'Muhammad Taftazani Adi', 'm.taftazani123@gmail.com', '085787572313', 'Sistem Informasi', 'melondoto', 'Melon', null, 'A', 1
exec UpdateData 'Muhammad Taftazani Adi', 'm.taftazani123@gmail.com', '085787572313', 'Sistem Informasi', 'melon', null, '16.12.8983', 'M', 2

drop proc UpdateMember


--Insert Barang
INSERT INTO barang VALUES('B0001', 1, 'Meja', 'Kayu', 5, 'pcs', 'Tersedia', 'Sekre', 'Baik')
go
INSERT INTO barang VALUES('B0002', 1, 'Kursi', 'Kayu', 1, 'pcs', 'Tersedia', 'Sekre', 'Baik')
go

--Insert Transaksi
INSERT INTO transaksi VALUES('T0001', 2, 'B0001', '2019-01-10', '2019-01-11', 2, '', '', 'Menunggu')
go

select * from personal

delete from personal

--View Transaksi
Create view BuktiTransaksi
As
	SELECT t.id_transaksi, m.NIM, b.nama_barang, t.tgl_pinjam, t.tgl_kembali, t.jumlah, t.deskripsi, t.surat, t.status_transaksi FROM transaksi t JOIN member m 
	ON t.id_personal = m.id_personal JOIN personal p ON t.id_personal = p.id_personal JOIN barang b ON b.id_barang = t.id_barang

select * from transaksi

