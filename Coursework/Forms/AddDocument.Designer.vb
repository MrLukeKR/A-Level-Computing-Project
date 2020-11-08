<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDocument
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
        Me.GbxDocumentInformation = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAddDocument = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.TbxDocumentDirectory = New System.Windows.Forms.TextBox()
        Me.TbxDocumentName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GbxDocumentInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxDocumentInformation
        '
        Me.GbxDocumentInformation.Controls.Add(Me.BtnCancel)
        Me.GbxDocumentInformation.Controls.Add(Me.BtnAddDocument)
        Me.GbxDocumentInformation.Controls.Add(Me.BtnBrowse)
        Me.GbxDocumentInformation.Controls.Add(Me.TbxDocumentDirectory)
        Me.GbxDocumentInformation.Controls.Add(Me.TbxDocumentName)
        Me.GbxDocumentInformation.Controls.Add(Me.Label2)
        Me.GbxDocumentInformation.Controls.Add(Me.Label1)
        Me.GbxDocumentInformation.Location = New System.Drawing.Point(12, 12)
        Me.GbxDocumentInformation.Name = "GbxDocumentInformation"
        Me.GbxDocumentInformation.Size = New System.Drawing.Size(478, 103)
        Me.GbxDocumentInformation.TabIndex = 0
        Me.GbxDocumentInformation.TabStop = False
        Me.GbxDocumentInformation.Text = "Document Information"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(10, 69)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(102, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAddDocument
        '
        Me.BtnAddDocument.Location = New System.Drawing.Point(118, 69)
        Me.BtnAddDocument.Name = "BtnAddDocument"
        Me.BtnAddDocument.Size = New System.Drawing.Size(358, 23)
        Me.BtnAddDocument.TabIndex = 5
        Me.BtnAddDocument.Text = "Add Document"
        Me.BtnAddDocument.UseVisualStyleBackColor = True
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(384, 41)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(88, 23)
        Me.BtnBrowse.TabIndex = 3
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'TbxDocumentDirectory
        '
        Me.TbxDocumentDirectory.Location = New System.Drawing.Point(114, 43)
        Me.TbxDocumentDirectory.Name = "TbxDocumentDirectory"
        Me.TbxDocumentDirectory.Size = New System.Drawing.Size(264, 20)
        Me.TbxDocumentDirectory.TabIndex = 2
        '
        'TbxDocumentName
        '
        Me.TbxDocumentName.Location = New System.Drawing.Point(114, 17)
        Me.TbxDocumentName.Name = "TbxDocumentName"
        Me.TbxDocumentName.Size = New System.Drawing.Size(358, 20)
        Me.TbxDocumentName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Document Directory:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Document Name:"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.Filter = "Word Files|*.doc*"
        '
        'AddDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 124)
        Me.Controls.Add(Me.GbxDocumentInformation)
        Me.Name = "AddDocument"
        Me.Text = "Add Document"
        Me.GbxDocumentInformation.ResumeLayout(False)
        Me.GbxDocumentInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxDocumentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxDocumentName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents TbxDocumentDirectory As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnAddDocument As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
