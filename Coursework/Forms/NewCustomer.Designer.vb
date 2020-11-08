<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me.GbxNewCustomer = New System.Windows.Forms.GroupBox()
        Me.GbxAddress = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxForename = New System.Windows.Forms.TextBox()
        Me.TbxTown = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbxSurname = New System.Windows.Forms.TextBox()
        Me.TbxPostcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxHouseNumber = New System.Windows.Forms.TextBox()
        Me.TbxStreet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GbxContactDetails = New System.Windows.Forms.GroupBox()
        Me.TbxEMailAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxContactNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSaveCustomer = New System.Windows.Forms.Button()
        Me.BtnCancelCustomer = New System.Windows.Forms.Button()
        Me.GbxNewCustomer.SuspendLayout()
        Me.GbxAddress.SuspendLayout()
        Me.GbxContactDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxNewCustomer
        '
        Me.GbxNewCustomer.Controls.Add(Me.GbxAddress)
        Me.GbxNewCustomer.Controls.Add(Me.GbxContactDetails)
        Me.GbxNewCustomer.Location = New System.Drawing.Point(13, 13)
        Me.GbxNewCustomer.Name = "GbxNewCustomer"
        Me.GbxNewCustomer.Size = New System.Drawing.Size(551, 211)
        Me.GbxNewCustomer.TabIndex = 0
        Me.GbxNewCustomer.TabStop = False
        Me.GbxNewCustomer.Text = "New Customer"
        '
        'GbxAddress
        '
        Me.GbxAddress.Controls.Add(Me.Label1)
        Me.GbxAddress.Controls.Add(Me.TbxForename)
        Me.GbxAddress.Controls.Add(Me.TbxTown)
        Me.GbxAddress.Controls.Add(Me.Label2)
        Me.GbxAddress.Controls.Add(Me.Label5)
        Me.GbxAddress.Controls.Add(Me.TbxSurname)
        Me.GbxAddress.Controls.Add(Me.TbxPostcode)
        Me.GbxAddress.Controls.Add(Me.Label3)
        Me.GbxAddress.Controls.Add(Me.Label6)
        Me.GbxAddress.Controls.Add(Me.TbxHouseNumber)
        Me.GbxAddress.Controls.Add(Me.TbxStreet)
        Me.GbxAddress.Controls.Add(Me.Label4)
        Me.GbxAddress.Location = New System.Drawing.Point(6, 19)
        Me.GbxAddress.Name = "GbxAddress"
        Me.GbxAddress.Size = New System.Drawing.Size(539, 100)
        Me.GbxAddress.TabIndex = 9
        Me.GbxAddress.TabStop = False
        Me.GbxAddress.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forename:"
        '
        'TbxForename
        '
        Me.TbxForename.Location = New System.Drawing.Point(69, 13)
        Me.TbxForename.Name = "TbxForename"
        Me.TbxForename.Size = New System.Drawing.Size(174, 20)
        Me.TbxForename.TabIndex = 1
        '
        'TbxTown
        '
        Me.TbxTown.Location = New System.Drawing.Point(69, 65)
        Me.TbxTown.Name = "TbxTown"
        Me.TbxTown.Size = New System.Drawing.Size(174, 20)
        Me.TbxTown.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Surname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Town:"
        '
        'TbxSurname
        '
        Me.TbxSurname.Location = New System.Drawing.Point(307, 13)
        Me.TbxSurname.Name = "TbxSurname"
        Me.TbxSurname.Size = New System.Drawing.Size(226, 20)
        Me.TbxSurname.TabIndex = 1
        '
        'TbxPostcode
        '
        Me.TbxPostcode.Location = New System.Drawing.Point(307, 68)
        Me.TbxPostcode.Name = "TbxPostcode"
        Me.TbxPostcode.Size = New System.Drawing.Size(125, 20)
        Me.TbxPostcode.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "House:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Postcode:"
        '
        'TbxHouseNumber
        '
        Me.TbxHouseNumber.Location = New System.Drawing.Point(69, 39)
        Me.TbxHouseNumber.Name = "TbxHouseNumber"
        Me.TbxHouseNumber.Size = New System.Drawing.Size(174, 20)
        Me.TbxHouseNumber.TabIndex = 3
        '
        'TbxStreet
        '
        Me.TbxStreet.Location = New System.Drawing.Point(307, 42)
        Me.TbxStreet.Name = "TbxStreet"
        Me.TbxStreet.Size = New System.Drawing.Size(226, 20)
        Me.TbxStreet.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Street:"
        '
        'GbxContactDetails
        '
        Me.GbxContactDetails.Controls.Add(Me.TbxEMailAddress)
        Me.GbxContactDetails.Controls.Add(Me.Label8)
        Me.GbxContactDetails.Controls.Add(Me.TbxContactNumber)
        Me.GbxContactDetails.Controls.Add(Me.Label7)
        Me.GbxContactDetails.Location = New System.Drawing.Point(6, 125)
        Me.GbxContactDetails.Name = "GbxContactDetails"
        Me.GbxContactDetails.Size = New System.Drawing.Size(539, 79)
        Me.GbxContactDetails.TabIndex = 8
        Me.GbxContactDetails.TabStop = False
        Me.GbxContactDetails.Text = "Contact Details"
        '
        'TbxEMailAddress
        '
        Me.TbxEMailAddress.Location = New System.Drawing.Point(109, 45)
        Me.TbxEMailAddress.Name = "TbxEMailAddress"
        Me.TbxEMailAddress.Size = New System.Drawing.Size(420, 20)
        Me.TbxEMailAddress.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "E-Mail Address:"
        '
        'TbxContactNumber
        '
        Me.TbxContactNumber.Location = New System.Drawing.Point(109, 19)
        Me.TbxContactNumber.Name = "TbxContactNumber"
        Me.TbxContactNumber.Size = New System.Drawing.Size(420, 20)
        Me.TbxContactNumber.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact Number:"
        '
        'BtnSaveCustomer
        '
        Me.BtnSaveCustomer.Location = New System.Drawing.Point(245, 230)
        Me.BtnSaveCustomer.Name = "BtnSaveCustomer"
        Me.BtnSaveCustomer.Size = New System.Drawing.Size(319, 23)
        Me.BtnSaveCustomer.TabIndex = 1
        Me.BtnSaveCustomer.Text = "Save Customer"
        Me.BtnSaveCustomer.UseVisualStyleBackColor = True
        '
        'BtnCancelCustomer
        '
        Me.BtnCancelCustomer.Location = New System.Drawing.Point(13, 230)
        Me.BtnCancelCustomer.Name = "BtnCancelCustomer"
        Me.BtnCancelCustomer.Size = New System.Drawing.Size(226, 23)
        Me.BtnCancelCustomer.TabIndex = 2
        Me.BtnCancelCustomer.Text = "Cancel Customer"
        Me.BtnCancelCustomer.UseVisualStyleBackColor = True
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 258)
        Me.Controls.Add(Me.BtnCancelCustomer)
        Me.Controls.Add(Me.BtnSaveCustomer)
        Me.Controls.Add(Me.GbxNewCustomer)
        Me.Name = "NewCustomer"
        Me.Text = "New Customer"
        Me.GbxNewCustomer.ResumeLayout(False)
        Me.GbxAddress.ResumeLayout(False)
        Me.GbxAddress.PerformLayout()
        Me.GbxContactDetails.ResumeLayout(False)
        Me.GbxContactDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxNewCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSaveCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnCancelCustomer As System.Windows.Forms.Button
    Friend WithEvents TbxSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbxForename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxHouseNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbxStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbxTown As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbxPostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbxContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GbxContactDetails As System.Windows.Forms.GroupBox
    Friend WithEvents TbxEMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GbxAddress As System.Windows.Forms.GroupBox
End Class
