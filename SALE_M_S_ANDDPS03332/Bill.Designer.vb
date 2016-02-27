<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBill))
        Me.txtProCode = New System.Windows.Forms.TextBox()
        Me.lblProductCode = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtMoneyTotal = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.lblMoneyTotal = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCustomerCode = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblBillCode = New System.Windows.Forms.Label()
        Me.txtBillCode = New System.Windows.Forms.TextBox()
        Me.dgvShowBill = New System.Windows.Forms.DataGridView()
        Me.lblStaffCode = New System.Windows.Forms.Label()
        Me.txtStaffCode = New System.Windows.Forms.TextBox()
        Me.btnRefesh = New System.Windows.Forms.Button()
        Me.btnAllView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSeach = New System.Windows.Forms.Button()
        CType(Me.dgvShowBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProCode
        '
        Me.txtProCode.Location = New System.Drawing.Point(433, 133)
        Me.txtProCode.Name = "txtProCode"
        Me.txtProCode.Size = New System.Drawing.Size(134, 20)
        Me.txtProCode.TabIndex = 8
        '
        'lblProductCode
        '
        Me.lblProductCode.AutoSize = True
        Me.lblProductCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCode.Location = New System.Drawing.Point(317, 134)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(84, 16)
        Me.lblProductCode.TabIndex = 60
        Me.lblProductCode.Text = "Product Code"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(12, 183)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 16)
        Me.lblDate.TabIndex = 59
        Me.lblDate.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(113, 182)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(134, 20)
        Me.txtDate.TabIndex = 6
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(740, 133)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtNumber.TabIndex = 11
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(624, 134)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(93, 16)
        Me.lblNumber.TabIndex = 56
        Me.lblNumber.Text = "The number of"
        '
        'txtMoneyTotal
        '
        Me.txtMoneyTotal.Location = New System.Drawing.Point(740, 185)
        Me.txtMoneyTotal.Name = "txtMoneyTotal"
        Me.txtMoneyTotal.Size = New System.Drawing.Size(134, 20)
        Me.txtMoneyTotal.TabIndex = 13
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(740, 159)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(134, 20)
        Me.txtUnitPrice.TabIndex = 12
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(433, 185)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(134, 20)
        Me.txtType.TabIndex = 10
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(433, 159)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(134, 20)
        Me.txtProduct.TabIndex = 9
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(113, 156)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(113, 130)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(134, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(113, 28)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(184, 25)
        Me.txtCustomerName.TabIndex = 1
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.Location = New System.Drawing.Point(113, 103)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.Size = New System.Drawing.Size(134, 20)
        Me.txtCustomerCode.TabIndex = 3
        '
        'lblMoneyTotal
        '
        Me.lblMoneyTotal.AutoSize = True
        Me.lblMoneyTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneyTotal.Location = New System.Drawing.Point(624, 186)
        Me.lblMoneyTotal.Name = "lblMoneyTotal"
        Me.lblMoneyTotal.Size = New System.Drawing.Size(78, 16)
        Me.lblMoneyTotal.TabIndex = 41
        Me.lblMoneyTotal.Text = "Money Total"
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(624, 160)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(62, 16)
        Me.lblUnitPrice.TabIndex = 40
        Me.lblUnitPrice.Text = "Unit Price"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(317, 186)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(110, 16)
        Me.lblType.TabIndex = 39
        Me.lblType.Text = "Types of products"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(317, 160)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(51, 16)
        Me.lblProduct.TabIndex = 38
        Me.lblProduct.Text = "Product"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(12, 157)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(92, 16)
        Me.lblPhoneNumber.TabIndex = 37
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(12, 131)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(54, 16)
        Me.lblAddress.TabIndex = 36
        Me.lblAddress.Text = "Address"
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.AutoSize = True
        Me.lblCustomerCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCode.Location = New System.Drawing.Point(12, 104)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(96, 16)
        Me.lblCustomerCode.TabIndex = 35
        Me.lblCustomerCode.Text = "Customer Code"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(10, 33)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(100, 16)
        Me.lblCustomerName.TabIndex = 34
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblBillCode
        '
        Me.lblBillCode.AutoSize = True
        Me.lblBillCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillCode.Location = New System.Drawing.Point(12, 78)
        Me.lblBillCode.Name = "lblBillCode"
        Me.lblBillCode.Size = New System.Drawing.Size(57, 16)
        Me.lblBillCode.TabIndex = 33
        Me.lblBillCode.Text = "Bill Code"
        '
        'txtBillCode
        '
        Me.txtBillCode.Location = New System.Drawing.Point(113, 77)
        Me.txtBillCode.Name = "txtBillCode"
        Me.txtBillCode.Size = New System.Drawing.Size(134, 20)
        Me.txtBillCode.TabIndex = 2
        '
        'dgvShowBill
        '
        Me.dgvShowBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowBill.Location = New System.Drawing.Point(12, 216)
        Me.dgvShowBill.Name = "dgvShowBill"
        Me.dgvShowBill.Size = New System.Drawing.Size(862, 189)
        Me.dgvShowBill.TabIndex = 31
        '
        'lblStaffCode
        '
        Me.lblStaffCode.AutoSize = True
        Me.lblStaffCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffCode.Location = New System.Drawing.Point(317, 107)
        Me.lblStaffCode.Name = "lblStaffCode"
        Me.lblStaffCode.Size = New System.Drawing.Size(68, 16)
        Me.lblStaffCode.TabIndex = 62
        Me.lblStaffCode.Text = "Staff Code"
        '
        'txtStaffCode
        '
        Me.txtStaffCode.Location = New System.Drawing.Point(433, 106)
        Me.txtStaffCode.Name = "txtStaffCode"
        Me.txtStaffCode.Size = New System.Drawing.Size(134, 20)
        Me.txtStaffCode.TabIndex = 7
        '
        'btnRefesh
        '
        Me.btnRefesh.BackColor = System.Drawing.Color.White
        Me.btnRefesh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefesh.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.RF
        Me.btnRefesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefesh.Location = New System.Drawing.Point(514, 26)
        Me.btnRefesh.Name = "btnRefesh"
        Me.btnRefesh.Size = New System.Drawing.Size(83, 30)
        Me.btnRefesh.TabIndex = 16
        Me.btnRefesh.Text = "Refresh"
        Me.btnRefesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefesh.UseVisualStyleBackColor = False
        '
        'btnAllView
        '
        Me.btnAllView.BackColor = System.Drawing.Color.White
        Me.btnAllView.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllView.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.AllView
        Me.btnAllView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAllView.Location = New System.Drawing.Point(425, 26)
        Me.btnAllView.Name = "btnAllView"
        Me.btnAllView.Size = New System.Drawing.Size(83, 30)
        Me.btnAllView.TabIndex = 15
        Me.btnAllView.Text = "All View"
        Me.btnAllView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAllView.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Xoa
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(781, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 30)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Up
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(692, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 30)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.AddBill
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(603, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 30)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add Bill"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSeach
        '
        Me.btnSeach.BackColor = System.Drawing.Color.White
        Me.btnSeach.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeach.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeach.Location = New System.Drawing.Point(334, 26)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(83, 30)
        Me.btnSeach.TabIndex = 14
        Me.btnSeach.Text = "Seach"
        Me.btnSeach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeach.UseVisualStyleBackColor = False
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 417)
        Me.Controls.Add(Me.txtStaffCode)
        Me.Controls.Add(Me.lblStaffCode)
        Me.Controls.Add(Me.txtProCode)
        Me.Controls.Add(Me.lblProductCode)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnRefesh)
        Me.Controls.Add(Me.btnAllView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSeach)
        Me.Controls.Add(Me.txtMoneyTotal)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCustomerCode)
        Me.Controls.Add(Me.lblMoneyTotal)
        Me.Controls.Add(Me.lblUnitPrice)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomerCode)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblBillCode)
        Me.Controls.Add(Me.txtBillCode)
        Me.Controls.Add(Me.dgvShowBill)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBill"
        Me.Text = "Bill"
        CType(Me.dgvShowBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProCode As System.Windows.Forms.TextBox
    Friend WithEvents lblProductCode As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents btnRefesh As System.Windows.Forms.Button
    Friend WithEvents btnAllView As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSeach As System.Windows.Forms.Button
    Friend WithEvents txtMoneyTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents lblMoneyTotal As System.Windows.Forms.Label
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblBillCode As System.Windows.Forms.Label
    Friend WithEvents txtBillCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvShowBill As System.Windows.Forms.DataGridView
    Friend WithEvents lblStaffCode As System.Windows.Forms.Label
    Friend WithEvents txtStaffCode As System.Windows.Forms.TextBox
End Class
