Create database PMQuanLyNhaHang_N2_45K
Use PMQuanLyNhaHang_N2_45K
---1.LOAIHANGHOA 
Create table LOAIHANGHOA(MaLHH int not null primary key, TenLHH nvarchar(100) not null)
---2.HANGHOA 
Create table HANGHOA(MaHH int IDENTITY(1,1) not null primary key, TenHH nvarchar(100) not null , MaLHH int not null, DonGia float not null)
---3.BANAN 
Create table BANAN(MaBan int IDENTITY(1,1) not null primary key, TenBan nvarchar(100) not null, TrangThai nvarchar(100) not null)
---4.HOADON 
Create Table HOADON(MaHD int IDENTITY(1,1) not null primary key, NgayVao date not null, NgayRa date null, MaBan int not null, TrangThai int not null, GiamGia int null, TongTT float null)
---5.DANGNHAP => edit Loai Tk 
Create Table DANGNHAP(TenDN nvarchar(100) not null primary key, TenHienThi nvarchar(100) not null, MatKhau nvarchar(1000) not null,LoaiTK nvarchar(100) not null)
---6. THONGTINHOADON
CREATE TABLE THONGTINHOADON(MaTTHD int IDENTITY(1,1) not null PRIMARY KEY, MaHD Int NOT NULL, MaHH int NOT NULL,SoLuong int NOT NULL)
---Foreing Key 
---B1-2 
Alter table HANGHOA
Add Constraint FK_MaLHH foreign key (MaLHH) references LOAIHANGHOA(MaLHH)
---B3-4
Alter table HOADON
Add Constraint FK_MaBan foreign key (MaBan) references BANAN(MaBan)
---B4-6
Alter table THONGTINHOADON
Add Constraint FK_MaHD foreign key (MaHD) references HOADON(MaHD)
---B2-6
Alter table THONGTINHOADON
Add Constraint FK_MaHH foreign key (MaHH) references HANGHOA(MaHH)
---Insert B5
Insert into DANGNHAP
Values (N'boss', N'boss', N'1962026656160185351301320480154111117132155', 'Boss'),
(N'NHAN VIEN', N'staff', N'1962026656160185351301320480154111117132155', 'Nhân viên')
Select * from DANGNHAP


---Insert B3
GO
SET IDENTITY_INSERT [dbo].[BANAN] ON
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (1, N'Bàn 0', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (2, N'Bàn 1', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (3, N'Bàn 2', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (4, N'Bàn 3', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (5, N'Bàn 4', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (6, N'Bàn 5', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (7, N'Bàn 6', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (8, N'Bàn 7', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (9, N'Bàn 8', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (10, N'Bàn 9', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (11, N'Bàn 10', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (12, N'Bàn 11', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (13, N'Bàn 12', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (14, N'Bàn 13', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (15, N'Bàn 14', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (16, N'Bàn 15', N'Trống')
SET IDENTITY_INSERT [dbo].[BANAN] OFF
SET IDENTITY_INSERT [dbo].[BANAN] ON
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (17, N'Bàn 16', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (18, N'Bàn 17', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (19, N'Bàn 18', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (20, N'Bàn 19', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (21, N'Bàn 20', N'Trống')
SET IDENTITY_INSERT [dbo].[BANAN] OFF
SET IDENTITY_INSERT [dbo].[BANAN] ON
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (22, N'Bàn 21', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (23, N'Bàn 22', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (24, N'Bàn 23', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (25, N'Bàn 24', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (26, N'Bàn 25', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (27, N'Bàn 26', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (28, N'Bàn 27', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (29, N'Bàn 28', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (30, N'Bàn 29', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (31, N'Bàn 30', N'Trống')
SET IDENTITY_INSERT [dbo].[BANAN] OFF
SET IDENTITY_INSERT [dbo].[BANAN] ON
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (32, N'Bàn 31', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (33, N'Bàn 32', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (34, N'Bàn 33', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (35, N'Bàn 34', N'Trống')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (36, N'Bàn 35', N'Trống')
SET IDENTITY_INSERT [dbo].[BANAN] OFF
---Insert B1 
Insert Into LOAIHANGHOA 
Values
(1, N'PIZZA'),
(2, N'PASTA'),
(3, N'BURGERS'),
(4, N'SALADS'),
(5, N'BEER'),
(6, N'SOFT DRINK'),
(7, N'TEA'),
(8, N'JUICE')

Select * from LOAIHANGHOA
--- Insert B2
GO
SET IDENTITY_INSERT [dbo].[HANGHOA] ON
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (1,'Four Cheese', 1, 219000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (2,'Margherita', 1, 149000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (3,'Pepperoni', 1, 179000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (4,'BBQ Chicken ', 1, 199000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (5,'Seafood Lover', 1, 229000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (6,'Prosciutto & Rucola', 1, 249000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (7,'Big Shrimp', 1, 249000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (8,'America BBQ Beef', 1, 259000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (9,'Hawaiian', 1, 179000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (10,'Spaghetti Pomodoro', 2, 129000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (11,'Spaghetti With Meatball', 2, 149000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (12,'Carbonara', 2, 149000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (13,'Clams & White Wine', 2, 159000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (14,'Big Shrimp Spaghetti', 2, 189000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (15,'Seafood Black Pasta', 2, 189000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (17,'Double Cheese Burger', 3, 135000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (18,'Chicken Burger', 3, 185000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (19,'Fish Burger', 3, 125000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (20,'Mixed Green Salad', 4, 125000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (21,'Rocket Salad', 4, 125000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (22,'Fresh Buffalo', 4, 150000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (23,'Caesar Salad', 4, 195000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (24,'Sapporo', 5, 139000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (25,'Heineken', 5, 79000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (26,'Moslon Canadian', 5, 50000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (27,'Bull Light', 5, 89000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (28,'Coke', 6, 35000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (29,'Diet Coke', 6, 35000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (30,'Sprite', 6, 35000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (31,'Ginger Tea', 7, 55000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (32,'Peach Tea', 7, 55000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (33,'Lemon Grass', 7, 45000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (34,'Apple Juice', 8, 49000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (35,'Pineapple Juice', 8, 49000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (36,'Orange Juice', 8, 49000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (37,'Camberry Juice', 8, 49000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (38,'Straberry Juice', 8, 49000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaLHH], [DonGia]) VALUES (39,'Mango Juice', 8, 49000)
SET IDENTITY_INSERT [dbo].[HANGHOA] OFF
Select * from HANGHOA
---CHỨC NĂNG TÌM KIẾM 
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
---PROCEDURE USP_UpdateAccount	
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100) , @displayName NVARCHAR(100) , @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
--- Khai báo biến DECLARE
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.DANGNHAP WHERE TenDN = @userName AND MatKhau = @password
	
	IF (@isRightPass = 1)
	----mật khẩu mặc định =1 , nếu như mật khẩu đúng tiếp tục nhập mk mới, else thì không thực hiện 
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.DANGNHAP SET TenHienThi = @displayName WHERE TenDN = @userName
		END		
		ELSE
			UPDATE dbo.DANGNHAP SET TenHienThi = @displayName, MatKhau = @newPassword WHERE TenDN = @userName
	end
END
GO
--- PROCEDURE USP_Login -- fix lỗi đăng nhập password ( or 1=1--)
--- select * from DANGNHAP where TenDN = N'' or 1=1
GO
CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.DANGNHAP WHERE TenDN = @userName AND MatKhau = @passWord
END
GO
--- PROCEDURE USP_GetAccountByUserName
GO
CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.DANGNHAP WHERE TenDN = @userName
END
GO
--- PROCEDURE USP_GetTableList
---khi add nguyên gốc kh thể thay đổi thông tin nên kh thể edit
GO
CREATE PROC [dbo].[USP_GetTableList]
AS SELECT * FROM dbo.BANAN
GO
--- PROCEDURE USP_GetNumBillByDate
GO
CREATE PROC [dbo].[USP_GetNumBillByDate]
--- Lấy số lượng trang hóa đơn theo ngày 
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.HOADON AS b,dbo.BANAN AS t
	WHERE NgayVao >= @checkIn AND NgayRa<= @checkOut AND b.TrangThai = 1
	AND t.MaBan = b.MaBan
END
GO
--- PROCEDURE USP_GetListBillByDateForReport
GO
CREATE PROC [dbo].[USP_GetListBillByDateForReport]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.TenBan, b.TongTT, NgayVao, NgayRa, GiamGia
	FROM dbo.HOADON AS b,dbo.BANAN AS t
	WHERE NgayVao >= @checkIn AND NgayRa <= @checkOut AND b.TrangThai = 1
	AND t.MaBan = b.MaBan
END
GO
--- PROCEDURE USP_GetListBillByDateAndPage
--GO
--Alter PROC [dbo].[USP_GetListBillByDateAndPage]
--@checkIn date, @checkOut date, @page int
--AS 
--BEGIN
	--DECLARE @pageRows INT = 10
	--- mặc định 1 trang gồm 10 dòng
	--DECLARE @selectRows INT = @pageRows
	----- selectRows = số dòng chọn ra
	--DECLARE @exceptRows INT = (@page - 1) * @pageRows
	--with BillShow - lấy ra 1 bảng tạm 
	--;WITH BillShow AS( SELECT b.MaHD , t.TenBan AS [Tên bàn], b.TongTT AS [Tổng tiền], NgayVao AS [Ngày vào], NgayRa AS [Ngày ra], GiamGia AS [Giảm giá]
	--FROM dbo.HOADON AS b,dbo.BANAN AS t
	--WHERE NgayVao >= @checkIn AND NgayRa <= @checkOut AND b.TrangThai = 1
	--AND t.MaBan = b.MaBan)
	
	--SELECT TOP (@selectRows) * FROM BillShow WHERE MaHD NOT IN (SELECT TOP (@exceptRows) MaHD FROM BillShow)
	---select top - chọn ra số dòng cần xem mong muốn trong list: đầu - giữa - cuối
--END
--GO
----
--- PROCEDURE USP_GetListBillByDateAndPage
GO
CREATE PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.MaHD, t.TenBan AS [Tên bàn], b.TongTT AS [Tổng tiền], NgayVao AS [Ngày vào], NgayRa AS [Ngày ra], GiamGia AS [Giảm giá]
	FROM dbo.HOADON AS b,dbo.BANAN AS t
	WHERE NgayVao >= @checkIn AND NgayRa <= @checkOut AND b.TrangThai = 1
	AND t.MaBan = b.MaBan)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE MaHD NOT IN (SELECT TOP (@exceptRows) MaHD FROM BillShow)
END
GO
---EXEC dbo.USP_GetListBillByDateAndPage @checkIn = '2021-07-01', @checkOut = '2021-07-06', @page =1
---select * from HOADON
--- PROCEDURE USP_GetListBillByDate
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.TenBan AS [Tên bàn], b.TongTT AS [Tổng tiền], NgayVao AS [Ngày vào], NgayRa AS [Ngày ra], GiamGia AS [Giảm giá]
	FROM dbo.HOADON AS b,dbo.BANAN AS t
	WHERE NgayVao >= @checkIn AND NgayRa <= @checkOut AND b.TrangThai = 1
	AND t.MaBan= b.MaBan
END
GO
--- PROCEDURE USP_InsertBill
GO
CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.HOADON 
	        ( NgayVao ,
	          NgayRa ,
	          MaBan ,
	          TrangThai,
	          GiamGia
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,  -- status - int
	          0
	        )
END
GO
--- PROCEDURE USP_SwitchTabel
GO
CREATE PROC [dbo].[USP_SwitchTabel]
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = MaHD FROM dbo.HOADON WHERE MaBan = @idTable2 AND TrangThai = 0
	SELECT @idFirstBill = MaHD FROM dbo.HOADON WHERE MaBan = @idTable1 AND TrangThai = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.HOADON
		        ( NgayVao ,
		          NgayRa ,
		          MaBan ,
		          TrangThai
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(MaHD) FROM dbo.HOADON WHERE MaBan = @idTable1 AND TrangThai = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.THONGTINHOADON WHERE MaHD = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.HOADON
		        ( NgayVao ,
		          NgayRa ,
		          MaBan ,
		          TrangThai
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(MaHD) FROM dbo.HOADON WHERE MaBan = @idTable2 AND TrangThai = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.THONGTINHOADON WHERE MaHD = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT MaTTHD INTO MaTTHDTHONGTINHOADONTable FROM dbo.THONGTINHOADON WHERE MaHD = @idSeconrdBill
	
	UPDATE dbo.THONGTINHOADON SET MaHD = @idSeconrdBill WHERE MaHD = @idFirstBill
	
	UPDATE dbo.THONGTINHOADON SET MaHD = @idFirstBill WHERE MaTTHD IN (SELECT * FROM MaTTHDTHONGTINHOADONTable)
	
	DROP TABLE MaTTHDTHONGTINHOADONTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.BANAN SET TrangThai = N'Trống' WHERE MaBan = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.BANAN SET TrangThai = N'Trống' WHERE MaBan = @idTable1
END
GO
--- PROCEDURE USP_InsertBillInfo
GO
CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = MaTTHD, @foodCount = b.SoLuong 
	FROM dbo.THONGTINHOADON AS b 
	WHERE MaHD = @idBill AND MaHH = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.THONGTINHOADON	SET SoLuong = @foodCount + @count WHERE MaHH = @idFood
		ELSE
			DELETE dbo.THONGTINHOADON WHERE MaHD = @idBill AND MaHH = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.THONGTINHOADON
        ( MaHD, MaHH, SoLuong )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO
--- DELETE INFORMATION
DELETE dbo.THONGTINHOADON
DELETE dbo.HOADON
--- TRIGGER UTG_UpdateBillInfo
GO
CREATE TRIGGER UTG_UpdateBillInfo
--update BillInfo trước khi xóa món ăn 
ON dbo.THONGTINHOADON FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = MaHD FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = MaBan FROM dbo.HOADON WHERE MaHD= @idBill AND TrangThai = 0

	DECLARE @count INT
	Select @count = COUNT(*) from dbo.THONGTINHOADON where MaHD = @idBill
	if (@count >0)
	BEGIN
		print @idTable
		print @idBill
		print @count
	
	UPDATE dbo.BANAN SET TrangThai = N'Có người' WHERE MaBan = @idTable
	END
END
GO
--- TRIGGER UTG_UpdateBill
GO
CREATE TRIGGER UTG_UpdateBill
ON dbo.HOADON FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = MaHD FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = MaBan FROM dbo.HOADON WHERE MaHD = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.HOADON WHERE MaBan = @idTable AND TrangThai = 0
	
	IF (@count = 0)
		UPDATE dbo.BANAN SET TrangThai = N'Trống' WHERE MaBan = @idTable
END
GO
---
ALTER TABLE [dbo].[DANGNHAP] ADD  DEFAULT (N'Manager') FOR [TenHienThi]
GO
---
ALTER TABLE [dbo].[DANGNHAP] ADD  DEFAULT ((0)) FOR [MatKhau]
GO
---
ALTER TABLE [dbo].[DANGNHAP] ADD  DEFAULT ((0)) FOR [LoaiTK]
GO
---
ALTER TABLE [dbo].[BANAN] ADD  DEFAULT (N'Bàn chưa có tên') FOR [TenBan]
GO
---
ALTER TABLE [dbo].[BANAN] ADD  DEFAULT (N'Trống') FOR [TrangThai]
GO
---
ALTER TABLE [dbo].[LOAIHANGHOA] ADD  DEFAULT (N'Chưa đặt tên') FOR [TenLHH]
GO
---
ALTER TABLE [dbo].[HANGHOA] ADD  DEFAULT (N'Chưa đặt tên') FOR [TenHH]
GO
---
ALTER TABLE [dbo].[HANGHOA] ADD  DEFAULT ((0)) FOR [DonGia]
GO
---
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [NgayVao]
GO
---
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
---
ALTER TABLE [dbo].[THONGTINHOADON] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
---
SELECT * from DANGNHAP