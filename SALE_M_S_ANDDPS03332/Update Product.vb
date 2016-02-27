Imports System.Data.SqlClient
Imports System.Data
Public Class frmUpdateProduct
    Dim DataTable As New DataTable
    Dim Shows As New Help
    Private Sub btnSeach_Click(sender As Object, e As EventArgs) Handles btnSeach.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi truy van du lieu
        Dim StringQuery As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Types of Products', DonGia AS 'Unit Price', SoLuong AS 'Number' FROM SANPHAM WHERE TenSP LIKE '%" & txtProductName.Text & "%'", Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtProductCode.Focus()
            If txtProductCode.Text = "" Then
                MessageBox.Show("You didn't enter Product Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                DataTable.Clear()
                dgvUpdateProduct.DataSource = Nothing
                StringQuery.Fill(DataTable)
                If DataTable.Rows.Count > 0 Then
                    dgvUpdateProduct.DataSource = DataTable.DefaultView
                    txtProductCode.Text = Nothing
                Else
                    MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtProductCode.Text = Nothing
                End If
            End If
            Connect.Close() 'Dong ket noi CSDL
        Catch EX As Exception
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi chen du lieu
        Dim InsertString As String = "INSERT INTO SANPHAM VALUES (@MaSP,@TenSP,@LoaiSP, @DonGia, @SoLuong)"
        'Luu vao bien
        Dim Save As SqlCommand = New SqlCommand(InsertString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtProductCode.Focus()
            If txtProductCode.Text = "" Or txtProductName.Text = "" Or txtType.Text = "" Or txtUnitPrice.Text = "" Or txtNumber.Text = "" Then
                MessageBox.Show("You didn't enter information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtProductCode.Focus()
                If txtProductCode.Text = "" Then
                    MessageBox.Show("You didn't enter Product Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtProductName.Focus()
                    If txtProductName.Text = "" Then
                        MessageBox.Show("You didn't enter Product Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtType.Focus()
                        If txtType.Text = "" Then
                            MessageBox.Show("You didn't enter Product Type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtUnitPrice.Focus()
                            If txtUnitPrice.Text = "" Then
                                MessageBox.Show("You didn't enter Unit Price", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtNumber.Focus()
                                If txtNumber.Text = "" Then
                                    MessageBox.Show("You didn't enter Number", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    Save.Parameters.AddWithValue("@MaSP", txtProductCode.Text)
                                    Save.Parameters.AddWithValue("@TenSP", txtProductName.Text)
                                    Save.Parameters.AddWithValue("@LoaiSP", txtType.Text)
                                    Save.Parameters.AddWithValue("@DonGia", txtUnitPrice.Text)
                                    Save.Parameters.AddWithValue("@SoLuong", txtNumber.Text)
                                    Save.ExecuteNonQuery()
                                    Connect.Close() 'Dong ket noi CSDL
                                    MessageBox.Show("Saved Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtProductCode.Text = Nothing
                                    txtType.Text = Nothing
                                    txtProductName.Text = Nothing
                                    txtUnitPrice.Text = Nothing
                                    txtNumber.Text = Nothing
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            'Thong bao loi trung Ma San Pham
            MessageBox.Show("Product code already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi CSDL
        Dim RefreshString As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Types of Products', DonGia AS 'Unit Price', SoLuong AS 'Number' FROM SANPHAM", Connect)
        DataTable.Clear()
        RefreshString.Fill(DataTable)
        dgvUpdateProduct.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi xoa du lieu
        Dim DeleteString As String = ("DELETE SANPHAM WHERE MaSP=@MaSP")
        'Luu du lieu vao bien
        Dim S As SqlCommand = New SqlCommand(DeleteString, Connect)
        Dim ResultString As DialogResult = MessageBox.Show("Do you want to delete data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtProductCode.Focus()
            If txtProductCode.Text = "" Then
                MessageBox.Show("You didn't enter Product Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If ResultString = Windows.Forms.DialogResult.Yes Then
                    S.Parameters.AddWithValue("@MaSP", txtProductCode.Text)
                    S.ExecuteNonQuery()
                    Connect.Close() 'Dong ket noi CSDL
                    MessageBox.Show("Deleted Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtProductCode.Text = Nothing
                    txtProductName.Text = Nothing
                    txtType.Text = Nothing
                    txtUnitPrice.Text = Nothing
                    txtNumber.Text = Nothing
                End If
            End If
        Catch EX As Exception
            'Thong bao loi khi xoa that bai
            MessageBox.Show("Delete Fails", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi CSDL
        DataTable.Clear()
        dgvUpdateProduct.DataSource = DataTable
        dgvUpdateProduct.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Load du lieu
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Types of Products', DonGia AS 'Unit Price', SoLuong AS 'Number' FROM SANPHAM", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Hien thi du lieu len DataGridView
        dgvUpdateProduct.DataSource = DataTable.DefaultView
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Lenh thuc thi cap nhat du lieu
        Dim UpdateString As String = "UPDATE SANPHAM SET MaSP=@MaSP, TenSP=@TenSP, LoaiSP =@LoaiSP, DonGia =@DonGia, SoLuong =@SoLuong WHERE MaSP = @MaSP"
        'Luu vao bien
        Dim Add As SqlCommand = New SqlCommand(UpdateString, Connect)
        Connect.Open() 'Mo ket noi CSDL
        Try
            txtProductCode.Focus()
            If txtProductCode.Text = "" Or txtProductName.Text = "" Or txtType.Text = "" Or txtUnitPrice.Text = "" Or txtNumber.Text = "" Then
                MessageBox.Show("You didn't enter information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtProductCode.Focus()
                If txtProductCode.Text = "" Then
                    MessageBox.Show("You didn't enter Product Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtProductName.Focus()
                    If txtProductName.Text = "" Then
                        MessageBox.Show("You didn't enter Product Name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtType.Focus()
                        If txtType.Text = "" Then
                            MessageBox.Show("You didn't enter Type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtUnitPrice.Focus()
                            If txtUnitPrice.Text = "" Then
                                MessageBox.Show("You didn't enter Unit Price", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                txtNumber.Focus()
                                If txtNumber.Text = "" Then
                                    MessageBox.Show("You didn't enter Number", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    'Thu thi lenh gan du lieu
                                    Add.Parameters.AddWithValue("@MaSP", txtProductCode.Text)
                                    Add.Parameters.AddWithValue("@TenSP", txtProductName.Text)
                                    Add.Parameters.AddWithValue("@LoaiSP", txtType.Text)
                                    Add.Parameters.AddWithValue("@DonGia", txtUnitPrice.Text)
                                    Add.Parameters.AddWithValue("@SoLuong", txtNumber.Text)
                                    Add.ExecuteNonQuery()
                                    Connect.Close() 'Dong ket noi CSDL
                                    MessageBox.Show("Updated Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    'Lam moi
                                    txtProductCode.Text = Nothing
                                    txtProductName.Text = Nothing
                                    txtType.Text = Nothing
                                    txtUnitPrice.Text = Nothing
                                    txtNumber.Text = Nothing
                                End If
                        End If
                    End If
                End If
                End If
            End If
        Catch EX As Exception
        End Try
        'Lam moi du lieu
        DataTable.Clear()
        dgvUpdateProduct.DataSource = DataTable
        dgvUpdateProduct.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtProductCode.Clear()
        txtProductName.Clear()
        txtType.Clear()
        txtUnitPrice.Clear()
        txtNumber.Clear()
        'Làm mới
        txtProductCode.Text = Nothing
        txtProductName.Text = Nothing
        txtType.Text = Nothing
        txtUnitPrice.Text = Nothing
        txtNumber.Text = Nothing
    End Sub

    Private Sub btnAllView_Click(sender As Object, e As EventArgs) Handles btnAllView.Click
        'Hien thi du lieu len DataGridView
        dgvUpdateProduct.DataSource = Shows.DuLieuSanPham.Tables(0)
    End Sub

    Private Sub frmUpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        'Load du lieu
        Dim ResultLoad As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP AS 'Product Code',TenSP AS 'Product Name', LoaiSP AS 'Types of Products', DonGia AS 'Unit Price', SoLuong AS 'Number' FROM SANPHAM", Connect)
        Connect.Open() 'Mo ket noi CSDL
        ResultLoad.Fill(DataTable)
        'Hien thi du lieu len DataGridView
        dgvUpdateProduct.DataSource = DataTable.DefaultView
    End Sub
    Private Sub dgvUpdateProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpdateProduct.CellContentClick
        Try
            Dim Dobble As Integer = dgvUpdateProduct.CurrentCell.RowIndex
            txtProductCode.Text = dgvUpdateProduct.Item(0, Dobble).Value
            txtProductName.Text = dgvUpdateProduct.Item(1, Dobble).Value
            txtType.Text = dgvUpdateProduct.Item(2, Dobble).Value
            txtUnitPrice.Text = dgvUpdateProduct.Item(3, Dobble).Value
            txtNumber.Text = dgvUpdateProduct.Item(4, Dobble).Value
        Catch EX As Exception
        End Try
    End Sub
End Class