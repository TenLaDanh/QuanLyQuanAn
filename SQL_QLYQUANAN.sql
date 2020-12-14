CREATE DATABASE QL_QUANAN
GO
USE QL_QUANAN
GO

create table NhanVien
(
	iD int identity primary key,
	hoTen nvarchar(50),
	gioiTinh nvarchar(15),
	diaChi nvarchar(100),
	SDT nvarchar(10)
)
Go
CREATE TABLE TaiKhoan
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	taiKhoan nvarchar(50), 
	matKhau nvarchar(30),
	tenHienThi nvarchar(50),
	loaiTK int,--0: nhân viển 1: admin
	maNV int
	foreign key(maNV) references NhanVien(iD)
)
GO
CREATE TABLE BaoCao
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	iDTaiKhoan int,
	noiDung text,
	foreign key(iDTaiKhoan) references TaiKhoan(iD)
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
	iD int IDENTITY(1,1) PRIMARY KEY,
	donGia int,
	tenMon nvarchar(50)
)
create table InforMonAn
(
	iD int identity primary key,
	idMonAn int,
	idNguyenLieu int,
	soLuong float -- So luong nguyen lieu
	foreign key(idMonAn) references MonAn(iD),
	foreign key(idNguyenLieu) references NguyenLieu(iD)
)
GO	
CREATE TABLE BanAn
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	trangThai int default 0 check(trangThai = 0 OR trangThai = 1)
)

CREATE TABLE HoaDon
(
	iD int IDENTITY(1,1) PRIMARY KEY,
	ngayXuatHD date,
	trangthai int
)
GO	

CREATE TABLE InfoHoaDon
(
	iD int identity primary key,
	iDHoaDon int,
	iDMonAn int,
	iDBan int,
	soLuong int
	foreign key(iDHoaDon) references HoaDon(iD),
	foreign key(iDMonAn) references MonAn(iD),
	foreign key(iDBan) references BanAn(iD)
)
GO	

insert into NhanVien(hoTen,gioiTinh,diaChi,SDT)
values  (N'Lê Nguyễn Đức Danh',N'Nam',N'2B Linh Trung','0976184283'),
		(N'Nguyễn Hoài Thương',N'Nữ',N'Nha Trang','0357471614')
Go
INSERT INTO TaiKhoan (taiKhoan,matKhau,tenHienThi,loaiTK,maNV)
VALUES ('tenladanh','14122001','TenLaDanh',1,1),
		('hoaithuong','30112001',N'Nguyễn Hoài Thương',0,2)
GO
insert into BaoCao(iDTaiKhoan,noiDung)
values (1,N'hihi'),(2,N'hihi')
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
INSERT INTO NguyenLieu(tenNguyenLieu, soLuong, donVi) VALUES  (N'Gà', 20, 'kg')
															, (N'Cá diêu hồng', 20, 'kg')
															, (N'Cà chua', 7, 'kg')
															, (N'Thịt', 20, 'kg')
															, (N'Trứng vịt', 100, N'quả')
															, (N'Tôm', 10, 'kg')
															, (N'Thịt bò', 10, 'kg')
															, (N'Bia tiger', 120, 'lon')
															, (N'Bia sài gòn đỏ', 120, 'lon')
															, (N'Coca Cola', 120, 'lon')
															, (N'Nước suối', 120, 'chai')
go
insert into InforMonAn(idMonAn,idNguyenLieu,soLuong)
values (1,1,0.5),(2,4,0.5),(2,5,4),(3,2,0.8),(3,3,0.3),(4,6,0.5),(5,6,0.5),(6,7,0.5),(7,8,1),(8,9,1),(9,10,1),(10,11,1)
go
set dateformat dmy															
INSERT INTO HoaDon(ngayXuatHD,trangThai) VALUES ('14/12/2020',1),
												('14/12/2020',1),
												('14/12/2020',1),
												('14/12/2020',1)
go
INSERT INTO BanAn(trangThai) VALUES (1),(1),(1),(1),(1),(01),(01),(1),(01),(01),(1),(1),(1),(1),(1),(1),(1),(1)
go	
INSERT INTO InfoHoaDon(iDHoaDon,iDMonAn,iDBan,soLuong) VALUES   (1,1,1,2),
																(1,2,1,1),
																(2,3,1,1),
																(3,3,3,1),
																(4,3,5,2)
go									   

-------------------------------------------------------------------------------------------
---------------------------------------Nhan Vien------------------------------------------- 
-------------------------------------------------------------------------------------------
-- Lấy danh sách nhân viên
create proc sp_DSNhanVien
as
	begin 
		select * from NhanVien
	end;
go

-- Lấy nhân viên theo id nhân viên
create proc sp_GetByIDNhanvien--Lấy nhân viên theo ID
@iD int
as
	 begin
		select * from NhanVien where iD = @iD
	end;
go

--Thêm nhân viên
create proc sp_ThemNhanVien
@hoTen nvarchar(50),@gioiTinh nvarchar(15),@diaChi nvarchar(100),@SDT nvarchar(10)
as
	begin 
		insert into NhanVien(hoTen,gioiTinh,diaChi,SDT)
		values (@hoTen,@gioiTinh,@diaChi,@SDT)
	end;
go

--Sửa thông tin nhân viên có id là iD 
create proc sp_SuaNhanVien
@iD int,@hoTen nvarchar(50),@gioiTinh nvarchar(15),@diaChi nvarchar(100),@SDT nvarchar(10)
as
	begin 
		update NhanVien
		set hoTen = @hoTen,gioiTinh= @gioiTinh,diaChi= @diaChi,SDT = @SDT
		where iD = @iD
	end;
go

--Xóa thông tin nhân viên có id là iD 
create proc sp_XoaNhanVien
@iD int
as
	begin 
		delete 
		from NhanVien
		where iD =@iD
	end;
go
-------------------------------------------------------------------------------------------
---------------------------------------Mon An---------------------------------------------- 
-------------------------------------------------------------------------------------------
create proc sp_DSMonAn
as
	begin 
		select * from MonAn
	end;
go
create proc sp_GetByIDMonAn --Lấy món ăn theo ID
@iD int
as
	 begin
		select * from MonAn where iD = @iD
	end;
go
create proc sp_ThemMonAn
@tenMon nvarchar(50),@donGia int
as
	begin 
		insert into MonAn(tenMon,donGia)
		values (@tenMon,@donGia)
	end;
go
create proc sp_SuaMonAn
@iD int,@tenMon nvarchar(50),@donGia int
as
	begin 
		update MonAn
		set tenMon = @tenMon,donGia= @donGia
		where iD = @iD
	end;
go
create proc sp_XoaMonAn
@iD int
as
	begin 
		delete 
		from MonAn
		where iD =@iD
	end;
go
-------------------------------------------------------------------------------------------
---------------------------------------Nguyen Lieu-----------------------------------------
-------------------------------------------------------------------------------------------
create proc sp_DSNguyenLieu
as
	begin 
		select * from NguyenLieu
	end;
go
create proc sp_GetByIDNL --Lấy nguyên liệu theo ID
@iD int
as
	 begin
		select * from NguyenLieu where iD = @iD
	end;
go
create proc sp_ThemNguyenLieu
@tenNguyenLieu nvarchar(50),@soLuong float,@donVi nvarchar(15)
as
	begin 
		insert into NguyenLieu(tenNguyenLieu,soLuong,donVi)
		values (@tenNguyenLieu,@soLuong,@donVi)
	end;
go
create proc sp_SuaNguyenLieu
@iD int,@tenNguyenLieu nvarchar(50),@soLuong float,@donVi nvarchar(15)
as
	begin 
		update NguyenLieu
		set tenNguyenLieu = @tenNguyenLieu,@soLuong= @soLuong,donVi = @donVi
		where iD = @iD
	end;
go
create proc sp_XoaNguyenLieu
@iD int
as
	begin 
		delete 
		from NguyenLieu
		where iD =@iD
	end;
go
-------------------------------------------------------------------------------------------
---------------------------------------InfoMonAn-------------------------------------------
-------------------------------------------------------------------------------------------

create proc sp_GetIFByIDMonAn --Lấy InforMonAn theo ID mon an	n
@iD int
as
	 begin
		select * from InforMonAn where idMonAn = @iD
	end;
go
create proc sp_ThemInforMonAn
@idMonAn int,@idNguyenLieu int,@soLuong int
as
	begin 
		insert into InforMonAn(idMonAn,idNguyenLieu,soLuong)
		values (@idMonAn,@idNguyenLieu,@soLuong)
	end;
go
create proc sp_SuaInforMonAn
@iD int,@idMonAn int,@idNguyenLieu int,@soLuong int
as
	begin 
		update InforMonAn
		set idMonAn = @idMonAn,@idNguyenLieu= @idNguyenLieu,@soLuong = @soLuong
		where iD = @iD
	end;
go
create proc sp_XoaInforMonAn	
@iD int
as
	begin 
		delete 
		from InforMonAn
		where iD =@iD
	end;
go

-------------------------------------------------------------------------------------------
---------------------------------------InfoHoaDon-------------------------------------------
-------------------------------------------------------------------------------------------

create proc sp_GetIFByIDHoaDon --Lấy InfoHoaDon theo ID hoa don
@iD int
as
	 begin
		select * from InfoHoaDon where iDHoaDon = @iD
	end;
go
create proc sp_ThemInforHoaDon
@idHoaDon int,@idMonAn int,@idBan int,@soLuong int
as
	begin 
		insert into InfoHoaDon(iDHoaDon,iDMonAn,iDBan,soLuong)
		values (@idHoaDon,@idMonAn,@idBan,@soLuong)
	end;
go
create proc sp_SuaInforHoaDon
@iD int,@idHoaDon int,@idMonAn int,@idBan int,@soLuong int
as
	begin 
		update InfoHoaDon
		set idMonAn = @idMonAn,iDHoaDon= @idHoaDon,soLuong = @soLuong,iDBan = @idBan
		where iD = @iD
	end;
go
create proc sp_XoaInforHoaDon	
@iD int
as
	begin 
		delete 
		from InfoHoaDon
		where iD =@iD
	end;
go
-------------------------------------------------------------------------------------------
---------------------------------------Hoa Don-------------------------------------------
-------------------------------------------------------------------------------------------
create proc sp_DSHoaDon
as
	begin	
		select * from HoaDon
	end;
go
create proc sp_GetByIDHoaDon --Lấy danh sách hóa đơn theo id
@iD int
as
	 begin
		select * from HoaDon where iD = @iD
	end;
go
create proc sp_ThemHoaDon
@ngayXuatHD date,@trangThai int
as
	begin 
		insert into HoaDon(ngayXuatHD,trangthai)
		values (@ngayXuatHD,@trangThai)
	end;
go
create proc sp_SuaHoaDon
@iD int,@ngayXuatHD date,@trangThai int
as
	begin 
		update HoaDon
		set ngayXuatHD = @ngayXuatHD,trangthai= @trangThai
		where iD = @iD
	end;
go
create proc sp_XoaHoaDon	
@iD int
as
	begin 
		delete 
		from HoaDon
		where iD =@iD
	end;
go

-------------------------------------------------------------------------------------------
---------------------------------------Ban An-------------------------------------------
-------------------------------------------------------------------------------------------
create proc sp_DSBanAn
as
	begin	
		select * from BanAn
	end;
go

create proc sp_ThemBanAn
@trangThai int
as
	begin 
		insert into BanAn(trangThai)
		values (@trangThai)
	end;
go
create proc sp_SuaBanAn
@iD int,@trangThai int
as
	begin 
		update BanAn
		set trangThai = @trangThai
		where iD = @iD
	end;
go
create proc sp_XoaBanAn
@iD int
as
	begin 
		delete 
		from BanAn
		where iD =@iD
	end;
go								
