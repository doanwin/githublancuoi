use qldiemdanhsv
go
create table QL_NguoiDung
(
	TenDangNhap char(20) not null primary key,
	MatKhau varchar(20),
	HoatDong nvarchar(50) 
)
create table QL_NhomNguoiDung
(
	MaNhom char(10) not null primary key,
	TenNhom nvarchar(20),
	GhiChu nvarchar(50)
)
create  table DM_ManHinh
(
	MaManhHinh varchar(5) not null primary key,
	TenManHinh nvarchar(50)
)
create table QL_NguoiDungNhomNguoiDung
(
	TenDangNhap char(20) not null,
	MaNhomNguoiDung char(10) not null,
	GhiChu nvarchar(50),
	Constraint FK_TenDangNhap foreign key (TenDangNhap) references QL_NguoiDung(TenDangNhap),
	Constraint FK_MaNhomNguoiDung foreign key (MaNhomNguoiDung) references QL_NhomNguoiDung(MaNhom)
)
create table QL_PhanQuyen
(
	MaNhomNguoiDung char(10) not null,
	MaManhHinh varchar(5) not null,
	CoQuyen int Default 0 --0 khong co quyen && 1: co quyen
)
alter table QL_PhanQuyen
add Constraint FK_MaNhom_PhanQuyen Foreign key (MaNhomNguoiDung) references QL_NhomNguoiDung(MaNhom)
alter table QL_PhanQuyen
add Constraint FK_MaManHinh_PhanQuyen Foreign key (MaManhHinh) references DM_ManHinh(MaManhHinh)


select nd.TenDangNhap,nd.MatKhau,ndnnd.MaNhomNguoiDung from QL_NguoiDungNhomNguoiDung ndnnd,QL_NguoiDung nd
where nd.TenDangNhap=ndnnd.TenDangNhap

select * from QL_NguoiDung
select * from QL_NguoiDungNhomNguoiDung
go
create Procedure deleteNguoidung @tendangnhap char(20)
as
begin
	declare @dem int;
	set @dem=(select COUNT(*) from QL_NguoiDung)
	if(@dem >1)
	begin
		delete from QL_NguoiDungNhomNguoiDung where TenDangNhap=@tendangnhap
		delete from QL_NguoiDung where TenDangNhap=@tendangnhap
	end
	else 
end




select pq.MaManhHinh,mh.TenManHinh,pq.CoQuyen from QL_PhanQuyen pq,DM_ManHinh mh where pq.MaManhHinh=mh.MaManhHinh and MaNhomNguoiDung='user'

alter table QL_PhanQuyen
add Constraint df_coquyen default 1 for CoQuyen
go
create FUNCTION AUTO_MaManHinh()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaManhHinh) FROM DM_ManHinh) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaManhHinh, 3)) FROM DM_ManHinh
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'MH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
ALTER TABLE DM_ManHinh
ALTER COLUMN MaManhHinh varchar(5) not null
ALTER TABLE DM_ManHinh
add  Constraint Pk_mamanhinh primary key (MaManhHinh)
alter table DM_ManHinh
add Constraint df_autoMa default dbo.AUTO_MaManHinh() for MaManhHinh

insert into DM_ManHinh(TenManHinh) values ('Dang nhap')
select * from QL_PhanQuyen
delete from QL_PhanQuyen 