<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewOrder
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxNameSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.LbxSelectCustomer = New System.Windows.Forms.ListBox()
        Me.GbxOrder = New System.Windows.Forms.GroupBox()
        Me.RdbPickup = New System.Windows.Forms.RadioButton()
        Me.RdbDelivery = New System.Windows.Forms.RadioButton()
        Me.NudUserPrice = New System.Windows.Forms.NumericUpDown()
        Me.BtnGenerateEstimate = New System.Windows.Forms.Button()
        Me.BtnUseRecommendedPrice = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbxVat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtpDeadline = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RtbConsiderations = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxDeposit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbxRecommendedPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NudServingSize = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RtbOrderDescription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbxCustomerSurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbxCustomerID = New System.Windows.Forms.TextBox()
        Me.BtnSaveOrder = New System.Windows.Forms.Button()
        Me.BtnCancelOrder = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GbxOrder.SuspendLayout()
        CType(Me.NudUserPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudServingSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbxNameSearch)
        Me.GroupBox1.Controls.Add(Me.BtnSearchCustomer)
        Me.GroupBox1.Controls.Add(Me.LbxSelectCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
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
        'GbxOrder
        '
        Me.GbxOrder.Controls.Add(Me.RdbPickup)
        Me.GbxOrder.Controls.Add(Me.RdbDelivery)
        Me.GbxOrder.Controls.Add(Me.NudUserPrice)
        Me.GbxOrder.Controls.Add(Me.BtnGenerateEstimate)
        Me.GbxOrder.Controls.Add(Me.BtnUseRecommendedPrice)
        Me.GbxOrder.Controls.Add(Me.Label12)
        Me.GbxOrder.Controls.Add(Me.TbxVat)
        Me.GbxOrder.Controls.Add(Me.Label11)
        Me.GbxOrder.Controls.Add(Me.DtpDeadline)
        Me.GbxOrder.Controls.Add(Me.Label10)
        Me.GbxOrder.Controls.Add(Me.Label9)
        Me.GbxOrder.Controls.Add(Me.RtbConsiderations)
        Me.GbxOrder.Controls.Add(Me.Label8)
        Me.GbxOrder.Controls.Add(Me.TbxDeposit)
        Me.GbxOrder.Controls.Add(Me.Label7)
        Me.GbxOrder.Controls.Add(Me.TbxRecommendedPrice)
        Me.GbxOrder.Controls.Add(Me.Label6)
        Me.GbxOrder.Controls.Add(Me.TbxTotal)
        Me.GbxOrder.Controls.Add(Me.Label5)
        Me.GbxOrder.Controls.Add(Me.NudServingSize)
        Me.GbxOrder.Controls.Add(Me.Label4)
        Me.GbxOrder.Controls.Add(Me.RtbOrderDescription)
        Me.GbxOrder.Controls.Add(Me.Label3)
        Me.GbxOrder.Controls.Add(Me.TbxCustomerSurname)
        Me.GbxOrder.Controls.Add(Me.Label2)
        Me.GbxOrder.Controls.Add(Me.TbxCustomerID)
        Me.GbxOrder.Enabled = False
        Me.GbxOrder.Location = New System.Drawing.Point(13, 126)
        Me.GbxOrder.Name = "GbxOrder"
        Me.GbxOrder.Size = New System.Drawing.Size(544, 335)
        Me.GbxOrder.TabIndex = 1
        Me.GbxOrder.TabStop = False
        Me.GbxOrder.Text = "Order"
        '
        'RdbPickup
        '
        Me.RdbPickup.AutoSize = True
        Me.RdbPickup.Checked = True
        Me.RdbPickup.Location = New System.Drawing.Point(321, 149)
        Me.RdbPickup.Name = "RdbPickup"
        Me.RdbPickup.Size = New System.Drawing.Size(63, 17)
        Me.RdbPickup.TabIndex = 23
        Me.RdbPickup.TabStop = True
        Me.RdbPickup.Text = "Pick-Up"
        Me.RdbPickup.UseVisualStyleBackColor = True
        '
        'RdbDelivery
        '
        Me.RdbDelivery.AutoSize = True
        Me.RdbDelivery.Location = New System.Drawing.Point(252, 149)
        Me.RdbDelivery.Name = "RdbDelivery"
        Me.RdbDelivery.Size = New System.Drawing.Size(63, 17)
        Me.RdbDelivery.TabIndex = 23
        Me.RdbDelivery.TabStop = True
        Me.RdbDelivery.Text = "Delivery"
        Me.RdbDelivery.UseVisualStyleBackColor = True
        '
        'NudUserPrice
        '
        Me.NudUserPrice.DecimalPlaces = 2
        Me.NudUserPrice.Location = New System.Drawing.Point(121, 304)
        Me.NudUserPrice.Name = "NudUserPrice"
        Me.NudUserPrice.Size = New System.Drawing.Size(102, 20)
        Me.NudUserPrice.TabIndex = 22
        '
        'BtnGenerateEstimate
        '
        Me.BtnGenerateEstimate.Location = New System.Drawing.Point(229, 277)
        Me.BtnGenerateEstimate.Name = "BtnGenerateEstimate"
        Me.BtnGenerateEstimate.Size = New System.Drawing.Size(131, 22)
        Me.BtnGenerateEstimate.TabIndex = 21
        Me.BtnGenerateEstimate.Text = "Generate Estimate"
        Me.BtnGenerateEstimate.UseVisualStyleBackColor = True
        '
        'BtnUseRecommendedPrice
        '
        Me.BtnUseRecommendedPrice.Enabled = False
        Me.BtnUseRecommendedPrice.Location = New System.Drawing.Point(229, 302)
        Me.BtnUseRecommendedPrice.Name = "BtnUseRecommendedPrice"
        Me.BtnUseRecommendedPrice.Size = New System.Drawing.Size(131, 23)
        Me.BtnUseRecommendedPrice.TabIndex = 21
        Me.BtnUseRecommendedPrice.Text = "Use recommended price"
        Me.BtnUseRecommendedPrice.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(399, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "VAT:"
        '
        'TbxVat
        '
        Me.TbxVat.Location = New System.Drawing.Point(436, 257)
        Me.TbxVat.Name = "TbxVat"
        Me.TbxVat.ReadOnly = True
        Me.TbxVat.Size = New System.Drawing.Size(102, 20)
        Me.TbxVat.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Enter a price: £"
        '
        'DtpDeadline
        '
        Me.DtpDeadline.Location = New System.Drawing.Point(106, 233)
        Me.DtpDeadline.Name = "DtpDeadline"
        Me.DtpDeadline.Size = New System.Drawing.Size(432, 20)
        Me.DtpDeadline.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Deadline:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Considerations:"
        '
        'RtbConsiderations
        '
        Me.RtbConsiderations.Location = New System.Drawing.Point(105, 175)
        Me.RtbConsiderations.Name = "RtbConsiderations"
        Me.RtbConsiderations.Size = New System.Drawing.Size(433, 51)
        Me.RtbConsiderations.TabIndex = 13
        Me.RtbConsiderations.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Deposit:"
        '
        'TbxDeposit
        '
        Me.TbxDeposit.Location = New System.Drawing.Point(436, 283)
        Me.TbxDeposit.Name = "TbxDeposit"
        Me.TbxDeposit.ReadOnly = True
        Me.TbxDeposit.Size = New System.Drawing.Size(102, 20)
        Me.TbxDeposit.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Recommended Price:"
        '
        'TbxRecommendedPrice
        '
        Me.TbxRecommendedPrice.Location = New System.Drawing.Point(121, 279)
        Me.TbxRecommendedPrice.Name = "TbxRecommendedPrice"
        Me.TbxRecommendedPrice.ReadOnly = True
        Me.TbxRecommendedPrice.Size = New System.Drawing.Size(102, 20)
        Me.TbxRecommendedPrice.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total:"
        '
        'TbxTotal
        '
        Me.TbxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxTotal.Location = New System.Drawing.Point(436, 309)
        Me.TbxTotal.Name = "TbxTotal"
        Me.TbxTotal.ReadOnly = True
        Me.TbxTotal.Size = New System.Drawing.Size(102, 20)
        Me.TbxTotal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Serving Size:"
        '
        'NudServingSize
        '
        Me.NudServingSize.Location = New System.Drawing.Point(105, 149)
        Me.NudServingSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudServingSize.Name = "NudServingSize"
        Me.NudServingSize.Size = New System.Drawing.Size(118, 20)
        Me.NudServingSize.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Order Description:"
        '
        'RtbOrderDescription
        '
        Me.RtbOrderDescription.Location = New System.Drawing.Point(105, 46)
        Me.RtbOrderDescription.Name = "RtbOrderDescription"
        Me.RtbOrderDescription.Size = New System.Drawing.Size(433, 96)
        Me.RtbOrderDescription.TabIndex = 4
        Me.RtbOrderDescription.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Surname:"
        '
        'TbxCustomerSurname
        '
        Me.TbxCustomerSurname.Location = New System.Drawing.Point(252, 16)
        Me.TbxCustomerSurname.Name = "TbxCustomerSurname"
        Me.TbxCustomerSurname.ReadOnly = True
        Me.TbxCustomerSurname.Size = New System.Drawing.Size(286, 20)
        Me.TbxCustomerSurname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer ID:"
        '
        'TbxCustomerID
        '
        Me.TbxCustomerID.Location = New System.Drawing.Point(81, 16)
        Me.TbxCustomerID.Name = "TbxCustomerID"
        Me.TbxCustomerID.ReadOnly = True
        Me.TbxCustomerID.Size = New System.Drawing.Size(60, 20)
        Me.TbxCustomerID.TabIndex = 0
        '
        'BtnSaveOrder
        '
        Me.BtnSaveOrder.Enabled = False
        Me.BtnSaveOrder.Location = New System.Drawing.Point(242, 467)
        Me.BtnSaveOrder.Name = "BtnSaveOrder"
        Me.BtnSaveOrder.Size = New System.Drawing.Size(315, 23)
        Me.BtnSaveOrder.TabIndex = 2
        Me.BtnSaveOrder.Text = "Save Order && Send Invoice"
        Me.BtnSaveOrder.UseVisualStyleBackColor = True
        '
        'BtnCancelOrder
        '
        Me.BtnCancelOrder.Location = New System.Drawing.Point(13, 467)
        Me.BtnCancelOrder.Name = "BtnCancelOrder"
        Me.BtnCancelOrder.Size = New System.Drawing.Size(223, 23)
        Me.BtnCancelOrder.TabIndex = 3
        Me.BtnCancelOrder.Text = "Cancel Order"
        Me.BtnCancelOrder.UseVisualStyleBackColor = True
        '
        'NewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 502)
        Me.Controls.Add(Me.BtnCancelOrder)
        Me.Controls.Add(Me.BtnSaveOrder)
        Me.Controls.Add(Me.GbxOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewOrder"
        Me.Text = "New Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbxOrder.ResumeLayout(False)
        Me.GbxOrder.PerformLayout()
        CType(Me.NudUserPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudServingSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TbxNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents LbxSelectCustomer As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbxOrder As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbxCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbxCustomerSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RtbOrderDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NudServingSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TbxRecommendedPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbxDeposit As System.Windows.Forms.TextBox
    Friend WithEvents RtbConsiderations As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtpDeadline As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TbxVat As System.Windows.Forms.TextBox
    Friend WithEvents BtnUseRecommendedPrice As System.Windows.Forms.Button
    Friend WithEvents NudUserPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents RdbPickup As System.Windows.Forms.RadioButton
    Friend WithEvents RdbDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents BtnGenerateEstimate As System.Windows.Forms.Button
End Class
