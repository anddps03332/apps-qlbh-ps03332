Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmAdministrator
    Dim DataTable As New DataTable
    Dim Shows As New Help 'Bien dai dien cho Help
    Private Sub btnSeachAd_Click(sender As Object, e As EventArgs) Handles btnSeachAd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van lay du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT MaQT AS 'Administrator Code' ,TenNQT AS 'Administrator Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NGUOIQUANTRI WHERE TenNQT LIKE N'%" & txtAdName.Text & "%'", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtAdName.Focus()
            If txtAdName.Text = "" Then
                MessageBox.Show("You didn't enter Administrator Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DataTable.Clear()
                dgvShowAd.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvShowAd.DataSource = DataTable.DefaultView
                    txtAdName.Text = Nothing
                Else
                    MessageBox.Show("Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAdName.Text = Nothing
                End If
            End If
            Connect.Close() 'Dong ket noi CSDL
        Catch EX As Exception
        End Try
    End Sub

    Private Sub dgvShowAd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowAd.CellContentClick
        Try
            Dim Dobble As Integer = dgvShowAd.CurrentCell.RowIndex
            txtAdCode.Text = dgvShowAd.Item(0, Dobble).Value
            txtAdName.Text = dgvShowAd.Item(1, Dobble).Value
            txtAdAddress.Text = dgvShowAd.Item(2, Dobble).Value
            txtAdPhoneNumber.Text = dgvShowAd.Item(3, Dobble).Value
            txtAdMail.Text = dgvShowAd.Item(4, Dobble).Value
            txtUsernameAd.Text = dgvShowAd.Item(5, Dobble).Value
            txtPasswordAd.Text = dgvShowAd.Item(6, Dobble).Value
        Catch EX As Exception
        End Try
    End Sub

    Private Sub btnAddAd_Click(sender As Object, e As EventArgs) Handles btnAddAd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi chen du lieu vao bien
        Dim InsertString As String = "INSERT INTO NGUOIQUANTRI VALUES(@MaQT,@TenNQT,@DiaChi,@SDT, @ThuDienTu, @NguoiDung, @MatKhau)"
        'Luu du lieu vao bien
        Dim Save As SqlCommand = New SqlCommand(InsertString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtAdCode.Focus()
            If txtAdCode.Text = "" Then
                MessageBox.Show("You didn't enter Administrator Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtAdName.Focus()
                If txtAdName.Text = "" Then
                    MessageBox.Show("You didn't enter Administrator Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtAdAddress.Focus()
                    If txtAdAddress.Text = "" Then
                        MessageBox.Show("You didn't enter Address", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAdPhoneNumber.Focus()
                        If txtAdPhoneNumber.Text = "" Then
                            MessageBox.Show("You didn't enter Phone Number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtAdMail.Focus()
                            If txtAdMail.Text = "" Then
                                MessageBox.Show("You didn't enter Email", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtUsernameAd.Focus()
                                If txtUsernameAd.Text = "" Then
                                    MessageBox.Show("You didn't enter Username", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    txtPasswordAd.Focus()
                                    If txtPasswordAd.Text = "" Then
                                        MessageBox.Show("You didn't enter Password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    Else
                                        'Thuc thi cau lenh
                                        Save.Parameters.AddWithValue("@MaQT", txtAdCode.Text)
                                        Save.Parameters.AddWithValue("@TenNQT", txtAdName.Text)
                                        Save.Parameters.AddWithValue("@DiaChi", txtAdAddress.Text)
                                        Save.Parameters.AddWithValue("@SDT", txtAdPhoneNumber.Text)
                                        Save.Parameters.AddWithValue("@ThuDienTu", txtAdMail.Text)
                                        Save.Parameters.AddWithValue("@NguoiDung", txtUsernameAd.Text)
                                        Save.Parameters.AddWithValue("@MatKhau", txtPasswordAd.Text)
                                        Save.ExecuteNonQuery()
                                        Connect.Close() 'Dong ket noi CSDL
                                        MessageBox.Show("Saved Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtAdCode.Text = Nothing
                                        txtAdName.Text = Nothing
                                        txtAdAddress.Text = Nothing
                                        txtAdPhoneNumber.Text = Nothing
                                        txtAdMail.Text = Nothing
                                        txtUsernameAd.Text = Nothing
                                        txtPasswordAd.Text = Nothing
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch EX As Exception
            'Bao loi trung Ma Nhan Vien
            MessageBox.Show("Administrator Code already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        Dim RefreshString As SqlDataAdapter = New SqlDataAdapter("SELECT MaQT AS 'Administrator Code' ,TenNQT AS 'Administrator Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NGUOIQUANTRI", Connect)
        DataTable.Clear()
        RefreshString.Fill(DataTable)
        dgvShowAd.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnDeleteAd_Click(sender As Object, e As EventArgs) Handles btnDeleteAd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi xoa du lieu
        Dim DeleteString As String = ("DELETE NGUOIQUANTRI WHERE MaQT = @MaQT")
        'Luu vao bien
        Dim S As SqlCommand = New SqlCommand(DeleteString, Connect)
        Dim ResultString As DialogResult = MessageBox.Show("Do you want to delete data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtAdCode.Focus()
            If txtAdCode.Text = "" Then
                MessageBox.Show("You didn't enter Administrator Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If ResultString = Windows.Forms.DialogResult.Yes Then
                    S.Parameters.AddWithValue("@MaQT", txtAdCode.Text)
                    S.ExecuteNonQuery()
                    Connect.Close() 'Dong ket noi CSDL
                    MessageBox.Show("Deleted Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAdCode.Text = Nothing
                    txtAdName.Text = Nothing
                    txtAdAddress.Text = Nothing
                    txtAdPhoneNumber.Text = Nothing
                    txtAdMail.Text = Nothing
                    txtUsernameAd.Text = Nothing
                    txtPasswordAd.Text = Nothing
                End If
            End If
        Catch EX As Exception
            'Thong bao loi khi xoa that bai
            MessageBox.Show("Delete Fails", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        DataTable.Clear()
        dgvShowAd.DataSource = DataTable
        dgvShowAd.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaQT AS 'Administrator Code' ,TenNQT AS 'Administrator Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NGUOIQUANTRI", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Dua du lieu len DataGridView
        dgvShowAd.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnUpdataAd_Click(sender As Object, e As EventArgs) Handles btnUpdataAd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi cap nhat
        Dim UpdateString As String = "UPDATE NGUOIQUANTRI SET MaQT=@MaQT, TenNQT=@TenNQT, DiaChi=@DiaChi, SDT=@SDT, ThuDienTu =@Email, NguoiDung=@NguoiDung, MatKhau=@MatKhau WHERE MaQT=@MaQT"
        'Luu du lieu vao bien
        Dim Add As SqlCommand = New SqlCommand(UpdateString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtAdCode.Focus()
            If txtAdCode.Text = "" Then
                MessageBox.Show("You didn't enter Administrator Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtAdName.Focus()
                If txtAdName.Text = "" Then
                    MessageBox.Show("You didn't enter Administrator Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtAdAddress.Focus()
                    If txtAdAddress.Text = "" Then
                        MessageBox.Show("You didn't enter Address", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAdPhoneNumber.Focus()
                        If txtAdPhoneNumber.Text = "" Then
                            MessageBox.Show("You didn't enter Phone Number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtAdMail.Focus()
                            If txtAdMail.Text = "" Then
                                MessageBox.Show("You didn't enter Email", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtUsernameAd.Focus()
                                If txtUsernameAd.Text = "" Then
                                    MessageBox.Show("You didn't enter Username", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    txtPasswordAd.Focus()
                                    If txtPasswordAd.Text = "" Then
                                        MessageBox.Show("You didn't enter Password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        'Chen du lieu
                                        Add.Parameters.AddWithValue("@MaQT", txtAdCode.Text)
                                        Add.Parameters.AddWithValue("@TenNQT", txtAdName.Text)
                                        Add.Parameters.AddWithValue("@DiaChi", txtAdAddress.Text)
                                        Add.Parameters.AddWithValue("@SDT", txtAdPhoneNumber.Text)
                                        Add.Parameters.AddWithValue("@Email", txtAdMail.Text)
                                        Add.Parameters.AddWithValue("@NguoiDung", txtUsernameAd.Text)
                                        Add.Parameters.AddWithValue("@MatKhau", txtPasswordAd.Text)
                                        Add.ExecuteNonQuery()
                                        Connect.Close() 'Dong ket noi CSDL
                                        MessageBox.Show("Updated Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtAdCode.Text = Nothing
                                        txtAdName.Text = Nothing
                                        txtAdAddress.Text = Nothing
                                        txtAdPhoneNumber.Text = Nothing
                                        txtAdMail.Text = Nothing
                                        txtUsernameAd.Text = Nothing
                                        txtPasswordAd.Text = Nothing
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
        dgvShowAd.DataSource = DataTable
        dgvShowAd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnShowlist_Click(sender As Object, e As EventArgs) Handles btnShowlist.Click
        'Load du lieu len DataGridView
        dgvShowAd.DataSource = Shows.DuLieuNguoiQuanTri.Tables(0)
    End Sub
    Private Sub frmAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaQT AS 'Administrator Code' ,TenNQT AS 'Administrator Name', DiaChi AS 'Address', SDT AS 'Phone Number', ThuDienTu AS 'Email', NguoiDung AS 'Username', MatKhau AS 'Password' FROM NGUOIQUANTRI", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Dua du lieu len DataGridView
        dgvShowAd.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnRF_Click(sender As Object, e As EventArgs) Handles btnRF.Click
        txtAdCode.Clear()
        txtAdName.Clear()
        txtAdAddress.Clear()
        txtAdMail.Clear()
        txtAdPhoneNumber.Clear()
        txtUsernameAd.Clear()
        txtPasswordAd.Clear()

        txtAdCode.Text = Nothing
        txtAdName.Text = Nothing
        txtAdAddress.Text = Nothing
        txtAdMail.Text = Nothing
        txtAdPhoneNumber.Text = Nothing
        txtUsernameAd.Text = Nothing
        txtPasswordAd.Text = Nothing
    End Sub
End Class