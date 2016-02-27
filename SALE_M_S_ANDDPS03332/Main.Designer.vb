<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiContact = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiInformationSoftware = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAdministrator = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCreateAdministratorAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiChangeThePasswordsOfStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCustandProd = New System.Windows.Forms.Button()
        Me.ptbLogin = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbPicAd = New System.Windows.Forms.PictureBox()
        Me.btnLoginAd = New System.Windows.Forms.Button()
        Me.txtPassAd = New System.Windows.Forms.TextBox()
        Me.txtUserAd = New System.Windows.Forms.TextBox()
        Me.lblPassAd = New System.Windows.Forms.Label()
        Me.lblUserAd = New System.Windows.Forms.Label()
        Me.txtAdCode = New System.Windows.Forms.TextBox()
        Me.lblAdCode = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ptbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPicAd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(618, 159)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(139, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(618, 126)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(139, 20)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(545, 163)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(63, 16)
        Me.lblPassword.TabIndex = 78
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(545, 130)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(66, 16)
        Me.lblUsername.TabIndex = 77
        Me.lblUsername.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Sales Management Software - Copyright by Ma Mào Mè"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiContact, Me.tsmiInformationSoftware, Me.tsmiLogin, Me.tsmiCreateAdministratorAccount, Me.tsmiChangeThePasswordsOfStaff, Me.tsmiLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 24)
        Me.MenuStrip1.TabIndex = 80
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiContact
        '
        Me.tsmiContact.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiContact.ForeColor = System.Drawing.Color.Blue
        Me.tsmiContact.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Contact
        Me.tsmiContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiContact.Name = "tsmiContact"
        Me.tsmiContact.Size = New System.Drawing.Size(79, 20)
        Me.tsmiContact.Text = "Contact"
        Me.tsmiContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsmiInformationSoftware
        '
        Me.tsmiInformationSoftware.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiInformationSoftware.ForeColor = System.Drawing.Color.Blue
        Me.tsmiInformationSoftware.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Info
        Me.tsmiInformationSoftware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiInformationSoftware.Name = "tsmiInformationSoftware"
        Me.tsmiInformationSoftware.Size = New System.Drawing.Size(158, 20)
        Me.tsmiInformationSoftware.Text = "Information Software"
        Me.tsmiInformationSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsmiLogin
        '
        Me.tsmiLogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAdministrator, Me.tsmiUsers})
        Me.tsmiLogin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiLogin.ForeColor = System.Drawing.Color.Blue
        Me.tsmiLogin.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.login
        Me.tsmiLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiLogin.Name = "tsmiLogin"
        Me.tsmiLogin.Size = New System.Drawing.Size(66, 20)
        Me.tsmiLogin.Text = "Login"
        Me.tsmiLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsmiAdministrator
        '
        Me.tsmiAdministrator.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Ad
        Me.tsmiAdministrator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiAdministrator.Name = "tsmiAdministrator"
        Me.tsmiAdministrator.Size = New System.Drawing.Size(153, 22)
        Me.tsmiAdministrator.Text = "Administrator"
        Me.tsmiAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsmiUsers
        '
        Me.tsmiUsers.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.User
        Me.tsmiUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiUsers.Name = "tsmiUsers"
        Me.tsmiUsers.Size = New System.Drawing.Size(153, 22)
        Me.tsmiUsers.Text = "Users"
        Me.tsmiUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsmiCreateAdministratorAccount
        '
        Me.tsmiCreateAdministratorAccount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiCreateAdministratorAccount.ForeColor = System.Drawing.Color.Blue
        Me.tsmiCreateAdministratorAccount.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Create
        Me.tsmiCreateAdministratorAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiCreateAdministratorAccount.Name = "tsmiCreateAdministratorAccount"
        Me.tsmiCreateAdministratorAccount.Size = New System.Drawing.Size(204, 20)
        Me.tsmiCreateAdministratorAccount.Text = "Create Administrator Account"
        Me.tsmiCreateAdministratorAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsmiCreateAdministratorAccount.Visible = False
        '
        'tsmiChangeThePasswordsOfStaff
        '
        Me.tsmiChangeThePasswordsOfStaff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiChangeThePasswordsOfStaff.ForeColor = System.Drawing.Color.Blue
        Me.tsmiChangeThePasswordsOfStaff.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Change
        Me.tsmiChangeThePasswordsOfStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiChangeThePasswordsOfStaff.Name = "tsmiChangeThePasswordsOfStaff"
        Me.tsmiChangeThePasswordsOfStaff.Size = New System.Drawing.Size(212, 20)
        Me.tsmiChangeThePasswordsOfStaff.Text = "Change the Passwords of Staff"
        Me.tsmiChangeThePasswordsOfStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsmiChangeThePasswordsOfStaff.Visible = False
        '
        'tsmiLogout
        '
        Me.tsmiLogout.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiLogout.ForeColor = System.Drawing.Color.Red
        Me.tsmiLogout.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources._Exit
        Me.tsmiLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiLogout.Name = "tsmiLogout"
        Me.tsmiLogout.Size = New System.Drawing.Size(74, 20)
        Me.tsmiLogout.Text = "Logout"
        Me.tsmiLogout.Visible = False
        '
        'btnCustandProd
        '
        Me.btnCustandProd.BackColor = System.Drawing.Color.White
        Me.btnCustandProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustandProd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustandProd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.CustomerandProduct
        Me.btnCustandProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustandProd.Location = New System.Drawing.Point(491, 186)
        Me.btnCustandProd.Name = "btnCustandProd"
        Me.btnCustandProd.Size = New System.Drawing.Size(266, 57)
        Me.btnCustandProd.TabIndex = 81
        Me.btnCustandProd.TabStop = False
        Me.btnCustandProd.Text = "Customer and Product Management"
        Me.btnCustandProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCustandProd.UseVisualStyleBackColor = False
        Me.btnCustandProd.Visible = False
        '
        'ptbLogin
        '
        Me.ptbLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ptbLogin.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Login_image
        Me.ptbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogin.Location = New System.Drawing.Point(405, 94)
        Me.ptbLogin.Name = "ptbLogin"
        Me.ptbLogin.Size = New System.Drawing.Size(134, 121)
        Me.ptbLogin.TabIndex = 79
        Me.ptbLogin.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.login
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(769, 126)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(68, 53)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.White
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Staff1
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(393, 186)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(92, 57)
        Me.btnStaff.TabIndex = 4
        Me.btnStaff.TabStop = False
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStaff.UseVisualStyleBackColor = False
        Me.btnStaff.Visible = False
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.Color.White
        Me.btnBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBill.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBill.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.HoaDon
        Me.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBill.Location = New System.Drawing.Point(763, 186)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(92, 57)
        Me.btnBill.TabIndex = 7
        Me.btnBill.TabStop = False
        Me.btnBill.Text = "Bill"
        Me.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBill.UseVisualStyleBackColor = False
        Me.btnBill.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(725, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "GVHD: LE VAN PHUNG"
        '
        'ptbPicAd
        '
        Me.ptbPicAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ptbPicAd.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Keychain_Access_icon
        Me.ptbPicAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbPicAd.Location = New System.Drawing.Point(405, 94)
        Me.ptbPicAd.Name = "ptbPicAd"
        Me.ptbPicAd.Size = New System.Drawing.Size(134, 121)
        Me.ptbPicAd.TabIndex = 88
        Me.ptbPicAd.TabStop = False
        Me.ptbPicAd.Visible = False
        '
        'btnLoginAd
        '
        Me.btnLoginAd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoginAd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginAd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.login
        Me.btnLoginAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginAd.Location = New System.Drawing.Point(769, 145)
        Me.btnLoginAd.Name = "btnLoginAd"
        Me.btnLoginAd.Size = New System.Drawing.Size(68, 53)
        Me.btnLoginAd.TabIndex = 4
        Me.btnLoginAd.Text = "Login"
        Me.btnLoginAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginAd.UseVisualStyleBackColor = True
        Me.btnLoginAd.Visible = False
        '
        'txtPassAd
        '
        Me.txtPassAd.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassAd.Location = New System.Drawing.Point(618, 159)
        Me.txtPassAd.Multiline = True
        Me.txtPassAd.Name = "txtPassAd"
        Me.txtPassAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassAd.Size = New System.Drawing.Size(139, 20)
        Me.txtPassAd.TabIndex = 2
        Me.txtPassAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPassAd.Visible = False
        '
        'txtUserAd
        '
        Me.txtUserAd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAd.Location = New System.Drawing.Point(618, 126)
        Me.txtUserAd.Multiline = True
        Me.txtUserAd.Name = "txtUserAd"
        Me.txtUserAd.Size = New System.Drawing.Size(139, 20)
        Me.txtUserAd.TabIndex = 1
        Me.txtUserAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUserAd.Visible = False
        '
        'lblPassAd
        '
        Me.lblPassAd.AutoSize = True
        Me.lblPassAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPassAd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassAd.Location = New System.Drawing.Point(545, 163)
        Me.lblPassAd.Name = "lblPassAd"
        Me.lblPassAd.Size = New System.Drawing.Size(63, 16)
        Me.lblPassAd.TabIndex = 87
        Me.lblPassAd.Text = "Password"
        Me.lblPassAd.Visible = False
        '
        'lblUserAd
        '
        Me.lblUserAd.AutoSize = True
        Me.lblUserAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserAd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserAd.Location = New System.Drawing.Point(545, 130)
        Me.lblUserAd.Name = "lblUserAd"
        Me.lblUserAd.Size = New System.Drawing.Size(66, 16)
        Me.lblUserAd.TabIndex = 86
        Me.lblUserAd.Text = "Username"
        Me.lblUserAd.Visible = False
        '
        'txtAdCode
        '
        Me.txtAdCode.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdCode.Location = New System.Drawing.Point(669, 197)
        Me.txtAdCode.Multiline = True
        Me.txtAdCode.Name = "txtAdCode"
        Me.txtAdCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdCode.Size = New System.Drawing.Size(88, 20)
        Me.txtAdCode.TabIndex = 3
        Me.txtAdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAdCode.Visible = False
        '
        'lblAdCode
        '
        Me.lblAdCode.AutoSize = True
        Me.lblAdCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAdCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdCode.Location = New System.Drawing.Point(545, 199)
        Me.lblAdCode.Name = "lblAdCode"
        Me.lblAdCode.Size = New System.Drawing.Size(118, 16)
        Me.lblAdCode.TabIndex = 90
        Me.lblAdCode.Text = "Administrator Code"
        Me.lblAdCode.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.BBB
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(872, 313)
        Me.Controls.Add(Me.txtAdCode)
        Me.Controls.Add(Me.lblAdCode)
        Me.Controls.Add(Me.ptbPicAd)
        Me.Controls.Add(Me.btnLoginAd)
        Me.Controls.Add(Me.txtPassAd)
        Me.Controls.Add(Me.txtUserAd)
        Me.Controls.Add(Me.lblPassAd)
        Me.Controls.Add(Me.lblUserAd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCustandProd)
        Me.Controls.Add(Me.ptbLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Sales Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ptbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPicAd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbLogin As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBill As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiInformationSoftware As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCustandProd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsmiLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAdministrator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptbPicAd As System.Windows.Forms.PictureBox
    Friend WithEvents btnLoginAd As System.Windows.Forms.Button
    Friend WithEvents txtPassAd As System.Windows.Forms.TextBox
    Friend WithEvents txtUserAd As System.Windows.Forms.TextBox
    Friend WithEvents lblPassAd As System.Windows.Forms.Label
    Friend WithEvents lblUserAd As System.Windows.Forms.Label
    Friend WithEvents tsmiCreateAdministratorAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtAdCode As System.Windows.Forms.TextBox
    Friend WithEvents lblAdCode As System.Windows.Forms.Label
    Friend WithEvents tsmiChangeThePasswordsOfStaff As System.Windows.Forms.ToolStripMenuItem

End Class
