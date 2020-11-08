<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStock
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
        Me.GbxAddStock = New System.Windows.Forms.GroupBox()
        Me.BtnAddStock = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.NudPricePerUnit = New System.Windows.Forms.NumericUpDown()
        Me.NudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxItem = New System.Windows.Forms.TextBox()
        Me.GbxAddStock.SuspendLayout()
        CType(Me.NudPricePerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxAddStock
        '
        Me.GbxAddStock.Controls.Add(Me.BtnAddStock)
        Me.GbxAddStock.Controls.Add(Me.BtnCancel)
        Me.GbxAddStock.Controls.Add(Me.NudPricePerUnit)
        Me.GbxAddStock.Controls.Add(Me.NudQuantity)
        Me.GbxAddStock.Controls.Add(Me.Label3)
        Me.GbxAddStock.Controls.Add(Me.Label2)
        Me.GbxAddStock.Controls.Add(Me.Label1)
        Me.GbxAddStock.Controls.Add(Me.TbxItem)
        Me.GbxAddStock.Location = New System.Drawing.Point(13, 13)
        Me.GbxAddStock.Name = "GbxAddStock"
        Me.GbxAddStock.Size = New System.Drawing.Size(370, 100)
        Me.GbxAddStock.TabIndex = 0
        Me.GbxAddStock.TabStop = False
        Me.GbxAddStock.Text = "Add Stock"
        '
        'BtnAddStock
        '
        Me.BtnAddStock.Location = New System.Drawing.Point(87, 66)
        Me.BtnAddStock.Name = "BtnAddStock"
        Me.BtnAddStock.Size = New System.Drawing.Size(277, 23)
        Me.BtnAddStock.TabIndex = 4
        Me.BtnAddStock.Text = "Add Stock"
        Me.BtnAddStock.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(6, 66)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'NudPricePerUnit
        '
        Me.NudPricePerUnit.DecimalPlaces = 2
        Me.NudPricePerUnit.Location = New System.Drawing.Point(258, 40)
        Me.NudPricePerUnit.Name = "NudPricePerUnit"
        Me.NudPricePerUnit.Size = New System.Drawing.Size(106, 20)
        Me.NudPricePerUnit.TabIndex = 2
        '
        'NudQuantity
        '
        Me.NudQuantity.Location = New System.Drawing.Point(68, 40)
        Me.NudQuantity.Name = "NudQuantity"
        Me.NudQuantity.Size = New System.Drawing.Size(100, 20)
        Me.NudQuantity.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Price Per Unit: £"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item:"
        '
        'TbxItem
        '
        Me.TbxItem.Location = New System.Drawing.Point(68, 14)
        Me.TbxItem.Name = "TbxItem"
        Me.TbxItem.Size = New System.Drawing.Size(296, 20)
        Me.TbxItem.TabIndex = 0
        '
        'AddStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 123)
        Me.Controls.Add(Me.GbxAddStock)
        Me.Name = "AddStock"
        Me.Text = "Add Stock"
        Me.GbxAddStock.ResumeLayout(False)
        Me.GbxAddStock.PerformLayout()
        CType(Me.NudPricePerUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxAddStock As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxItem As System.Windows.Forms.TextBox
    Friend WithEvents NudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NudPricePerUnit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAddStock As System.Windows.Forms.Button
End Class
