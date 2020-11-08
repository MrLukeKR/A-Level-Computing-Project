<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStock
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
        Me.GbxFindStock = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxItemSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.LbxSelectStock = New System.Windows.Forms.ListBox()
        Me.GbxEditStock = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbxStockID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NudPricePerUnit = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxItemName = New System.Windows.Forms.TextBox()
        Me.BtnUpdateStock = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GbxFindStock.SuspendLayout()
        Me.GbxEditStock.SuspendLayout()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudPricePerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxFindStock
        '
        Me.GbxFindStock.Controls.Add(Me.Label1)
        Me.GbxFindStock.Controls.Add(Me.TbxItemSearch)
        Me.GbxFindStock.Controls.Add(Me.BtnSearchCustomer)
        Me.GbxFindStock.Controls.Add(Me.LbxSelectStock)
        Me.GbxFindStock.Location = New System.Drawing.Point(12, 12)
        Me.GbxFindStock.Name = "GbxFindStock"
        Me.GbxFindStock.Size = New System.Drawing.Size(544, 106)
        Me.GbxFindStock.TabIndex = 1
        Me.GbxFindStock.TabStop = False
        Me.GbxFindStock.Text = "Find Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item:"
        '
        'TbxItemSearch
        '
        Me.TbxItemSearch.Location = New System.Drawing.Point(42, 21)
        Me.TbxItemSearch.Name = "TbxItemSearch"
        Me.TbxItemSearch.Size = New System.Drawing.Size(415, 20)
        Me.TbxItemSearch.TabIndex = 2
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(463, 19)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchCustomer.TabIndex = 1
        Me.BtnSearchCustomer.Text = "Search"
        Me.BtnSearchCustomer.UseVisualStyleBackColor = True
        '
        'LbxSelectStock
        '
        Me.LbxSelectStock.FormattingEnabled = True
        Me.LbxSelectStock.Location = New System.Drawing.Point(7, 48)
        Me.LbxSelectStock.Name = "LbxSelectStock"
        Me.LbxSelectStock.Size = New System.Drawing.Size(531, 43)
        Me.LbxSelectStock.TabIndex = 0
        '
        'GbxEditStock
        '
        Me.GbxEditStock.Controls.Add(Me.BtnCancel)
        Me.GbxEditStock.Controls.Add(Me.BtnUpdateStock)
        Me.GbxEditStock.Controls.Add(Me.TbxItemName)
        Me.GbxEditStock.Controls.Add(Me.Label4)
        Me.GbxEditStock.Controls.Add(Me.Label3)
        Me.GbxEditStock.Controls.Add(Me.NudPricePerUnit)
        Me.GbxEditStock.Controls.Add(Me.Label5)
        Me.GbxEditStock.Controls.Add(Me.NudQuantity)
        Me.GbxEditStock.Controls.Add(Me.Label2)
        Me.GbxEditStock.Controls.Add(Me.TbxStockID)
        Me.GbxEditStock.Location = New System.Drawing.Point(12, 124)
        Me.GbxEditStock.Name = "GbxEditStock"
        Me.GbxEditStock.Size = New System.Drawing.Size(544, 99)
        Me.GbxEditStock.TabIndex = 2
        Me.GbxEditStock.TabStop = False
        Me.GbxEditStock.Text = "Edit Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quantity:"
        '
        'NudQuantity
        '
        Me.NudQuantity.Location = New System.Drawing.Point(65, 43)
        Me.NudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudQuantity.Name = "NudQuantity"
        Me.NudQuantity.Size = New System.Drawing.Size(118, 20)
        Me.NudQuantity.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stock ID:"
        '
        'TbxStockID
        '
        Me.TbxStockID.Location = New System.Drawing.Point(65, 17)
        Me.TbxStockID.Name = "TbxStockID"
        Me.TbxStockID.ReadOnly = True
        Me.TbxStockID.Size = New System.Drawing.Size(118, 20)
        Me.TbxStockID.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price Per Unit: £"
        '
        'NudPricePerUnit
        '
        Me.NudPricePerUnit.DecimalPlaces = 2
        Me.NudPricePerUnit.Location = New System.Drawing.Point(282, 43)
        Me.NudPricePerUnit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudPricePerUnit.Name = "NudPricePerUnit"
        Me.NudPricePerUnit.Size = New System.Drawing.Size(118, 20)
        Me.NudPricePerUnit.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Item Name:"
        '
        'TbxItemName
        '
        Me.TbxItemName.Location = New System.Drawing.Point(279, 17)
        Me.TbxItemName.Name = "TbxItemName"
        Me.TbxItemName.Size = New System.Drawing.Size(259, 20)
        Me.TbxItemName.TabIndex = 9
        '
        'BtnUpdateStock
        '
        Me.BtnUpdateStock.Location = New System.Drawing.Point(134, 69)
        Me.BtnUpdateStock.Name = "BtnUpdateStock"
        Me.BtnUpdateStock.Size = New System.Drawing.Size(404, 23)
        Me.BtnUpdateStock.TabIndex = 10
        Me.BtnUpdateStock.Text = "Update Stock"
        Me.BtnUpdateStock.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(13, 69)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(115, 23)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'EditStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 229)
        Me.Controls.Add(Me.GbxEditStock)
        Me.Controls.Add(Me.GbxFindStock)
        Me.Name = "EditStock"
        Me.Text = "Edit Stock"
        Me.GbxFindStock.ResumeLayout(False)
        Me.GbxFindStock.PerformLayout()
        Me.GbxEditStock.ResumeLayout(False)
        Me.GbxEditStock.PerformLayout()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudPricePerUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxFindStock As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxItemSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents LbxSelectStock As System.Windows.Forms.ListBox
    Friend WithEvents GbxEditStock As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbxStockID As System.Windows.Forms.TextBox
    Friend WithEvents TbxItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NudPricePerUnit As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnUpdateStock As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
