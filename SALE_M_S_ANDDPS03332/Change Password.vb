Imports System.Data.SqlClient
Imports System.Data
Public Class frmChangePassword
    Dim DataTable As New DataTable
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi cap nhat du lieu
        Dim UpdateString As String = "UPDATE NHANVIEN SET TenNV=@TenNV, NguoiDung=@NguoiDung, MatKhau=@MatKhau WHERE TenNV=@TenNV"
        'Luu du lieu vao bien
        Dim Add As SqlCommand = New SqlCommand(UpdateString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtStaffName.Focus()
            If txtStaffName.Text = "" Then
                MessageBox.Show("You didn't enter Staff Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtAcc.Focus()
                If txtAcc.Text = "" Then
                    MessageBox.Show("You didn't enter Account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtNewPw.Focus()
                    If txtNewPw.Text = "" Then
                        MessageBox.Show("You didn't enter Password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        'Chen du lieu
                        Add.Parameters.AddWithValue("@TenNV", txtStaffName.Text)
                        Add.Parameters.AddWithValue("@NguoiDung", txtAcc.Text)
                        Add.Parameters.AddWithValue("@MatKhau", txtNewPw.Text)
                        Add.ExecuteNonQuery()
                        Connect.Close() 'Dong ket noi CSDL
                        MessageBox.Show("Changed Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtStaffName.Text = Nothing
                        txtAcc.Text = Nothing
                        txtNewPw.Text = Nothing
                    End If
                End If
            End If
        Catch EX As Exception
            'Thong bao loi cap nhat khong thanh cong
            MessageBox.Show("Changed Fails", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        DataTable.Clear()
        dgvShowChange.DataSource = DataTable
        dgvShowChange.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lam moi du lieu
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT TenNV AS 'Staff Name', NguoiDung AS 'Username', MatKhau AS 'New Password' FROM NHANVIEN", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Load du lieu len DataGridView
        dgvShowChange.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lam moi du lieu
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT TenNV AS 'Staff Name', NguoiDung AS 'Username', MatKhau AS 'New Password' FROM NHANVIEN", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Load du lieu len DataGridView
        dgvShowChange.DataSource = DataTable.DefaultView
    End Sub

    Private Sub dgvShowChange_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowChange.CellContentClick
        Try
            Dim Dobble As Integer = dgvShowChange.CurrentCell.RowIndex
            txtStaffName.Text = dgvShowChange.Item(0, Dobble).Value
            txtAcc.Text = dgvShowChange.Item(1, Dobble).Value
            txtNewPw.Text = dgvShowChange.Item(2, Dobble).Value
        Catch EX As Exception
        End Try
    End Sub
End Class