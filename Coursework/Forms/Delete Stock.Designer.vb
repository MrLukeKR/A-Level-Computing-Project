<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteStock
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
        Me.BtnDeleteStock = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GbxDelete = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbxConfirmDeletion = New System.Windows.Forms.TextBox()
        Me.GbxFindStock.SuspendLayout()
        Me.GbxDelete.SuspendLayout()
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
        Me.GbxFindStock.TabIndex = 2
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
        'BtnDeleteStock
        '
        Me.BtnDeleteStock.Enabled = False
        Me.BtnDeleteStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteStock.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteStock.Location = New System.Drawing.Point(179, 39)
        Me.BtnDeleteStock.Name = "BtnDeleteStock"
        Me.BtnDeleteStock.Size = New System.Drawing.Size(360, 32)
        Me.BtnDeleteStock.TabIndex = 3
        Me.BtnDeleteStock.Text = "DELETE STOCK"
        Me.BtnDeleteStock.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(7, 39)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(166, 32)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'GbxDelete
        '
        Me.GbxDelete.Controls.Add(Me.TbxConfirmDeletion)
        Me.GbxDelete.Controls.Add(Me.Label2)
        Me.GbxDelete.Controls.Add(Me.BtnCancel)
        Me.GbxDelete.Controls.Add(Me.BtnDeleteStock)
        Me.GbxDelete.Location = New System.Drawing.Point(12, 124)
        Me.GbxDelete.Name = "GbxDelete"
        Me.GbxDelete.Size = New System.Drawing.Size(544, 81)
        Me.GbxDelete.TabIndex = 5
        Me.GbxDelete.TabStop = False
        Me.GbxDelete.Text = "Delete Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please type CREATEABAKE to confirm deletion:"
        '
        'TbxConfirmDeletion
        '
        Me.TbxConfirmDeletion.Location = New System.Drawing.Point(247, 13)
        Me.TbxConfirmDeletion.Name = "TbxConfirmDeletion"
        Me.TbxConfirmDeletion.Size = New System.Drawing.Size(291, 20)
        Me.TbxConfirmDeletion.TabIndex = 6
        '
        'DeleteStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 213)
        Me.Controls.Add(Me.GbxDelete)
        Me.Controls.Add(Me.GbxFindStock)
        Me.Name = "DeleteStock"
        Me.Text = "Delete Stock"
        Me.GbxFindStock.ResumeLayout(False)
        Me.GbxFindStock.PerformLayout()
        Me.GbxDelete.ResumeLayout(False)
        Me.GbxDelete.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxFindStock As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxItemSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents LbxSelectStock As System.Windows.Forms.ListBox
    Friend WithEvents BtnDeleteStock As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents GbxDelete As System.Windows.Forms.GroupBox
    Friend WithEvents TbxConfirmDeletion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
