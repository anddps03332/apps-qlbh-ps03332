Imports System.Data.SqlClient
Imports System.Data
Public Class frmProductSeach
    Dim DataTable As New DataTable
    Dim Shows As New Help
    Private Sub btnSeachProductCode_Click(sender As Object, e As EventArgs) Handles btnSeachProductCode.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Types of Products', DonGia AS 'Unit Price', SoLuong AS 'Number' FROM SANPHAM WHERE TenSP LIKE N'%" & txtProductName.Text & "%'", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtProductName.Focus()
            If txtProductName.Text = "" Then
                MessageBox.Show("You didn't enter Product Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                DataTable.Clear()
                dgvProductSeach.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvProductSeach.DataSource = DataTable.DefaultView
                    txtProductName.Text = Nothing
                Else
                    MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtProductName.Text = Nothing
                End If
            End If
            Connect.Close() 'Dong ket noi CSDL
        Catch EX As Exception
        End Try
    End Sub

    Private Sub btnShowAllProduct_Click(sender As Object, e As EventArgs) Handles btnShowAllProduct.Click
        'Load du lieu len DataGridView
        dgvProductSeach.DataSource = Shows.DuLieuSanPham.Tables(0)
    End Sub
End Class