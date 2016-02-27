Imports System.Data.SqlClient
Imports System.Data
Public Class frmCustomerSeach
    Dim DataTable As New DataTable
    Dim Shows As New Help
    Private Sub btnSeachCustomer_Click(sender As Object, e As EventArgs) Handles btnSeachCustomer.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT MaKH AS 'Customer Code' ,TenKH AS 'Customer Name', DiaChi AS 'Address', SDT AS 'Phone Number' FROM KHACHHANG WHERE TenKH LIKE N'%" & txtCustomerName.Text & "%'", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtCustomerName.Focus()
            If txtCustomerName.Text = "" Then
                MessageBox.Show("You didn't enter Customer Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DataTable.Clear()
                dgvCustomerSeach.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvCustomerSeach.DataSource = DataTable.DefaultView
                    txtCustomerName.Text = Nothing
                Else
                    MessageBox.Show("Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCustomerName.Text = Nothing
                End If
            End If
            Connect.Close() 'Dong ket noi CSDL
        Catch EX As Exception
        End Try
    End Sub

    Private Sub btnShowAllCustomer_Click(sender As Object, e As EventArgs) Handles btnShowAllCustomer.Click
        'Load du lieu len DataGridView
        dgvCustomerSeach.DataSource = Shows.DuLieuKhachHang.Tables(0)
    End Sub
End Class