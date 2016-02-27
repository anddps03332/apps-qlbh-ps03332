<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrator))
        Me.btnAddAd = New System.Windows.Forms.Button()
        Me.lblAdminCode = New System.Windows.Forms.Label()
        Me.txtAdCode = New System.Windows.Forms.TextBox()
        Me.lblADN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdName = New System.Windows.Forms.TextBox()
        Me.txtAdAddress = New System.Windows.Forms.TextBox()
        Me.txtAdPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAdMail = New System.Windows.Forms.TextBox()
        Me.txtUsernameAd = New System.Windows.Forms.TextBox()
        Me.txtPasswordAd = New System.Windows.Forms.TextBox()
        Me.btnSeachAd = New System.Windows.Forms.Button()
        Me.btnUpdataAd = New System.Windows.Forms.Button()
        Me.btnDeleteAd = New System.Windows.Forms.Button()
        Me.dgvShowAd = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnShowlist = New System.Windows.Forms.Button()
        Me.btnRF = New System.Windows.Forms.Button()
        CType(Me.dgvShowAd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddAd
        '
        Me.btnAddAd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Add
        Me.btnAddAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAd.Location = New System.Drawing.Point(434, 202)
        Me.btnAddAd.Name = "btnAddAd"
        Me.btnAddAd.Size = New System.Drawing.Size(75, 35)
        Me.btnAddAd.TabIndex = 9
        Me.btnAddAd.Text = "Add"
        Me.btnAddAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAd.UseVisualStyleBackColor = True
        '
        'lblAdminCode
        '
        Me.lblAdminCode.AutoSize = True
        Me.lblAdminCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminCode.Location = New System.Drawing.Point(25, 143)
        Me.lblAdminCode.Name = "lblAdminCode"
        Me.lblAdminCode.Size = New System.Drawing.Size(82, 16)
        Me.lblAdminCode.TabIndex = 1
        Me.lblAdminCode.Text = "Admin Code:"
        '
        'txtAdCode
        '
        Me.txtAdCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdCode.Location = New System.Drawing.Point(158, 142)
        Me.txtAdCode.Multiline = True
        Me.txtAdCode.Name = "txtAdCode"
        Me.txtAdCode.Size = New System.Drawing.Size(162, 23)
        Me.txtAdCode.TabIndex = 2
        '
        'lblADN
        '
        Me.lblADN.AutoSize = True
        Me.lblADN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADN.Location = New System.Drawing.Point(25, 103)
        Me.lblADN.Name = "lblADN"
        Me.lblADN.Size = New System.Drawing.Size(122, 16)
        Me.lblADN.TabIndex = 3
        Me.lblADN.Text = "Administrator Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(362, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password:"
        '
        'txtAdName
        '
        Me.txtAdName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdName.Location = New System.Drawing.Point(158, 101)
        Me.txtAdName.Multiline = True
        Me.txtAdName.Name = "txtAdName"
        Me.txtAdName.Size = New System.Drawing.Size(162, 23)
        Me.txtAdName.TabIndex = 1
        '
        'txtAdAddress
        '
        Me.txtAdAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdAddress.Location = New System.Drawing.Point(158, 181)
        Me.txtAdAddress.Multiline = True
        Me.txtAdAddress.Name = "txtAdAddress"
        Me.txtAdAddress.Size = New System.Drawing.Size(162, 23)
        Me.txtAdAddress.TabIndex = 3
        '
        'txtAdPhoneNumber
        '
        Me.txtAdPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdPhoneNumber.Location = New System.Drawing.Point(158, 221)
        Me.txtAdPhoneNumber.Multiline = True
        Me.txtAdPhoneNumber.Name = "txtAdPhoneNumber"
        Me.txtAdPhoneNumber.Size = New System.Drawing.Size(162, 23)
        Me.txtAdPhoneNumber.TabIndex = 4
        '
        'txtAdMail
        '
        Me.txtAdMail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdMail.Location = New System.Drawing.Point(158, 259)
        Me.txtAdMail.Multiline = True
        Me.txtAdMail.Name = "txtAdMail"
        Me.txtAdMail.Size = New System.Drawing.Size(162, 23)
        Me.txtAdMail.TabIndex = 5
        '
        'txtUsernameAd
        '
        Me.txtUsernameAd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameAd.Location = New System.Drawing.Point(449, 125)
        Me.txtUsernameAd.Multiline = True
        Me.txtUsernameAd.Name = "txtUsernameAd"
        Me.txtUsernameAd.Size = New System.Drawing.Size(162, 23)
        Me.txtUsernameAd.TabIndex = 6
        '
        'txtPasswordAd
        '
        Me.txtPasswordAd.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordAd.Location = New System.Drawing.Point(449, 163)
        Me.txtPasswordAd.Multiline = True
        Me.txtPasswordAd.Name = "txtPasswordAd"
        Me.txtPasswordAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordAd.Size = New System.Drawing.Size(162, 23)
        Me.txtPasswordAd.TabIndex = 7
        '
        'btnSeachAd
        '
        Me.btnSeachAd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeachAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeachAd.Location = New System.Drawing.Point(504, 246)
        Me.btnSeachAd.Name = "btnSeachAd"
        Me.btnSeachAd.Size = New System.Drawing.Size(157, 36)
        Me.btnSeachAd.TabIndex = 13
        Me.btnSeachAd.Text = "Seach Administrator Name"
        Me.btnSeachAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeachAd.UseVisualStyleBackColor = True
        '
        'btnUpdataAd
        '
        Me.btnUpdataAd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Up
        Me.btnUpdataAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdataAd.Location = New System.Drawing.Point(515, 202)
        Me.btnUpdataAd.Name = "btnUpdataAd"
        Me.btnUpdataAd.Size = New System.Drawing.Size(75, 35)
        Me.btnUpdataAd.TabIndex = 10
        Me.btnUpdataAd.Text = "Update"
        Me.btnUpdataAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdataAd.UseVisualStyleBackColor = True
        '
        'btnDeleteAd
        '
        Me.btnDeleteAd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Xoa
        Me.btnDeleteAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteAd.Location = New System.Drawing.Point(597, 202)
        Me.btnDeleteAd.Name = "btnDeleteAd"
        Me.btnDeleteAd.Size = New System.Drawing.Size(75, 35)
        Me.btnDeleteAd.TabIndex = 11
        Me.btnDeleteAd.Text = "Delete"
        Me.btnDeleteAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteAd.UseVisualStyleBackColor = True
        '
        'dgvShowAd
        '
        Me.dgvShowAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowAd.Location = New System.Drawing.Point(13, 293)
        Me.dgvShowAd.Name = "dgvShowAd"
        Me.dgvShowAd.Size = New System.Drawing.Size(670, 130)
        Me.dgvShowAd.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(126, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 19)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Management Software"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(126, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "SALES"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.administrator_400x300
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(449, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 103)
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 73)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'btnShowlist
        '
        Me.btnShowlist.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.AllView
        Me.btnShowlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowlist.Location = New System.Drawing.Point(368, 246)
        Me.btnShowlist.Name = "btnShowlist"
        Me.btnShowlist.Size = New System.Drawing.Size(130, 36)
        Me.btnShowlist.TabIndex = 12
        Me.btnShowlist.Text = "All Administrator List"
        Me.btnShowlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowlist.UseVisualStyleBackColor = True
        '
        'btnRF
        '
        Me.btnRF.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.RF1
        Me.btnRF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRF.Location = New System.Drawing.Point(353, 202)
        Me.btnRF.Name = "btnRF"
        Me.btnRF.Size = New System.Drawing.Size(75, 35)
        Me.btnRF.TabIndex = 8
        Me.btnRF.Text = "Refresh"
        Me.btnRF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRF.UseVisualStyleBackColor = True
        '
        'frmAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(695, 435)
        Me.Controls.Add(Me.btnRF)
        Me.Controls.Add(Me.btnShowlist)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvShowAd)
        Me.Controls.Add(Me.btnDeleteAd)
        Me.Controls.Add(Me.btnUpdataAd)
        Me.Controls.Add(Me.btnSeachAd)
        Me.Controls.Add(Me.txtPasswordAd)
        Me.Controls.Add(Me.txtUsernameAd)
        Me.Controls.Add(Me.txtAdMail)
        Me.Controls.Add(Me.txtAdPhoneNumber)
        Me.Controls.Add(Me.txtAdAddress)
        Me.Controls.Add(Me.txtAdName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblADN)
        Me.Controls.Add(Me.txtAdCode)
        Me.Controls.Add(Me.lblAdminCode)
        Me.Controls.Add(Me.btnAddAd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdministrator"
        Me.Text = "Administrator"
        CType(Me.dgvShowAd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddAd As System.Windows.Forms.Button
    Friend WithEvents lblAdminCode As System.Windows.Forms.Label
    Friend WithEvents txtAdCode As System.Windows.Forms.TextBox
    Friend WithEvents lblADN As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAdName As System.Windows.Forms.TextBox
    Friend WithEvents txtAdAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAdPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAdMail As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameAd As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordAd As System.Windows.Forms.TextBox
    Friend WithEvents btnSeachAd As System.Windows.Forms.Button
    Friend WithEvents btnUpdataAd As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAd As System.Windows.Forms.Button
    Friend WithEvents dgvShowAd As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnShowlist As System.Windows.Forms.Button
    Friend WithEvents btnRF As System.Windows.Forms.Button
End Class
