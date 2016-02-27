Imports System.Data.SqlClient
Imports System.Data
Public Class frmUpdateCustomer
    Dim DataTable As New DataTable
    Dim Shows As New Help
    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT MaKH AS 'Customer Code' ,TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG WHERE TenKH LIKE N'%" & txtCustomerName.Text & "%'", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtCustomerName.Focus()
            If txtCustomerName.Text = "" Then
                MessageBox.Show("You didn't enter Customer Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DataTable.Clear()
                dgvUpdateCustomer.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvUpdateCustomer.DataSource = DataTable.DefaultView
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi chen du lieu
        Dim InsertString As String = "INSERT INTO KHACHHANG VALUES(@MaKH,@TenKH,@DiaChi,@SDT)"
        'Luu du lieu vao bien
        Dim Save As SqlCommand = New SqlCommand(InsertString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            If txtCustomerCode.Text = "" Or txtCustomerName.Text = "" Or txtAddress.Text = "" Or txtPhoneNumber.Text = "" Then
                MessageBox.Show("You didn't enter information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtCustomerCode.Focus()
                If txtCustomerCode.Text = "" Then
                    MessageBox.Show("You didn't enter Customer Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtCustomerName.Focus()
                    If txtCustomerName.Text = "" Then
                        MessageBox.Show("You didn't enter Customer Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAddress.Focus()
                        If txtAddress.Text = "" Then
                            MessageBox.Show("You didn't enter Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtPhoneNumber.Focus()
                            If txtPhoneNumber.Text = "" Then
                                MessageBox.Show("You didn't enter Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                'Thuc thi chen du lieu
                                Save.Parameters.AddWithValue("@MaKH", txtCustomerCode.Text)
                                Save.Parameters.AddWithValue("@TenKH", txtCustomerName.Text)
                                Save.Parameters.AddWithValue("@DiaChi", txtAddress.Text)
                                Save.Parameters.AddWithValue("@SDT", txtPhoneNumber.Text)
                                Save.ExecuteNonQuery()
                                Connect.Close() 'Dong ket noi CSDL
                                MessageBox.Show("Saved Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtCustomerCode.Text = Nothing
                                txtCustomerName.Text = Nothing
                                txtAddress.Text = Nothing
                                txtPhoneNumber.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            'Thong bao du lieu trung
            MessageBox.Show("Customer code already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        Dim RefreshString As SqlDataAdapter = New SqlDataAdapter("SELECT MaKH AS 'Customer Code' ,TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG", Connect)
        DataTable.Clear()
        RefreshString.Fill(DataTable)
        'Hien thi du lieu len DataGridView
        dgvUpdateCustomer.DataSource = DataTable.DefaultView
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi xoa du lieu
        Dim DeleteString As String = ("DELETE KHACHHANG WHERE MaKH = @MaKH")
        'Luu du lieu vao bien
        Dim S As SqlCommand = New SqlCommand(DeleteString, Connect)
        Dim ResultString As DialogResult = MessageBox.Show("Do you want to delete data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtCustomerCode.Focus()
            If txtCustomerCode.Text = "" Then
                MessageBox.Show("You didn't enter Customer Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If ResultString = Windows.Forms.DialogResult.Yes Then
                    S.Parameters.AddWithValue("@MaKH", txtCustomerCode.Text)
                    S.ExecuteNonQuery()
                    Connect.Close() 'Dong ket noi CSDL
                    MessageBox.Show("Deleted Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCustomerCode.Text = Nothing
                    txtCustomerName.Text = Nothing
                    txtAddress.Text = Nothing
                    txtPhoneNumber.Text = Nothing
                End If
            End If
        Catch EX As Exception
            'Thong bao xoa that bai
            MessageBox.Show("Delete Fails", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        DataTable.Clear()
        dgvUpdateCustomer.DataSource = DataTable
        dgvUpdateCustomer.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Load du lieu 
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaKH AS 'Customer Code' ,TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Hien thi du lieu len DataGridView
        dgvUpdateCustomer.DataSource = DataTable.DefaultView
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi cap nhat du lieu
        Dim UpdateString As String = "UPDATE KHACHHANG SET MaKH=@MaKH, TenKH=@TenKH, DiaChi=@DiaChi, SDT=@SDT WHERE MaKH=@MaKH"
        'Luu vao bien
        Dim Add As SqlCommand = New SqlCommand(UpdateString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            If txtCustomerCode.Text = "" Or txtCustomerName.Text = "" Or txtAddress.Text = "" Or txtPhoneNumber.Text = "" Then
                MessageBox.Show("You didn't enter information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtCustomerCode.Focus()
                If txtCustomerCode.Text = "" Then
                    MessageBox.Show("You didn't enter Customer Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtCustomerName.Focus()
                    If txtCustomerName.Text = "" Then
                        MessageBox.Show("You didn't enter Customer Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAddress.Focus()
                        If txtAddress.Text = "" Then
                            MessageBox.Show("You didn't enter Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtPhoneNumber.Focus()
                            If txtPhoneNumber.Text = "" Then
                                MessageBox.Show("You didn't enter Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                'Thuc thi chen du lieu
                                Add.Parameters.AddWithValue("@MaKH", txtCustomerCode.Text)
                                Add.Parameters.AddWithValue("@TenKH", txtCustomerName.Text)
                                Add.Parameters.AddWithValue("@DiaChi", txtAddress.Text)
                                Add.Parameters.AddWithValue("@SDT", txtPhoneNumber.Text)
                                Add.ExecuteNonQuery()
                                Connect.Close() 'Dong ket noi CSDL
                                MessageBox.Show("Updated Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtCustomerCode.Text = Nothing
                                txtCustomerName.Text = Nothing
                                txtAddress.Text = Nothing
                                txtPhoneNumber.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            MessageBox.Show("Update Fails!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        DataTable.Clear()
        dgvUpdateCustomer.DataSource = DataTable
        dgvUpdateCustomer.DataSource = Nothing
        LoadData()
    End Sub
    
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCustomerCode.Clear()
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtPhoneNumber.Clear()
        txtCustomerCode.Text = Nothing
        txtCustomerName.Text = Nothing
        txtAddress.Text = Nothing
        txtPhoneNumber.Text = Nothing
    End Sub

    Private Sub btnAllView_Click(sender As Object, e As EventArgs) Handles btnAllView.Click
        'Hien thi du lieu len DataGridView
        dgvUpdateCustomer.DataSource = Shows.DuLieuKhachHang.Tables(0)
    End Sub
    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Load du lieu 
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaKH AS 'Customer Code' ,TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Hien thi du lieu len DataGridView
        dgvUpdateCustomer.DataSource = DataTable.DefaultView
    End Sub

    Private Sub dgvUpdateCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpdateCustomer.CellContentClick

        Dim Dobble As Integer = dgvUpdateCustomer.CurrentCell.RowIndex
        txtCustomerCode.Text = dgvUpdateCustomer.Item(0, Dobble).Value
        txtCustomerName.Text = dgvUpdateCustomer.Item(1, Dobble).Value
        txtAddress.Text = dgvUpdateCustomer.Item(2, Dobble).Value
        txtPhoneNumber.Text = dgvUpdateCustomer.Item(3, Dobble).Value

    End Sub
End Class