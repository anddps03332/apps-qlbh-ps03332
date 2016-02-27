<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSeach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSeach))
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.dgvCustomerSeach = New System.Windows.Forms.DataGridView()
        Me.ptbCustomer = New System.Windows.Forms.PictureBox()
        Me.btnShowAllCustomer = New System.Windows.Forms.Button()
        Me.btnSeachCustomer = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerSeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(158, 142)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(311, 32)
        Me.txtCustomerName.TabIndex = 1
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(29, 148)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(123, 19)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Customer Name"
        '
        'dgvCustomerSeach
        '
        Me.dgvCustomerSeach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSeach.Location = New System.Drawing.Point(12, 246)
        Me.dgvCustomerSeach.Name = "dgvCustomerSeach"
        Me.dgvCustomerSeach.Size = New System.Drawing.Size(472, 168)
        Me.dgvCustomerSeach.TabIndex = 14
        '
        'ptbCustomer
        '
        Me.ptbCustomer.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Cus
        Me.ptbCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbCustomer.Location = New System.Drawing.Point(182, 22)
        Me.ptbCustomer.Name = "ptbCustomer"
        Me.ptbCustomer.Size = New System.Drawing.Size(100, 100)
        Me.ptbCustomer.TabIndex = 13
        Me.ptbCustomer.TabStop = False
        '
        'btnShowAllCustomer
        '
        Me.btnShowAllCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAllCustomer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllCustomer.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.AllView
        Me.btnShowAllCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowAllCustomer.Location = New System.Drawing.Point(336, 192)
        Me.btnShowAllCustomer.Name = "btnShowAllCustomer"
        Me.btnShowAllCustomer.Size = New System.Drawing.Size(133, 35)
        Me.btnShowAllCustomer.TabIndex = 3
        Me.btnShowAllCustomer.TabStop = False
        Me.btnShowAllCustomer.Text = "Show All"
        Me.btnShowAllCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowAllCustomer.UseVisualStyleBackColor = True
        '
        'btnSeachCustomer
        '
        Me.btnSeachCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeachCustomer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeachCustomer.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeachCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeachCustomer.Location = New System.Drawing.Point(158, 192)
        Me.btnSeachCustomer.Name = "btnSeachCustomer"
        Me.btnSeachCustomer.Size = New System.Drawing.Size(133, 35)
        Me.btnSeachCustomer.TabIndex = 2
        Me.btnSeachCustomer.TabStop = False
        Me.btnSeachCustomer.Text = "Search Customer"
        Me.btnSeachCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeachCustomer.UseVisualStyleBackColor = True
        '
        'frmCustomerSeach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 426)
        Me.Controls.Add(Me.dgvCustomerSeach)
        Me.Controls.Add(Me.ptbCustomer)
        Me.Controls.Add(Me.btnShowAllCustomer)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.btnSeachCustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerSeach"
        Me.Text = "Customer Seach"
        CType(Me.dgvCustomerSeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents btnShowAllCustomer As System.Windows.Forms.Button
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents btnSeachCustomer As System.Windows.Forms.Button
    Friend WithEvents dgvCustomerSeach As System.Windows.Forms.DataGridView
End Class
