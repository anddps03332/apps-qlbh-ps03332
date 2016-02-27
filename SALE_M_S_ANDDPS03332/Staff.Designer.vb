<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.txtPassWORD = New System.Windows.Forms.TextBox()
        Me.lblPassWord = New System.Windows.Forms.Label()
        Me.txtUserNAME = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.txtStaffCode = New System.Windows.Forms.TextBox()
        Me.lblStaffCode = New System.Windows.Forms.Label()
        Me.dgvShowStaff = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSeach = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAllView = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvShowStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassWORD
        '
        Me.txtPassWORD.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWORD.Location = New System.Drawing.Point(460, 51)
        Me.txtPassWORD.Multiline = True
        Me.txtPassWORD.Name = "txtPassWORD"
        Me.txtPassWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWORD.Size = New System.Drawing.Size(125, 20)
        Me.txtPassWORD.TabIndex = 7
        Me.txtPassWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPassWord
        '
        Me.lblPassWord.AutoSize = True
        Me.lblPassWord.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassWord.Location = New System.Drawing.Point(391, 54)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(63, 16)
        Me.lblPassWord.TabIndex = 35
        Me.lblPassWord.Text = "Password"
        '
        'txtUserNAME
        '
        Me.txtUserNAME.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserNAME.Location = New System.Drawing.Point(460, 25)
        Me.txtUserNAME.Multiline = True
        Me.txtUserNAME.Name = "txtUserNAME"
        Me.txtUserNAME.Size = New System.Drawing.Size(125, 20)
        Me.txtUserNAME.TabIndex = 6
        Me.txtUserNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(391, 27)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(66, 16)
        Me.lblUserName.TabIndex = 33
        Me.lblUserName.Text = "Username"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(132, 134)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 20)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(33, 138)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 31
        Me.lblEmail.Text = "Email"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(132, 108)
        Me.txtPhoneNumber.Multiline = True
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(219, 20)
        Me.txtPhoneNumber.TabIndex = 4
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(33, 110)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(89, 14)
        Me.lblPhoneNumber.TabIndex = 29
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(132, 82)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(219, 20)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(33, 84)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(50, 14)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "Address"
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(132, 20)
        Me.txtStaffName.Multiline = True
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(219, 28)
        Me.txtStaffName.TabIndex = 1
        Me.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(33, 25)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(83, 18)
        Me.lblStaffName.TabIndex = 25
        Me.lblStaffName.Text = "Staff Name"
        '
        'txtStaffCode
        '
        Me.txtStaffCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffCode.Location = New System.Drawing.Point(132, 56)
        Me.txtStaffCode.Multiline = True
        Me.txtStaffCode.Name = "txtStaffCode"
        Me.txtStaffCode.Size = New System.Drawing.Size(219, 20)
        Me.txtStaffCode.TabIndex = 2
        Me.txtStaffCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStaffCode
        '
        Me.lblStaffCode.AutoSize = True
        Me.lblStaffCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffCode.Location = New System.Drawing.Point(33, 58)
        Me.lblStaffCode.Name = "lblStaffCode"
        Me.lblStaffCode.Size = New System.Drawing.Size(65, 14)
        Me.lblStaffCode.TabIndex = 21
        Me.lblStaffCode.Text = "Staff Code"
        '
        'dgvShowStaff
        '
        Me.dgvShowStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowStaff.Location = New System.Drawing.Point(7, 165)
        Me.dgvShowStaff.Name = "dgvShowStaff"
        Me.dgvShowStaff.Size = New System.Drawing.Size(696, 150)
        Me.dgvShowStaff.TabIndex = 20
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.RF1
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(540, 131)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 28)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSeach
        '
        Me.btnSeach.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeach.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeach.Location = New System.Drawing.Point(378, 130)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(75, 28)
        Me.btnSeach.TabIndex = 8
        Me.btnSeach.Text = "Seach"
        Me.btnSeach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeach.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Xoa
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(612, 82)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Up
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(612, 51)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(612, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add Staff"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAllView
        '
        Me.btnAllView.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllView.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.AllView
        Me.btnAllView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAllView.Location = New System.Drawing.Point(459, 130)
        Me.btnAllView.Name = "btnAllView"
        Me.btnAllView.Size = New System.Drawing.Size(75, 28)
        Me.btnAllView.TabIndex = 36
        Me.btnAllView.Text = "All View"
        Me.btnAllView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAllView.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources._Exit
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(621, 130)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 28)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(709, 320)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAllView)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSeach)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPassWORD)
        Me.Controls.Add(Me.lblPassWord)
        Me.Controls.Add(Me.txtUserNAME)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.txtStaffCode)
        Me.Controls.Add(Me.lblStaffCode)
        Me.Controls.Add(Me.dgvShowStaff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStaff"
        Me.Text = "Staff"
        CType(Me.dgvShowStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSeach As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtPassWORD As System.Windows.Forms.TextBox
    Friend WithEvents lblPassWord As System.Windows.Forms.Label
    Friend WithEvents txtUserNAME As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents txtStaffCode As System.Windows.Forms.TextBox
    Friend WithEvents lblStaffCode As System.Windows.Forms.Label
    Friend WithEvents dgvShowStaff As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAllView As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
