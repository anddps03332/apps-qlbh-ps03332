<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerAndProductInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerAndProductInformation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiUpdateCustomerAndProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptbProduct = New System.Windows.Forms.PictureBox()
        Me.ptbCustomer = New System.Windows.Forms.PictureBox()
        Me.btnSeachProductCode = New System.Windows.Forms.Button()
        Me.btnSeachCustomer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ptbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUpdateCustomerAndProduct, Me.tsmiExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiUpdateCustomerAndProduct
        '
        Me.tsmiUpdateCustomerAndProduct.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCustomer, Me.tsmiProduct})
        Me.tsmiUpdateCustomerAndProduct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiUpdateCustomerAndProduct.ForeColor = System.Drawing.Color.Blue
        Me.tsmiUpdateCustomerAndProduct.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.CP
        Me.tsmiUpdateCustomerAndProduct.Name = "tsmiUpdateCustomerAndProduct"
        Me.tsmiUpdateCustomerAndProduct.Size = New System.Drawing.Size(106, 20)
        Me.tsmiUpdateCustomerAndProduct.Text = "Update Data"
        '
        'tsmiCustomer
        '
        Me.tsmiCustomer.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Customers
        Me.tsmiCustomer.Name = "tsmiCustomer"
        Me.tsmiCustomer.Size = New System.Drawing.Size(152, 22)
        Me.tsmiCustomer.Text = "Customer"
        '
        'tsmiProduct
        '
        Me.tsmiProduct.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Pro
        Me.tsmiProduct.Name = "tsmiProduct"
        Me.tsmiProduct.Size = New System.Drawing.Size(152, 22)
        Me.tsmiProduct.Text = "Product"
        '
        'tsmiExit
        '
        Me.tsmiExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiExit.ForeColor = System.Drawing.Color.Blue
        Me.tsmiExit.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources._Exit
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(56, 20)
        Me.tsmiExit.Text = "Exit"
        '
        'ptbProduct
        '
        Me.ptbProduct.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.LP_0_LEAN_PRODUCTS
        Me.ptbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbProduct.Location = New System.Drawing.Point(417, 101)
        Me.ptbProduct.Name = "ptbProduct"
        Me.ptbProduct.Size = New System.Drawing.Size(150, 138)
        Me.ptbProduct.TabIndex = 13
        Me.ptbProduct.TabStop = False
        '
        'ptbCustomer
        '
        Me.ptbCustomer.BackgroundImage = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Cus
        Me.ptbCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbCustomer.Location = New System.Drawing.Point(238, 121)
        Me.ptbCustomer.Name = "ptbCustomer"
        Me.ptbCustomer.Size = New System.Drawing.Size(100, 100)
        Me.ptbCustomer.TabIndex = 12
        Me.ptbCustomer.TabStop = False
        '
        'btnSeachProductCode
        '
        Me.btnSeachProductCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeachProductCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeachProductCode.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeachProductCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeachProductCode.Location = New System.Drawing.Point(573, 152)
        Me.btnSeachProductCode.Name = "btnSeachProductCode"
        Me.btnSeachProductCode.Size = New System.Drawing.Size(133, 35)
        Me.btnSeachProductCode.TabIndex = 11
        Me.btnSeachProductCode.TabStop = False
        Me.btnSeachProductCode.Text = "Search Product"
        Me.btnSeachProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeachProductCode.UseVisualStyleBackColor = True
        '
        'btnSeachCustomer
        '
        Me.btnSeachCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeachCustomer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeachCustomer.Image = Global.SALE_M_S_ANDDPS03332.My.Resources.Resources.Seach
        Me.btnSeachCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeachCustomer.Location = New System.Drawing.Point(56, 152)
        Me.btnSeachCustomer.Name = "btnSeachCustomer"
        Me.btnSeachCustomer.Size = New System.Drawing.Size(133, 35)
        Me.btnSeachCustomer.TabIndex = 10
        Me.btnSeachCustomer.TabStop = False
        Me.btnSeachCustomer.Text = "Search Customer"
        Me.btnSeachCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeachCustomer.UseVisualStyleBackColor = True
        '
        'frmCustomerAndProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 328)
        Me.Controls.Add(Me.ptbProduct)
        Me.Controls.Add(Me.ptbCustomer)
        Me.Controls.Add(Me.btnSeachProductCode)
        Me.Controls.Add(Me.btnSeachCustomer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCustomerAndProductInformation"
        Me.Text = "Customer and Product Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ptbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiUpdateCustomerAndProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptbProduct As System.Windows.Forms.PictureBox
    Friend WithEvents ptbCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents btnSeachProductCode As System.Windows.Forms.Button
    Friend WithEvents btnSeachCustomer As System.Windows.Forms.Button
End Class
