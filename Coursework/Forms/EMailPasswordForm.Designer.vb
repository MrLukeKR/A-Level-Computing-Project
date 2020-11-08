<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMailPasswordForm
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
        Me.LblEMailUser = New System.Windows.Forms.Label()
        Me.TbxEMailAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxEMailPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblEMailUser
        '
        Me.LblEMailUser.AutoSize = True
        Me.LblEMailUser.Location = New System.Drawing.Point(13, 13)
        Me.LblEMailUser.Name = "LblEMailUser"
        Me.LblEMailUser.Size = New System.Drawing.Size(80, 13)
        Me.LblEMailUser.TabIndex = 0
        Me.LblEMailUser.Text = "E-Mail Address:"
        '
        'TbxEMailAddress
        '
        Me.TbxEMailAddress.Location = New System.Drawing.Point(99, 10)
        Me.TbxEMailAddress.Name = "TbxEMailAddress"
        Me.TbxEMailAddress.ReadOnly = True
        Me.TbxEMailAddress.Size = New System.Drawing.Size(365, 20)
        Me.TbxEMailAddress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "E-Mail Password:"
        '
        'TbxEMailPassword
        '
        Me.TbxEMailPassword.Location = New System.Drawing.Point(99, 38)
        Me.TbxEMailPassword.Name = "TbxEMailPassword"
        Me.TbxEMailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxEMailPassword.Size = New System.Drawing.Size(365, 20)
        Me.TbxEMailPassword.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(365, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(8, 64)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'EMailPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 98)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxEMailPassword)
        Me.Controls.Add(Me.TbxEMailAddress)
        Me.Controls.Add(Me.LblEMailUser)
        Me.Name = "EMailPassword"
        Me.Text = "E-Mail Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblEMailUser As System.Windows.Forms.Label
    Friend WithEvents TbxEMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxEMailPassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
