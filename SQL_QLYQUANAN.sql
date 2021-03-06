CREATE DATABASE QL_QUANAN
GO
USE QL_QUANAN
GO

create table NhanVien
(
	maNV int identity not null primary key,
	hoTen nvarchar(50) not null,
	gioiTinh nvarchar(15) not null,
	diaChi nvarchar(100) not null,
	SDT nvarchar(100) not null
)
go
CREATE TABLE TaiKhoan
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	taiKhoan nvarchar(50),
	matKhau nvarchar(30),
	tenHienThi nvarchar(50),
	maNV int not null,
)
GO

CREATE TABLE BaoCao
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	iDTaiKhoan int,
	noiDung text
)
GO

CREATE TABLE NguyenLieu
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	tenNguyenLieu nvarchar(50), 
	soLuong float,
	donVi nvarchar(15)
)
GO	
CREATE TABLE MonAn
(
	iDMonAn int IDENTITY(1,1) PRIMARY KEY,
	donGia int,
	tenMon nvarchar(50)
)
GO	
CREATE TABLE InforMonAn
(
	idMonAn int not null,
	idNguyenLieu int not null,
	soLuong int not null,
	primary key(idMonAn,idNguyenLieu)
)
CREATE TABLE HoaDon
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	ngayXuatHD date,
	trangthai int
)
GO	

CREATE TABLE BanAn
(
	iDBan int IDENTITY(1,1) PRIMARY KEY,
	trangThai int default 0 check(trangThai = 0 OR trangThai = 1)
)
GO	
CREATE TABLE InfoHoaDon
(
	iD int identity primary key,
	iDHoaDon int,
	iDMonAn int,
	soLuong int,
	iDBan int
)
GO	



ALTER TABLE baoCao ADD CONSTRAINT FK_BaoCao FOREIGN KEY (iDTaiKhoan) REFERENCES TaiKhoan(iD)
go
ALTER TABLE InfoHoaDon ADD CONSTRAINT FK_HD FOREIGN KEY (iDHoaDon) REFERENCES HoaDon(ID)
go
ALTER TABLE InfoHoaDon ADD CONSTRAINT FK_HD2 FOREIGN KEY (iDMonAn) REFERENCES MonAn(iDMonAn)
go
ALTER TABLE InfoHoaDon ADD CONSTRAINT FK_HD3 FOREIGN KEY (iDBan) REFERENCES BanAn(iDBan)
go
ALTER TABLE TaiKhoan ADD CONSTRAINT FK_TK FOREIGN KEY (maNV) references NhanVien(maNV)
go
ALTER TABLE InforMonAn ADD CONSTRAINT FK_IF FOREIGN KEY(idMonAn) references MonAn(iDMonAn)
go
ALTER TABLE InforMonAn ADD CONSTRAINT FK_IF1 FOREIGN KEY(idNguyenLieu) references NguyenLieu(iD)
go

INSERT INTO TaiKhoan (taiKhoan, matKhau, tenHienThi, hoTen, gioiTinh)
VALUES ('liem123', '123456', 'Liêm Lê', 'Lê Liêm', N'Nam'),
		('linh123', '123456', 'Linh Lý', 'Lý Thị Kim Linh', N'Nữ')
GO



INSERT INTO MonAn (tenMon, donGia) VALUES (N'Gà chiên nước mắm', 45000),
										  (N'Thịt kho hột vịt', 30000),
										  (N'Cá diêu hồng sốt cà chua', 45000),
										  (N'Tôm nướng muối ớt', 90000),
										  (N'Tôm hấp nồi đất', 110000),
										  (N'Bò lá lốt', 60000),
										  (N'Bia tiger', 20000),
										  (N'Bia sài gòn đỏ', 15000),
										  (N'Coca cola', 12000),
										  (N'Nước suối', 5000)
go	

INSERT INTO BanAn(trangThai) VALUES (1),(0),(1),(0),(1),(0),(0),(1),(0),(0),(0),(0),(1),(0),(1),(0),(0),(0)
go	

go
INSERT INTO NguyenLieu(tenNguyenLieu, soLuong, donVi) VALUES  (N'Gà', 1, 'kg')
															, (N'Cá diêu hồng', 800, 'g')
															, (N'Thịt', 1, 'kg')
															, (N'Trứng gà', 12, N'quả')
															, (N'Trứng vịt lộn', 12, N'quả')
															, (N'Tôm', 1, 'kg')
															, (N'Thịt bò', 1, 'kg')
															, (N'Đùi gà', 1, 'kg')
go
set dateformat dmy															
INSERT INTO HoaDon(ngayXuatHD,trangThai) VALUES('20/9/2020',1),
									  ('11/04/2020',0),
									 ('15/7/2020',0),
									 ('05/2/2020',1)
									 
INSERT INTO InfoHoaDon(iDHoaDon,iDMonAn,iDBan,soLuong) VALUES (1,1,1,9),
									   (1,1,1,10),
									   (1,3,1,1),
									   (3,3,3,9),
									   (1,3,5,8)
go	

create proc sp_getTableList
as select * from BanAn

create proc sp_showHoaDon
as
begin
select M.tenMon as N'Tên Món',count(soLuong) as N'Số Lượng' ,M.donGia*count(soLuong) as N'Đơn Giá'
from InfoHoaDon I,HoaDon H,MonAn M
where I.iDHoaDon = H.ID and I.iDMonAn = M.iDMonAn
group by M.tenMon,M.donGia
end;

create proc sp_ShowHoaDonByTableID @tableID int
as
begin
select M.tenMon as N'Tên Món',count(soLuong) as N'Số Lượng' ,M.donGia as N'Đơn Giá',m.donGia*COUNT(soLuong) as N'Thành tiền'
from InfoHoaDon I,HoaDon H,MonAn M
where I.iDHoaDon = H.ID and I.iDMonAn = M.iDMonAn and iDBan = @tableID and H.trangthai=0
group by M.tenMon,M.donGia
end;
insert into InfoHoaDon(iDHoaDon,iDMonAn,soLuong,iDBan)