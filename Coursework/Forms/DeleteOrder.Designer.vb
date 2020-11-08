<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteOrder
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
        Me.GbxFindOrder = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxNameSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.LbxSelectCustomer = New System.Windows.Forms.ListBox()
        Me.LbxSelectOrder = New System.Windows.Forms.ListBox()
        Me.GbxDelete = New System.Windows.Forms.GroupBox()
        Me.TbxConfirmDeletion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDeleteOrder = New System.Windows.Forms.Button()
        Me.GbxFindOrder.SuspendLayout()
        Me.GbxDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxFindOrder
        '
        Me.GbxFindOrder.Controls.Add(Me.Label1)
        Me.GbxFindOrder.Controls.Add(Me.TbxNameSearch)
        Me.GbxFindOrder.Controls.Add(Me.BtnSearchCustomer)
        Me.GbxFindOrder.Controls.Add(Me.LbxSelectCustomer)
        Me.GbxFindOrder.Controls.Add(Me.LbxSelectOrder)
        Me.GbxFindOrder.Location = New System.Drawing.Point(12, 12)
        Me.GbxFindOrder.Name = "GbxFindOrder"
        Me.GbxFindOrder.Size = New System.Drawing.Size(546, 140)
        Me.GbxFindOrder.TabIndex = 1
        Me.GbxFindOrder.TabStop = False
        Me.GbxFindOrder.Text = "Find Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Customer Surname:"
        '
        'TbxNameSearch
        '
        Me.TbxNameSearch.Location = New System.Drawing.Point(110, 16)
        Me.TbxNameSearch.Name = "TbxNameSearch"
        Me.TbxNameSearch.Size = New System.Drawing.Size(346, 20)
        Me.TbxNameSearch.TabIndex = 6
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(462, 14)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchCustomer.TabIndex = 5
        Me.BtnSearchCustomer.Text = "Search"
        Me.BtnSearchCustomer.UseVisualStyleBackColor = True
        '
        'LbxSelectCustomer
        '
        Me.LbxSelectCustomer.FormattingEnabled = True
        Me.LbxSelectCustomer.Location = New System.Drawing.Point(8, 43)
        Me.LbxSelectCustomer.Name = "LbxSelectCustomer"
        Me.LbxSelectCustomer.Size = New System.Drawing.Size(529, 43)
        Me.LbxSelectCustomer.TabIndex = 4
        '
        'LbxSelectOrder
        '
        Me.LbxSelectOrder.FormattingEnabled = True
        Me.LbxSelectOrder.Location = New System.Drawing.Point(8, 91)
        Me.LbxSelectOrder.Name = "LbxSelectOrder"
        Me.LbxSelectOrder.Size = New System.Drawing.Size(529, 43)
        Me.LbxSelectOrder.TabIndex = 4
        '
        'GbxDelete
        '
        Me.GbxDelete.Controls.Add(Me.TbxConfirmDeletion)
        Me.GbxDelete.Controls.Add(Me.Label2)
        Me.GbxDelete.Controls.Add(Me.BtnCancel)
        Me.GbxDelete.Controls.Add(Me.BtnDeleteOrder)
        Me.GbxDelete.Location = New System.Drawing.Point(12, 158)
        Me.GbxDelete.Name = "GbxDelete"
        Me.GbxDelete.Size = New System.Drawing.Size(547, 81)
        Me.GbxDelete.TabIndex = 6
        Me.GbxDelete.TabStop = False
        Me.GbxDelete.Text = "Delete Order"
        '
        'TbxConfirmDeletion
        '
        Me.TbxConfirmDeletion.Location = New System.Drawing.Point(247, 13)
        Me.TbxConfirmDeletion.Name = "TbxConfirmDeletion"
        Me.TbxConfirmDeletion.Size = New System.Drawing.Size(291, 20)
        Me.TbxConfirmDeletion.TabIndex = 6
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
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(7, 39)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(166, 32)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDeleteOrder
        '
        Me.BtnDeleteOrder.Enabled = False
        Me.BtnDeleteOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteOrder.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteOrder.Location = New System.Drawing.Point(179, 39)
        Me.BtnDeleteOrder.Name = "BtnDeleteOrder"
        Me.BtnDeleteOrder.Size = New System.Drawing.Size(360, 32)
        Me.BtnDeleteOrder.TabIndex = 3
        Me.BtnDeleteOrder.Text = "DELETE order"
        Me.BtnDeleteOrder.UseVisualStyleBackColor = True
        '
        'DeleteOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 245)
        Me.Controls.Add(Me.GbxDelete)
        Me.Controls.Add(Me.GbxFindOrder)
        Me.Name = "DeleteOrder"
        Me.Text = "Delete Order"
        Me.GbxFindOrder.ResumeLayout(False)
        Me.GbxFindOrder.PerformLayout()
        Me.GbxDelete.ResumeLayout(False)
        Me.GbxDelete.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxFindOrder As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents LbxSelectCustomer As System.Windows.Forms.ListBox
    Friend WithEvents LbxSelectOrder As System.Windows.Forms.ListBox
    Friend WithEvents GbxDelete As System.Windows.Forms.GroupBox
    Friend WithEvents TbxConfirmDeletion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteOrder As System.Windows.Forms.Button
End Class
