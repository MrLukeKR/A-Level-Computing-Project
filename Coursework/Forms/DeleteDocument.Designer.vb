<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteDocument
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
        Me.GbxFindCustomer = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxNameSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchDocument = New System.Windows.Forms.Button()
        Me.LbxSelectDocument = New System.Windows.Forms.ListBox()
        Me.GbxDelete = New System.Windows.Forms.GroupBox()
        Me.TbxConfirmDeletion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDeleteDocument = New System.Windows.Forms.Button()
        Me.GbxFindCustomer.SuspendLayout()
        Me.GbxDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxFindCustomer
        '
        Me.GbxFindCustomer.Controls.Add(Me.Label1)
        Me.GbxFindCustomer.Controls.Add(Me.TbxNameSearch)
        Me.GbxFindCustomer.Controls.Add(Me.BtnSearchDocument)
        Me.GbxFindCustomer.Controls.Add(Me.LbxSelectDocument)
        Me.GbxFindCustomer.Location = New System.Drawing.Point(12, 12)
        Me.GbxFindCustomer.Name = "GbxFindCustomer"
        Me.GbxFindCustomer.Size = New System.Drawing.Size(544, 106)
        Me.GbxFindCustomer.TabIndex = 5
        Me.GbxFindCustomer.TabStop = False
        Me.GbxFindCustomer.Text = "Find Document"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Document Name:"
        '
        'TbxNameSearch
        '
        Me.TbxNameSearch.Location = New System.Drawing.Point(102, 21)
        Me.TbxNameSearch.Name = "TbxNameSearch"
        Me.TbxNameSearch.Size = New System.Drawing.Size(355, 20)
        Me.TbxNameSearch.TabIndex = 2
        '
        'BtnSearchDocument
        '
        Me.BtnSearchDocument.Location = New System.Drawing.Point(463, 19)
        Me.BtnSearchDocument.Name = "BtnSearchDocument"
        Me.BtnSearchDocument.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchDocument.TabIndex = 1
        Me.BtnSearchDocument.Text = "Search"
        Me.BtnSearchDocument.UseVisualStyleBackColor = True
        '
        'LbxSelectDocument
        '
        Me.LbxSelectDocument.FormattingEnabled = True
        Me.LbxSelectDocument.Location = New System.Drawing.Point(7, 48)
        Me.LbxSelectDocument.Name = "LbxSelectDocument"
        Me.LbxSelectDocument.Size = New System.Drawing.Size(531, 43)
        Me.LbxSelectDocument.TabIndex = 0
        '
        'GbxDelete
        '
        Me.GbxDelete.Controls.Add(Me.TbxConfirmDeletion)
        Me.GbxDelete.Controls.Add(Me.Label2)
        Me.GbxDelete.Controls.Add(Me.BtnCancel)
        Me.GbxDelete.Controls.Add(Me.BtnDeleteDocument)
        Me.GbxDelete.Location = New System.Drawing.Point(12, 124)
        Me.GbxDelete.Name = "GbxDelete"
        Me.GbxDelete.Size = New System.Drawing.Size(544, 81)
        Me.GbxDelete.TabIndex = 7
        Me.GbxDelete.TabStop = False
        Me.GbxDelete.Text = "Delete Customer"
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
        'BtnDeleteDocument
        '
        Me.BtnDeleteDocument.Enabled = False
        Me.BtnDeleteDocument.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteDocument.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteDocument.Location = New System.Drawing.Point(179, 39)
        Me.BtnDeleteDocument.Name = "BtnDeleteDocument"
        Me.BtnDeleteDocument.Size = New System.Drawing.Size(360, 32)
        Me.BtnDeleteDocument.TabIndex = 3
        Me.BtnDeleteDocument.Text = "DELETE DOCUMENTS"
        Me.BtnDeleteDocument.UseVisualStyleBackColor = True
        '
        'DeleteDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 211)
        Me.Controls.Add(Me.GbxDelete)
        Me.Controls.Add(Me.GbxFindCustomer)
        Me.Name = "DeleteDocument"
        Me.Text = "Delete Document"
        Me.GbxFindCustomer.ResumeLayout(False)
        Me.GbxFindCustomer.PerformLayout()
        Me.GbxDelete.ResumeLayout(False)
        Me.GbxDelete.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxFindCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchDocument As System.Windows.Forms.Button
    Friend WithEvents LbxSelectDocument As System.Windows.Forms.ListBox
    Friend WithEvents GbxDelete As System.Windows.Forms.GroupBox
    Friend WithEvents TbxConfirmDeletion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteDocument As System.Windows.Forms.Button
End Class
