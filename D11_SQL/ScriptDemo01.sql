USE eStore20;
GO

--Viết lệnh thêm 3 loại hàng hóa (Loai)
INSERT INTO Loai(TenLoai, MoTa, Hinh)
	VALUES(N'Bánh mì', N'Bánh mì - Bread', null)

INSERT INTO Loai(Hinh, TenLoai)
	VALUES(N'ball.jpg', N'Banh')

SELECT * FROM Loai
--Viết lệnh thêm 3 hàng hóa (HangHoa)
INSERT INTO HangHoa(TenHH, DonGia, MoTaDonVi, MaLoai, MaNCC)
	VALUES(N'Bàn máy tính', 1500000, N'Cái', 1001, 'AP')

------
SELECT CONCAT(MaHH, ' - ', TenHH, ' : ', DonGia) as ThongTin
FROM HangHoa

SELECT MaKH, HoTen, YEAR(NgaySinh) as NamSinh,
	YEAR(GETDATE()) - YEAR(NgaySinh) as Tuoi
FROM KhachHang
ORDER BY Tuoi DESC, HoTen

--GOM NHÓM
--Tìm tổng số hàng hóa, đơn giá trung bình
SELECT COUNT(MaHH) as SoLuong, AVG(DonGia) as GiaTB
FROM HangHoa

--Tìm tổng số hàng hóa, đơn giá trung bình theo loại
SELECT lo.MaLoai, TenLoai, ncc.TenCongTy,
	COUNT(MaHH) as SoLuong, AVG(DonGia) as GiaTB
FROM HangHoa hh JOIN Loai lo ON lo.MaLoai = hh.MaLoai
	JOIN NhaCungCap ncc ON ncc.MaNCC = hh.MaNCC
GROUP BY lo.MaLoai, TenLoai, ncc.TenCongTy
HAVING COUNT(MaHH)> 10

--Ambiguos column: cột xuất hiện ở nhiều bảng