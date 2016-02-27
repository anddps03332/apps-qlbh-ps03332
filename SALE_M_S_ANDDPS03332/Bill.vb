Imports System.Data.SqlClient
Imports System.Data

Public Class frmBill
    Dim DataTable As New DataTable
    Dim Shows As New Help
    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT HOADON.MaHD AS 'Bill Code',KHACHHANG.MaKH AS 'Customer Code', KHACHHANG.TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number',NgayBan AS 'Date', HOADON.MaNV AS 'Staff Code', SANPHAM.MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Product Type', SoLuong AS 'Number', DonGia AS 'Unit Price', ThanhTien AS 'Money Total' FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.MaKH = HOADON.MaKH INNER JOIN CTHOADON ON HOADON.MaHD = CTHOADON.MaHD INNER JOIN SANPHAM ON SANPHAM.MaSP = CTHOADON.MaSP WHERE  KHACHHANG.TenKH LIKE N'%" & txtCustomerName.Text & "%' ", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtCustomerName.Focus()
            If txtCustomerName.Text = "" Then
                MessageBox.Show("You didn't enter Customer name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DataTable.Clear()
                dgvShowBill.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvShowBill.DataSource = DataTable.DefaultView
                    txtCustomerName.Text = Nothing
                Else
                    MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCustomerName.Text = Nothing
                End If
            End If
            Connect.Close() 'Dong ket noi CSDL
        Catch EX As Exception
        End Try
    End Sub

    Private Sub dgvShowBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowBill.CellContentClick
        Try
            Dim Dobble As Integer = dgvShowBill.CurrentCell.RowIndex
            txtBillCode.Text = dgvShowBill.Item(0, Dobble).Value
            txtCustomerCode.Text = dgvShowBill.Item(1, Dobble).Value
            txtCustomerName.Text = dgvShowBill.Item(2, Dobble).Value
            txtAddress.Text = dgvShowBill.Item(3, Dobble).Value
            txtPhoneNumber.Text = dgvShowBill.Item(4, Dobble).Value
            txtDate.Text = dgvShowBill.Item(5, Dobble).Value
            txtStaffCode.Text = dgvShowBill.Item(6, Dobble).Value
            txtProCode.Text = dgvShowBill.Item(7, Dobble).Value
            txtProduct.Text = dgvShowBill.Item(8, Dobble).Value
            txtType.Text = dgvShowBill.Item(9, Dobble).Value
            txtNumber.Text = dgvShowBill.Item(10, Dobble).Value
            txtUnitPrice.Text = dgvShowBill.Item(11, Dobble).Value
            txtMoneyTotal.Text = dgvShowBill.Item(12, Dobble).Value

        Catch EX As Exception
        End Try
    End Sub

    Private Sub btnRefesh_Click(sender As Object, e As EventArgs) Handles btnRefesh.Click
        txtBillCode.Clear()
        txtCustomerCode.Clear()
        txtCustomerName.Clear()
        txtProduct.Clear()
        txtType.Clear()
        txtAddress.Clear()
        txtUnitPrice.Clear()
        txtMoneyTotal.Clear()
        txtNumber.Clear()
        txtPhoneNumber.Clear()
        txtDate.Clear()
        txtProCode.Clear()
        txtStaffCode.Clear()

        'Làm mới
        txtBillCode.Text = Nothing
        txtCustomerCode.Text = Nothing
        txtCustomerName.Text = Nothing
        txtProduct.Text = Nothing
        txtType.Text = Nothing
        txtAddress.Text = Nothing
        txtUnitPrice.Text = Nothing
        txtMoneyTotal.Text = Nothing
        txtNumber.Text = Nothing
        txtPhoneNumber.Text = Nothing
        txtDate.Text = Nothing
        txtProCode.Text = Nothing
        txtStaffCode.Text = Nothing
    End Sub

    Private Sub btnAllView_Click(sender As Object, e As EventArgs) Handles btnAllView.Click
        dgvShowBill.DataSource = Shows.DuLieuHoaDon.Tables(0)
    End Sub
    Private Sub LoadData()
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lam moi du lieu trong CSDL
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT HOADON.MaHD AS 'Bill Code',KHACHHANG.MaKH AS 'Customer Code', KHACHHANG.TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number',NgayBan AS 'Date', HOADON.MaNV AS 'Staff Code', SANPHAM.MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Product Type', SoLuong AS 'Number', DonGia AS 'Unit Price', ThanhTien AS 'Money Total' FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.MaKH = HOADON.MaKH INNER JOIN CTHOADON ON HOADON.MaHD = CTHOADON.MaHD INNER JOIN SANPHAM ON SANPHAM.MaSP = CTHOADON.MaSP", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Load du lieu len DataGridView
        dgvShowBill.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MessageBox.Show("Sorry! The function not complete Please reuse again later. Thanks!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MessageBox.Show("Sorry! The function not complete Please reuse again later. Thanks!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MessageBox.Show("Sorry! The function not complete Please reuse again later. Thanks!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class