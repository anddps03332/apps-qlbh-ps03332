Imports System.Data.SqlClient
Imports System.Data
Public Class frmMain
    Dim DataTable As New DataTable
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        Dim StringQuery As New SqlDataAdapter("SELECT * FROM NHANVIEN WHERE NguoiDung ='" & txtUsername.Text & "' AND MatKhau ='" & txtPassword.Text & "'", Connect)
        Try
            Connect.Open() 'Mo ket noi CSDL
            StringQuery.Fill(DataTable) 'So sanh du lieu tu CSDL
            Connect.Close() 'Dong ket noi CSDL
            If txtPassword.Text = "" And txtUsername.Text = "" Then
                MessageBox.Show("You didn't enter Account and Password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtUsername.Focus()
                If txtUsername.Text = "" Then
                    MessageBox.Show("You didn't enter your Account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtPassword.Focus()
                    If txtPassword.Text = "" Then
                        MessageBox.Show("You didn't enter your Password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If (DataTable.Rows.Count > 0) Then
                            MessageBox.Show("Login Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Dieu kien
                            btnBill.Visible = True
                            btnCustandProd.Visible = True
                            lblUsername.Visible = False
                            lblPassword.Visible = False
                            txtUsername.Visible = False
                            txtPassword.Visible = False
                            btnLogin.Visible = False
                            ptbLogin.Visible = False
                            tsmiLogin.Visible = False
                            tsmiLogout.Visible = True
                            'Làm mới dữ liệu
                            txtUsername.Text = Nothing
                            txtPassword.Text = Nothing
                        Else
                            MessageBox.Show("Account or password didn't correct!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
        End Try
    End Sub

    Private Sub tsmiLogout_Click(sender As Object, e As EventArgs) Handles tsmiLogout.Click
        Dim Result As DialogResult = MessageBox.Show("Do you want to Logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            'Thuc thi lenh
            If Result = Windows.Forms.DialogResult.Yes Then
                btnBill.Visible = False
                btnStaff.Visible = False
                btnCustandProd.Visible = False
                lblUsername.Visible = True
                lblPassword.Visible = True
                txtUsername.Visible = True
                txtPassword.Visible = True
                btnLogin.Visible = True
                ptbLogin.Visible = True
                tsmiLogin.Visible = True
                tsmiLogout.Visible = False
                ptbPicAd.Visible = False
                lblUserAd.Visible = False
                lblPassAd.Visible = False
                btnLoginAd.Visible = False
                tsmiCreateAdministratorAccount.Visible = False
                lblAdCode.Visible = False
                txtAdCode.Visible = False
                tsmiChangeThePasswordsOfStaff.Visible = False
                'Làm mới dữ liệu
                txtUsername.Text = Nothing
                txtPassword.Text = Nothing
                txtAdCode.Text = Nothing
                MessageBox.Show("Logout Successfull!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
        End Try
        DataTable.Clear()
    End Sub

    Private Sub tsmiInformationSoftware_Click(sender As Object, e As EventArgs) Handles tsmiInformationSoftware.Click
        frmInformationSoftware.Show()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        frmStaff.Show()
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        frmBill.Show()
    End Sub

    Private Sub btnCustandProd_Click(sender As Object, e As EventArgs) Handles btnCustandProd.Click
        frmCustomerAndProductInformation.Show()
    End Sub

    Private Sub tsmiContact_Click(sender As Object, e As EventArgs) Handles tsmiContact.Click
        frmContact.Show()
    End Sub

    Private Sub tsmiAdministrator_Click(sender As Object, e As EventArgs) Handles tsmiAdministrator.Click
        ptbPicAd.Visible = True
        lblUserAd.Visible = True
        lblPassAd.Visible = True
        btnLoginAd.Visible = True
        tsmiLogout.Visible = True
        txtUserAd.Visible = True
        txtPassAd.Visible = True
        lblAdCode.Visible = True
        txtAdCode.Visible = True


        txtAdCode.Text = Nothing
        txtUserAd.Text = Nothing
        txtPassAd.Text = Nothing

        ptbLogin.Visible = False
        lblUsername.Visible = False
        lblPassword.Visible = False
        txtUsername.Visible = False
        txtPassword.Visible = False
        btnLogin.Visible = False
        tsmiLogout.Visible = False

        txtUsername.Text = Nothing
        txtPassword.Text = Nothing
    End Sub

    Private Sub tsmiUsers_Click(sender As Object, e As EventArgs) Handles tsmiUsers.Click
        ptbPicAd.Visible = False
        lblUserAd.Visible = False
        lblPassAd.Visible = False
        txtUserAd.Visible = False
        txtPassAd.Visible = False
        btnLoginAd.Visible = False
        txtAdCode.Visible = False
        lblAdCode.Visible = False


        txtUserAd.Text = Nothing
        txtPassAd.Text = Nothing
        txtAdCode.Text = Nothing

        ptbLogin.Visible = True
        lblUsername.Visible = True
        lblPassword.Visible = True
        txtUsername.Visible = True
        txtPassword.Visible = True
        btnLogin.Visible = True

        txtUsername.Text = Nothing
        txtPassword.Text = Nothing
    End Sub

    Private Sub btnLoginAd_Click(sender As Object, e As EventArgs) Handles btnLoginAd.Click
        Dim Connect As SqlConnection = New SqlConnection(StringConnect)
        Dim StringQuery As New SqlDataAdapter("SELECT * FROM NGUOIQUANTRI WHERE NguoiDung ='" & txtUserAd.Text & "' AND MatKhau ='" & txtPassAd.Text & "' AND MaQT ='" & txtAdCode.Text & "'", Connect)
        Try
            Connect.Open() 'Mo ket noi CSDL
            StringQuery.Fill(DataTable) 'So sanh du lieu tu CSDL
            Connect.Close() 'Dong ket noi CSDL

            If txtPassAd.Text = "" And txtUserAd.Text = "" And txtAdCode.Text = "" Then
                MessageBox.Show("You didn't enter Account or Password or Administrator Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtUserAd.Focus()
                If txtUserAd.Text = "" Then
                    MessageBox.Show("You didn't enter your Account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtPassAd.Focus()
                    If txtPassAd.Text = "" Then
                        MessageBox.Show("You didn't enter your Password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtAdCode.Focus()
                        If txtAdCode.Text = "" Then
                            MessageBox.Show("You didn't enter Administrator Code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            If (DataTable.Rows.Count > 0) Then
                                MessageBox.Show("Login Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'Dieu kien
                                btnBill.Visible = True
                                btnCustandProd.Visible = True
                                btnStaff.Visible = True
                                tsmiCreateAdministratorAccount.Visible = True
                                tsmiChangeThePasswordsOfStaff.Visible = True
                                lblUserAd.Visible = False
                                lblPassAd.Visible = False
                                txtUserAd.Visible = False
                                txtPassAd.Visible = False
                                btnLoginAd.Visible = False
                                ptbPicAd.Visible = False
                                tsmiLogout.Visible = True
                                tsmiLogin.Visible = False
                                lblAdCode.Visible = False
                                txtAdCode.Visible = False

                                'Làm mới dữ liệu
                                txtUserAd.Text = Nothing
                                txtPassAd.Text = Nothing
                                txtAdCode.Text = Nothing
                            Else
                                MessageBox.Show("Account or password didn't correct!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
        End Try
    End Sub

    Private Sub tsmiCreateAdministratorAccount_Click(sender As Object, e As EventArgs) Handles tsmiCreateAdministratorAccount.Click
        frmAdministrator.Show()
    End Sub

    Private Sub tsmiChangeThePasswordsOfStaff_Click(sender As Object, e As EventArgs) Handles tsmiChangeThePasswordsOfStaff.Click
        frmChangePassword.Show()
    End Sub
End Class
