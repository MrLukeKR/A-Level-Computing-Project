<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnUpdateCustomer = New System.Windows.Forms.Button()
        Me.GbxFindCustomer = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxNameSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.LbxSelectCustomer = New System.Windows.Forms.ListBox()
        Me.GbxEditCustomer = New System.Windows.Forms.GroupBox()
        Me.TbxEMail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbxPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbxPostcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxTown = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbxStreet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxHouse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbxSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxForename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbxCustomerID = New System.Windows.Forms.TextBox()
        Me.GbxFindCustomer.SuspendLayout()
        Me.GbxEditCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(13, 182)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(115, 23)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnUpdateCustomer
        '
        Me.BtnUpdateCustomer.Location = New System.Drawing.Point(134, 182)
        Me.BtnUpdateCustomer.Name = "BtnUpdateCustomer"
        Me.BtnUpdateCustomer.Size = New System.Drawing.Size(404, 23)
        Me.BtnUpdateCustomer.TabIndex = 10
        Me.BtnUpdateCustomer.Text = "Update Customer"
        Me.BtnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'GbxFindCustomer
        '
        Me.GbxFindCustomer.Controls.Add(Me.Label1)
        Me.GbxFindCustomer.Controls.Add(Me.TbxNameSearch)
        Me.GbxFindCustomer.Controls.Add(Me.BtnSearchCustomer)
        Me.GbxFindCustomer.Controls.Add(Me.LbxSelectCustomer)
        Me.GbxFindCustomer.Location = New System.Drawing.Point(12, 12)
        Me.GbxFindCustomer.Name = "GbxFindCustomer"
        Me.GbxFindCustomer.Size = New System.Drawing.Size(544, 106)
        Me.GbxFindCustomer.TabIndex = 3
        Me.GbxFindCustomer.TabStop = False
        Me.GbxFindCustomer.Text = "Find Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Surname:"
        '
        'TbxNameSearch
        '
        Me.TbxNameSearch.Location = New System.Drawing.Point(64, 21)
        Me.TbxNameSearch.Name = "TbxNameSearch"
        Me.TbxNameSearch.Size = New System.Drawing.Size(393, 20)
        Me.TbxNameSearch.TabIndex = 2
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
        'LbxSelectCustomer
        '
        Me.LbxSelectCustomer.FormattingEnabled = True
        Me.LbxSelectCustomer.Location = New System.Drawing.Point(7, 48)
        Me.LbxSelectCustomer.Name = "LbxSelectCustomer"
        Me.LbxSelectCustomer.Size = New System.Drawing.Size(531, 43)
        Me.LbxSelectCustomer.TabIndex = 0
        '
        'GbxEditCustomer
        '
        Me.GbxEditCustomer.Controls.Add(Me.TbxEMail)
        Me.GbxEditCustomer.Controls.Add(Me.Label10)
        Me.GbxEditCustomer.Controls.Add(Me.TbxPhone)
        Me.GbxEditCustomer.Controls.Add(Me.Label9)
        Me.GbxEditCustomer.Controls.Add(Me.TbxPostcode)
        Me.GbxEditCustomer.Controls.Add(Me.Label8)
        Me.GbxEditCustomer.Controls.Add(Me.TbxTown)
        Me.GbxEditCustomer.Controls.Add(Me.Label7)
        Me.GbxEditCustomer.Controls.Add(Me.TbxStreet)
        Me.GbxEditCustomer.Controls.Add(Me.Label6)
        Me.GbxEditCustomer.Controls.Add(Me.TbxHouse)
        Me.GbxEditCustomer.Controls.Add(Me.Label5)
        Me.GbxEditCustomer.Controls.Add(Me.TbxSurname)
        Me.GbxEditCustomer.Controls.Add(Me.Label4)
        Me.GbxEditCustomer.Controls.Add(Me.TbxForename)
        Me.GbxEditCustomer.Controls.Add(Me.Label3)
        Me.GbxEditCustomer.Controls.Add(Me.Label2)
        Me.GbxEditCustomer.Controls.Add(Me.TbxCustomerID)
        Me.GbxEditCustomer.Controls.Add(Me.BtnCancel)
        Me.GbxEditCustomer.Controls.Add(Me.BtnUpdateCustomer)
        Me.GbxEditCustomer.Location = New System.Drawing.Point(12, 124)
        Me.GbxEditCustomer.Name = "GbxEditCustomer"
        Me.GbxEditCustomer.Size = New System.Drawing.Size(544, 211)
        Me.GbxEditCustomer.TabIndex = 4
        Me.GbxEditCustomer.TabStop = False
        Me.GbxEditCustomer.Text = "Edit Customer"
        '
        'TbxEMail
        '
        Me.TbxEMail.Location = New System.Drawing.Point(314, 125)
        Me.TbxEMail.Name = "TbxEMail"
        Me.TbxEMail.Size = New System.Drawing.Size(224, 20)
        Me.TbxEMail.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "E-Mail:"
        '
        'TbxPhone
        '
        Me.TbxPhone.Location = New System.Drawing.Point(84, 125)
        Me.TbxPhone.Name = "TbxPhone"
        Me.TbxPhone.Size = New System.Drawing.Size(169, 20)
        Me.TbxPhone.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Phone:"
        '
        'TbxPostcode
        '
        Me.TbxPostcode.Location = New System.Drawing.Point(404, 99)
        Me.TbxPostcode.Name = "TbxPostcode"
        Me.TbxPostcode.Size = New System.Drawing.Size(134, 20)
        Me.TbxPostcode.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Postcode:"
        '
        'TbxTown
        '
        Me.TbxTown.Location = New System.Drawing.Point(84, 99)
        Me.TbxTown.Name = "TbxTown"
        Me.TbxTown.Size = New System.Drawing.Size(253, 20)
        Me.TbxTown.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Town:"
        '
        'TbxStreet
        '
        Me.TbxStreet.Location = New System.Drawing.Point(236, 73)
        Me.TbxStreet.Name = "TbxStreet"
        Me.TbxStreet.Size = New System.Drawing.Size(302, 20)
        Me.TbxStreet.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Street:"
        '
        'TbxHouse
        '
        Me.TbxHouse.Location = New System.Drawing.Point(84, 73)
        Me.TbxHouse.Name = "TbxHouse"
        Me.TbxHouse.Size = New System.Drawing.Size(91, 20)
        Me.TbxHouse.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "House:"
        '
        'TbxSurname
        '
        Me.TbxSurname.Location = New System.Drawing.Point(314, 47)
        Me.TbxSurname.Name = "TbxSurname"
        Me.TbxSurname.Size = New System.Drawing.Size(224, 20)
        Me.TbxSurname.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Surname:"
        '
        'TbxForename
        '
        Me.TbxForename.Location = New System.Drawing.Point(84, 47)
        Me.TbxForename.Name = "TbxForename"
        Me.TbxForename.Size = New System.Drawing.Size(169, 20)
        Me.TbxForename.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Forename:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer ID:"
        '
        'TbxCustomerID
        '
        Me.TbxCustomerID.Location = New System.Drawing.Point(84, 19)
        Me.TbxCustomerID.Name = "TbxCustomerID"
        Me.TbxCustomerID.ReadOnly = True
        Me.TbxCustomerID.Size = New System.Drawing.Size(60, 20)
        Me.TbxCustomerID.TabIndex = 12
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 341)
        Me.Controls.Add(Me.GbxFindCustomer)
        Me.Controls.Add(Me.GbxEditCustomer)
        Me.Name = "EditCustomer"
        Me.Text = "Edit Customer"
        Me.GbxFindCustomer.ResumeLayout(False)
        Me.GbxFindCustomer.PerformLayout()
        Me.GbxEditCustomer.ResumeLayout(False)
        Me.GbxEditCustomer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateCustomer As System.Windows.Forms.Button
    Friend WithEvents GbxFindCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents LbxSelectCustomer As System.Windows.Forms.ListBox
    Friend WithEvents GbxEditCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbxCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TbxSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbxForename As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbxHouse As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbxStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbxTown As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TbxPostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbxPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbxEMail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
