Imports System.Data.SqlClient
Imports System.Data
Public Class Help
    Dim DataTable As New DataSet
    Public Function DuLieuKhachHang() As DataSet
        Dim LoadKH As New SqlDataAdapter("SELECT MaKH AS 'Customer Code' ,TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG", Connect)
        Dim DataTable As New DataSet
        Connect.Open()
        LoadKH.Fill(DataTable)
        Connect.Close()
        Return DataTable
    End Function
    Public Function DuLieuSanPham() As DataSet
        Dim LoadSP As New SqlDataAdapter("SELECT MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Types of Products', DonGia AS 'Unit Price', SoLuong AS 'Number' FROM SANPHAM", Connect)
        Dim DataTable As New DataSet
        Connect.Open()
        LoadSP.Fill(DataTable)
        Connect.Close()
        Return DataTable
    End Function
    Public Function DuLieuNhanVien() As DataSet
        Dim LoadNV As New SqlDataAdapter("SELECT MaNV AS 'Staff Code' ,TenNV AS 'Staff Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NHANVIEN", Connect)
        Dim DataTable As New DataSet
        Connect.Open()
        LoadNV.Fill(DataTable)
        Connect.Close()
        Return DataTable
    End Function
    Public Function DuLieuHoaDon() As DataSet
        Dim LoadHD As New SqlDataAdapter("SELECT HOADON.MaHD AS 'Bill Code',KHACHHANG.MaKH AS 'Customer Code', KHACHHANG.TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number',NgayBan AS 'Date', HOADON.MaNV AS 'Staff Code', SANPHAM.MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Product Type', SoLuong AS 'Number', DonGia AS 'Unit Price', ThanhTien AS 'Money Total' FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.MaKH = HOADON.MaKH INNER JOIN CTHOADON ON HOADON.MaHD = CTHOADON.MaHD INNER JOIN SANPHAM ON SANPHAM.MaSP = CTHOADON.MaSP", Connect)
        Dim DataTable As New DataSet
        Connect.Open()
        LoadHD.Fill(DataTable)
        Connect.Close()
        Return DataTable
    End Function
    Public Function DuLieuNguoiQuanTri() As DataSet
        Dim LoadNQT As New SqlDataAdapter("SELECT MaQT AS 'Administrator Code' ,TenNQT AS 'Administrator Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NGUOIQUANTRI", Connect)
        Dim DataTable As New DataSet
        Connect.Open()
        LoadNQT.Fill(DataTable)
        Connect.Close()
        Return DataTable
    End Function
End Class
