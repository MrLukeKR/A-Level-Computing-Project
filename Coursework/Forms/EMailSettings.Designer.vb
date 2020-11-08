<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMailSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxEMailAddress = New System.Windows.Forms.TextBox()
        Me.TbxEMailServer = New System.Windows.Forms.TextBox()
        Me.TbxEMailPassword = New System.Windows.Forms.TextBox()
        Me.TbxEMailPort = New System.Windows.Forms.TextBox()
        Me.BtnSaveEMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E-Mail Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "E-Mail Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "E-Mail Port:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "E-Mail Server:"
        '
        'TbxEMailAddress
        '
        Me.TbxEMailAddress.Location = New System.Drawing.Point(107, 6)
        Me.TbxEMailAddress.Name = "TbxEMailAddress"
        Me.TbxEMailAddress.Size = New System.Drawing.Size(381, 20)
        Me.TbxEMailAddress.TabIndex = 1
        '
        'TbxEMailServer
        '
        Me.TbxEMailServer.Location = New System.Drawing.Point(107, 60)
        Me.TbxEMailServer.Name = "TbxEMailServer"
        Me.TbxEMailServer.Size = New System.Drawing.Size(174, 20)
        Me.TbxEMailServer.TabIndex = 1
        '
        'TbxEMailPassword
        '
        Me.TbxEMailPassword.Location = New System.Drawing.Point(107, 31)
        Me.TbxEMailPassword.Name = "TbxEMailPassword"
        Me.TbxEMailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxEMailPassword.Size = New System.Drawing.Size(381, 20)
        Me.TbxEMailPassword.TabIndex = 1
        '
        'TbxEMailPort
        '
        Me.TbxEMailPort.Location = New System.Drawing.Point(107, 84)
        Me.TbxEMailPort.Name = "TbxEMailPort"
        Me.TbxEMailPort.Size = New System.Drawing.Size(73, 20)
        Me.TbxEMailPort.TabIndex = 1
        '
        'BtnSaveEMail
        '
        Me.BtnSaveEMail.Location = New System.Drawing.Point(184, 138)
        Me.BtnSaveEMail.Name = "BtnSaveEMail"
        Me.BtnSaveEMail.Size = New System.Drawing.Size(304, 23)
        Me.BtnSaveEMail.TabIndex = 2
        Me.BtnSaveEMail.Text = "Save E-Mail Settings"
        Me.BtnSaveEMail.UseVisualStyleBackColor = True
        '
        'EMailSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 173)
        Me.Controls.Add(Me.BtnSaveEMail)
        Me.Controls.Add(Me.TbxEMailPassword)
        Me.Controls.Add(Me.TbxEMailPort)
        Me.Controls.Add(Me.TbxEMailServer)
        Me.Controls.Add(Me.TbxEMailAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EMailSettings"
        Me.Text = "E-Mail Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbxEMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TbxEMailServer As System.Windows.Forms.TextBox
    Friend WithEvents TbxEMailPassword As System.Windows.Forms.TextBox
    Friend WithEvents TbxEMailPort As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaveEMail As System.Windows.Forms.Button
End Class
