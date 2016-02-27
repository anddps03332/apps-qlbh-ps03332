<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductSeach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductSeach))
        Me.ptbProduct = New System.Windows.Forms.PictureBox()
        Me.btnShowAllProduct = New System.Windows.Forms.Button()
        Me.btnSeachProductCode = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.dgvProductSeach = New System.Windows.Forms.DataGridView()
        CType(Me.ptbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductSeach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbProduct
        '
        Me.ptbProduct.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.LP_0_LEAN_PRODUCTS
        Me.ptbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbProduct.Location = New System.Drawing.Point(202, 21)
        Me.ptbProduct.Name = "ptbProduct"
        Me.ptbProduct.Size = New System.Drawing.Size(100, 100)
        Me.ptbProduct.TabIndex = 14
        Me.ptbProduct.TabStop = False
        '
        'btnShowAllProduct
        '
        Me.btnShowAllProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAllProduct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllProduct.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.AllView
        Me.btnShowAllProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowAllProduct.Location = New System.Drawing.Point(322, 195)
        Me.btnShowAllProduct.Name = "btnShowAllProduct"
        Me.btnShowAllProduct.Size = New System.Drawing.Size(133, 35)
        Me.btnShowAllProduct.TabIndex = 3
        Me.btnShowAllProduct.TabStop = False
        Me.btnShowAllProduct.Text = "Show All"
        Me.btnShowAllProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowAllProduct.UseVisualStyleBackColor = True
        '
        'btnSeachProductCode
        '
        Me.btnSeachProductCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeachProductCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeachProductCode.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeachProductCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeachProductCode.Location = New System.Drawing.Point(144, 195)
        Me.btnSeachProductCode.Name = "btnSeachProductCode"
        Me.btnSeachProductCode.Size = New System.Drawing.Size(133, 35)
        Me.btnSeachProductCode.TabIndex = 2
        Me.btnSeachProductCode.TabStop = False
        Me.btnSeachProductCode.Text = "Search Product"
        Me.btnSeachProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeachProductCode.UseVisualStyleBackColor = True
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(144, 139)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(311, 32)
        Me.txtProductName.TabIndex = 1
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(29, 145)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(109, 19)
        Me.lblProductName.TabIndex = 10
        Me.lblProductName.Text = "Product Name"
        '
        'dgvProductSeach
        '
        Me.dgvProductSeach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductSeach.Location = New System.Drawing.Point(12, 246)
        Me.dgvProductSeach.Name = "dgvProductSeach"
        Me.dgvProductSeach.Size = New System.Drawing.Size(472, 168)
        Me.dgvProductSeach.TabIndex = 15
        '
        'frmProductSeach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 426)
        Me.Controls.Add(Me.dgvProductSeach)
        Me.Controls.Add(Me.ptbProduct)
        Me.Controls.Add(Me.btnShowAllProduct)
        Me.Controls.Add(Me.btnSeachProductCode)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblProductName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductSeach"
        Me.Text = "Product Seach"
        CType(Me.ptbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductSeach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbProduct As System.Windows.Forms.PictureBox
    Friend WithEvents btnShowAllProduct As System.Windows.Forms.Button
    Friend WithEvents btnSeachProductCode As System.Windows.Forms.Button
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents dgvProductSeach As System.Windows.Forms.DataGridView
End Class
