Imports System.Data.SqlClient
Imports System.Data
Public Class frmStaff
    Dim DataTable As New DataTable
    Dim Shows As New Help

    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT MaNV AS 'Staff Code' ,TenNV AS 'Staff Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NHANVIEN WHERE TenNV LIKE N'%" & txtStaffName.Text & "%'", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtStaffName.Focus()
            If txtStaffName.Text = "" Then
                MessageBox.Show("You didn't enter Staff Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DataTable.Clear()
                dgvShowStaff.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvShowStaff.DataSource = DataTable.DefaultView
                    txtStaffName.Text = Nothing
                Else
                    MessageBox.Show("Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtStaffName.Text = Nothing
                End If
            End If
            Connect.Close() 'Dong ket noi CSDL
        Catch EX As Exception
        End Try
    End Sub

    Private Sub dgvShowStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowStaff.CellContentClick
        Try
            Dim Dobble As Integer = dgvShowStaff.CurrentCell.RowIndex
            txtStaffCode.Text = dgvShowStaff.Item(0, Dobble).Value
            txtStaffName.Text = dgvShowStaff.Item(1, Dobble).Value
            txtAddress.Text = dgvShowStaff.Item(2, Dobble).Value
            txtPhoneNumber.Text = dgvShowStaff.Item(3, Dobble).Value
            txtEmail.Text = dgvShowStaff.Item(4, Dobble).Value
            txtUserNAME.Text = dgvShowStaff.Item(5, Dobble).Value
            txtPassWORD.Text = dgvShowStaff.Item(6, Dobble).Value
        Catch EX As Exception
        End Try
    End Sub
    
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        Dim InsertString As String = "INSERT INTO NHANVIEN VALUES(@MaNV,@TenNV,@DiaChi,@SoDienThoai, @ThuDienTu, @NguoiDung, @MatKhau)"
        Dim Save As SqlCommand = New SqlCommand(InsertString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtStaffCode.Focus()
            If txtStaffCode.Text = "" Or txtStaffName.Text = "" Or txtAddress.Text = "" Or txtEmail.Text = "" Or txtPhoneNumber.Text = "" Or txtUserNAME.Text = "" Or txtPassWORD.Text = "" Then
                MessageBox.Show("You didn't enter Staff Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtStaffCode.Focus()
                If txtStaffCode.Text = "" Then
                    MessageBox.Show("You didn't enter Staff Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtStaffName.Focus()
                    If txtStaffName.Text = "" Then
                        MessageBox.Show("You didn't enter Staff Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAddress.Focus()
                        If txtAddress.Text = "" Then
                            MessageBox.Show("You didn't enter Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtPhoneNumber.Focus()
                            If txtPhoneNumber.Text = "" Then
                                MessageBox.Show("You didn't enter Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtEmail.Focus()
                                If txtEmail.Text = "" Then
                                    MessageBox.Show("You didn't enter Email!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    txtUserNAME.Focus()
                                    If txtUserNAME.Text = "" Then
                                        MessageBox.Show("You didn't enter Username!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        txtPassWORD.Focus()
                                        If txtPassWORD.Text = "" Then
                                            MessageBox.Show("You didn't enter Password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        Else
                                            'Thuc thi cau lenh
                                            Save.Parameters.AddWithValue("@MaNV", txtStaffCode.Text)
                                            Save.Parameters.AddWithValue("@TenNV", txtStaffName.Text)
                                            Save.Parameters.AddWithValue("@DiaChi", txtAddress.Text)
                                            Save.Parameters.AddWithValue("@SoDienThoai", txtPhoneNumber.Text)
                                            Save.Parameters.AddWithValue("@ThuDienTu", txtEmail.Text)
                                            Save.Parameters.AddWithValue("@NguoiDung", txtUserNAME.Text)
                                            Save.Parameters.AddWithValue("@MatKhau", txtPassWORD.Text)
                                            Save.ExecuteNonQuery()
                                            Connect.Close() 'Dong ket noi CSDL
                                            MessageBox.Show("Saved Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtStaffCode.Text = Nothing
                                            txtStaffName.Text = Nothing
                                            txtAddress.Text = Nothing
                                            txtPhoneNumber.Text = Nothing
                                            txtEmail.Text = Nothing
                                            txtUserNAME.Text = Nothing
                                            txtPassWORD.Text = Nothing
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch EX As Exception
            'Bao loi trung Ma Nhan Vien
            MessageBox.Show("Staff code already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi
        Dim RefreshString As SqlDataAdapter = New SqlDataAdapter("SELECT MaNV AS 'Staff Code' ,TenNV AS 'Staff Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NHANVIEN", Connect)
        DataTable.Clear()
        RefreshString.Fill(DataTable)
        dgvShowStaff.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        Dim DeleteString As String = ("DELETE NHANVIEN WHERE MaNV = @MaNV")
        Dim S As SqlCommand = New SqlCommand(DeleteString, Connect)
        Dim ResultString As DialogResult = MessageBox.Show("Do you want to delete data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtStaffCode.Focus()
            If txtStaffCode.Text = "" Then
                MessageBox.Show("You didn't enter Customer Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If ResultString = Windows.Forms.DialogResult.Yes Then
                    S.Parameters.AddWithValue("@MaNV", txtStaffCode.Text)
                    S.ExecuteNonQuery()
                    Connect.Close()
                    MessageBox.Show("Deleted Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtStaffCode.Text = Nothing
                    txtStaffName.Text = Nothing
                    txtAddress.Text = Nothing
                    txtPhoneNumber.Text = Nothing
                    txtEmail.Text = Nothing
                    txtUserNAME.Text = Nothing
                    txtPassWORD.Text = Nothing
                End If
            End If
        Catch EX As Exception
            'Thong bao loi khi xoa that bai
            MessageBox.Show("Delete Fails", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        DataTable.Clear()
        dgvShowStaff.DataSource = DataTable
        dgvShowStaff.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Load du lieu lai
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaNV AS 'Staff Code' ,TenNV AS 'Staff Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NHANVIEN", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Load du lieu len DataGribView
        dgvShowStaff.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi cap nhat du lieu
        Dim UpdataString As String = "UPDATE NHANVIEN SET MaNV=@MaNV, TenNV=@TenNV, DiaChi=@DiaChi, SDT=@SoDienThoai, ThuDienTu =@Email, NguoiDung=@NguoiDung, MatKhau=@MatKhau WHERE MaNV=@MaNV"
        'Luu du lieu vao bien
        Dim Add As SqlCommand = New SqlCommand(UpdataString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtStaffCode.Focus()
            If txtStaffCode.Text = "" Or txtStaffName.Text = "" Or txtAddress.Text = "" Or txtEmail.Text = "" Or txtPhoneNumber.Text = "" Or txtUserNAME.Text = "" Or txtPassWORD.Text = "" Then
                MessageBox.Show("You didn't enter Staff Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If txtStaffCode.Text = "" Then
                    MessageBox.Show("You didn't enter Staff Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtStaffName.Focus()
                    If txtStaffName.Text = "" Then
                        MessageBox.Show("You didn't enter Staff Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAddress.Focus()
                        If txtAddress.Text = "" Then
                            MessageBox.Show("You didn't enter Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtPhoneNumber.Focus()
                            If txtPhoneNumber.Text = "" Then
                                MessageBox.Show("You didn't enter Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtEmail.Focus()
                                If txtEmail.Text = "" Then
                                    MessageBox.Show("You didn't enter Email!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    txtUserNAME.Focus()
                                    If txtUserNAME.Text = "" Then
                                        MessageBox.Show("You didn't enter Username!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        txtPassWORD.Focus()
                                        If txtPassWORD.Text = "" Then
                                            MessageBox.Show("You didn't enter Password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Else
                                            'Chen du lieu
                                            Add.Parameters.AddWithValue("@MaNV", txtStaffCode.Text)
                                            Add.Parameters.AddWithValue("@TenNV", txtStaffName.Text)
                                            Add.Parameters.AddWithValue("@DiaChi", txtAddress.Text)
                                            Add.Parameters.AddWithValue("@SoDienThoai", txtPhoneNumber.Text)
                                            Add.Parameters.AddWithValue("@Email", txtEmail.Text)
                                            Add.Parameters.AddWithValue("@NguoiDung", txtUserNAME.Text)
                                            Add.Parameters.AddWithValue("@MatKhau", txtPassWORD.Text)
                                            Add.ExecuteNonQuery()
                                            Connect.Close() 'Dong ket noi CSDL
                                            MessageBox.Show("Updated Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtStaffCode.Text = Nothing
                                            txtStaffName.Text = Nothing
                                            txtAddress.Text = Nothing
                                            txtPhoneNumber.Text = Nothing
                                            txtEmail.Text = Nothing
                                            txtUserNAME.Text = Nothing
                                            txtPassWORD.Text = Nothing
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            'Thong bao loi cap nhat khong thanh cong
            MessageBox.Show("Update Fails", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        DataTable.Clear()
        dgvShowStaff.DataSource = DataTable
        dgvShowStaff.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtStaffCode.Clear()
        txtStaffName.Clear()
        txtAddress.Clear()
        txtPhoneNumber.Clear()
        txtEmail.Clear()
        txtUserNAME.Clear()
        txtPassWORD.Clear()
        txtStaffCode.Text = Nothing
        txtStaffName.Text = Nothing
        txtAddress.Text = Nothing
        txtPhoneNumber.Text = Nothing
        txtEmail.Text = Nothing
        txtUserNAME.Text = Nothing
        txtPassWORD.Text = Nothing
    End Sub

    Private Sub btnAllView_Click_1(sender As Object, e As EventArgs) Handles btnAllView.Click
        'Hien thi du lieu len DataGridView
        dgvShowStaff.DataSource = Shows.DuLieuNhanVien.Tables(0)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'Dong bang Staff
    End Sub
    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Load du lieu lai
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaNV AS 'Staff Code' ,TenNV AS 'Staff Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NHANVIEN", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Load du lieu len DataGribView
        dgvShowStaff.DataSource = DataTable.DefaultView
    End Sub
End Class