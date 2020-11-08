<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderArchive
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
        Me.DgvOrderArchive = New System.Windows.Forms.DataGridView()
        CType(Me.DgvOrderArchive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvOrderArchive
        '
        Me.DgvOrderArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrderArchive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOrderArchive.Location = New System.Drawing.Point(0, 0)
        Me.DgvOrderArchive.Name = "DgvOrderArchive"
        Me.DgvOrderArchive.ReadOnly = True
        Me.DgvOrderArchive.Size = New System.Drawing.Size(632, 420)
        Me.DgvOrderArchive.TabIndex = 0
        '
        'OrderArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 420)
        Me.Controls.Add(Me.DgvOrderArchive)
        Me.Name = "OrderArchive"
        Me.Text = "Order Archive"
        CType(Me.DgvOrderArchive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvOrderArchive As System.Windows.Forms.DataGridView
End Class
