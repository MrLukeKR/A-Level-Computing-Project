<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditOrder
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
        Me.GbxEditOrder = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.RtbOrderDetails = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbxOrderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbxFindOrder.SuspendLayout()
        Me.GbxEditOrder.SuspendLayout()
        CType(Me.NudUserPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudServingSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxFindOrder
        '
        Me.GbxFindOrder.Controls.Add(Me.Label1)
        Me.GbxFindOrder.Controls.Add(Me.TbxNameSearch)
        Me.GbxFindOrder.Controls.Add(Me.BtnSearchCustomer)
        Me.GbxFindOrder.Controls.Add(Me.LbxSelectCustomer)
        Me.GbxFindOrder.Controls.Add(Me.LbxSelectOrder)
        Me.GbxFindOrder.Location = New System.Drawing.Point(13, 13)
        Me.GbxFindOrder.Name = "GbxFindOrder"
        Me.GbxFindOrder.Size = New System.Drawing.Size(546, 140)
        Me.GbxFindOrder.TabIndex = 0
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
        'GbxEditOrder
        '
        Me.GbxEditOrder.Controls.Add(Me.BtnCancel)
        Me.GbxEditOrder.Controls.Add(Me.Button1)
        Me.GbxEditOrder.Controls.Add(Me.RdbPickup)
        Me.GbxEditOrder.Controls.Add(Me.RdbDelivery)
        Me.GbxEditOrder.Controls.Add(Me.NudUserPrice)
        Me.GbxEditOrder.Controls.Add(Me.BtnGenerateEstimate)
        Me.GbxEditOrder.Controls.Add(Me.BtnUseRecommendedPrice)
        Me.GbxEditOrder.Controls.Add(Me.Label12)
        Me.GbxEditOrder.Controls.Add(Me.TbxVat)
        Me.GbxEditOrder.Controls.Add(Me.Label11)
        Me.GbxEditOrder.Controls.Add(Me.DtpDeadline)
        Me.GbxEditOrder.Controls.Add(Me.Label10)
        Me.GbxEditOrder.Controls.Add(Me.Label9)
        Me.GbxEditOrder.Controls.Add(Me.RtbConsiderations)
        Me.GbxEditOrder.Controls.Add(Me.Label8)
        Me.GbxEditOrder.Controls.Add(Me.TbxDeposit)
        Me.GbxEditOrder.Controls.Add(Me.Label7)
        Me.GbxEditOrder.Controls.Add(Me.TbxRecommendedPrice)
        Me.GbxEditOrder.Controls.Add(Me.Label6)
        Me.GbxEditOrder.Controls.Add(Me.TbxTotal)
        Me.GbxEditOrder.Controls.Add(Me.Label5)
        Me.GbxEditOrder.Controls.Add(Me.NudServingSize)
        Me.GbxEditOrder.Controls.Add(Me.RtbOrderDetails)
        Me.GbxEditOrder.Controls.Add(Me.Label3)
        Me.GbxEditOrder.Controls.Add(Me.TbxOrderID)
        Me.GbxEditOrder.Controls.Add(Me.Label2)
        Me.GbxEditOrder.Location = New System.Drawing.Point(13, 160)
        Me.GbxEditOrder.Name = "GbxEditOrder"
        Me.GbxEditOrder.Size = New System.Drawing.Size(546, 353)
        Me.GbxEditOrder.TabIndex = 1
        Me.GbxEditOrder.TabStop = False
        Me.GbxEditOrder.Text = "Edit Order"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(6, 324)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(107, 23)
        Me.BtnCancel.TabIndex = 45
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(421, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Update Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RdbPickup
        '
        Me.RdbPickup.AutoSize = True
        Me.RdbPickup.Checked = True
        Me.RdbPickup.Location = New System.Drawing.Point(319, 123)
        Me.RdbPickup.Name = "RdbPickup"
        Me.RdbPickup.Size = New System.Drawing.Size(63, 17)
        Me.RdbPickup.TabIndex = 42
        Me.RdbPickup.TabStop = True
        Me.RdbPickup.Text = "Pick-Up"
        Me.RdbPickup.UseVisualStyleBackColor = True
        '
        'RdbDelivery
        '
        Me.RdbDelivery.AutoSize = True
        Me.RdbDelivery.Location = New System.Drawing.Point(250, 123)
        Me.RdbDelivery.Name = "RdbDelivery"
        Me.RdbDelivery.Size = New System.Drawing.Size(63, 17)
        Me.RdbDelivery.TabIndex = 43
        Me.RdbDelivery.TabStop = True
        Me.RdbDelivery.Text = "Delivery"
        Me.RdbDelivery.UseVisualStyleBackColor = True
        '
        'NudUserPrice
        '
        Me.NudUserPrice.DecimalPlaces = 2
        Me.NudUserPrice.Location = New System.Drawing.Point(119, 278)
        Me.NudUserPrice.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudUserPrice.Name = "NudUserPrice"
        Me.NudUserPrice.Size = New System.Drawing.Size(102, 20)
        Me.NudUserPrice.TabIndex = 41
        '
        'BtnGenerateEstimate
        '
        Me.BtnGenerateEstimate.Location = New System.Drawing.Point(227, 251)
        Me.BtnGenerateEstimate.Name = "BtnGenerateEstimate"
        Me.BtnGenerateEstimate.Size = New System.Drawing.Size(131, 22)
        Me.BtnGenerateEstimate.TabIndex = 39
        Me.BtnGenerateEstimate.Text = "Generate Estimate"
        Me.BtnGenerateEstimate.UseVisualStyleBackColor = True
        '
        'BtnUseRecommendedPrice
        '
        Me.BtnUseRecommendedPrice.Enabled = False
        Me.BtnUseRecommendedPrice.Location = New System.Drawing.Point(227, 276)
        Me.BtnUseRecommendedPrice.Name = "BtnUseRecommendedPrice"
        Me.BtnUseRecommendedPrice.Size = New System.Drawing.Size(131, 23)
        Me.BtnUseRecommendedPrice.TabIndex = 40
        Me.BtnUseRecommendedPrice.Text = "Use recommended price"
        Me.BtnUseRecommendedPrice.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "VAT:"
        '
        'TbxVat
        '
        Me.TbxVat.Location = New System.Drawing.Point(434, 231)
        Me.TbxVat.Name = "TbxVat"
        Me.TbxVat.ReadOnly = True
        Me.TbxVat.Size = New System.Drawing.Size(102, 20)
        Me.TbxVat.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Enter a price: £"
        '
        'DtpDeadline
        '
        Me.DtpDeadline.Location = New System.Drawing.Point(104, 207)
        Me.DtpDeadline.Name = "DtpDeadline"
        Me.DtpDeadline.Size = New System.Drawing.Size(432, 20)
        Me.DtpDeadline.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Deadline:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Considerations:"
        '
        'RtbConsiderations
        '
        Me.RtbConsiderations.Location = New System.Drawing.Point(103, 149)
        Me.RtbConsiderations.Name = "RtbConsiderations"
        Me.RtbConsiderations.Size = New System.Drawing.Size(433, 51)
        Me.RtbConsiderations.TabIndex = 32
        Me.RtbConsiderations.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Deposit:"
        '
        'TbxDeposit
        '
        Me.TbxDeposit.Location = New System.Drawing.Point(434, 257)
        Me.TbxDeposit.Name = "TbxDeposit"
        Me.TbxDeposit.ReadOnly = True
        Me.TbxDeposit.Size = New System.Drawing.Size(102, 20)
        Me.TbxDeposit.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Recommended Price:"
        '
        'TbxRecommendedPrice
        '
        Me.TbxRecommendedPrice.Location = New System.Drawing.Point(119, 253)
        Me.TbxRecommendedPrice.Name = "TbxRecommendedPrice"
        Me.TbxRecommendedPrice.ReadOnly = True
        Me.TbxRecommendedPrice.Size = New System.Drawing.Size(102, 20)
        Me.TbxRecommendedPrice.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(394, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total:"
        '
        'TbxTotal
        '
        Me.TbxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxTotal.Location = New System.Drawing.Point(434, 283)
        Me.TbxTotal.Name = "TbxTotal"
        Me.TbxTotal.ReadOnly = True
        Me.TbxTotal.Size = New System.Drawing.Size(102, 20)
        Me.TbxTotal.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Serving Size:"
        '
        'NudServingSize
        '
        Me.NudServingSize.Location = New System.Drawing.Point(103, 123)
        Me.NudServingSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudServingSize.Name = "NudServingSize"
        Me.NudServingSize.Size = New System.Drawing.Size(118, 20)
        Me.NudServingSize.TabIndex = 25
        '
        'RtbOrderDetails
        '
        Me.RtbOrderDetails.Location = New System.Drawing.Point(85, 44)
        Me.RtbOrderDetails.Name = "RtbOrderDetails"
        Me.RtbOrderDetails.Size = New System.Drawing.Size(452, 65)
        Me.RtbOrderDetails.TabIndex = 2
        Me.RtbOrderDetails.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Order Details:"
        '
        'TbxOrderID
        '
        Me.TbxOrderID.Location = New System.Drawing.Point(85, 17)
        Me.TbxOrderID.Name = "TbxOrderID"
        Me.TbxOrderID.ReadOnly = True
        Me.TbxOrderID.Size = New System.Drawing.Size(100, 20)
        Me.TbxOrderID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Order ID:"
        '
        'EditOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 525)
        Me.Controls.Add(Me.GbxEditOrder)
        Me.Controls.Add(Me.GbxFindOrder)
        Me.Name = "EditOrder"
        Me.Text = "Edit Order"
        Me.GbxFindOrder.ResumeLayout(False)
        Me.GbxFindOrder.PerformLayout()
        Me.GbxEditOrder.ResumeLayout(False)
        Me.GbxEditOrder.PerformLayout()
        CType(Me.NudUserPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudServingSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxFindOrder As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents LbxSelectOrder As System.Windows.Forms.ListBox
    Friend WithEvents LbxSelectCustomer As System.Windows.Forms.ListBox
    Friend WithEvents GbxEditOrder As System.Windows.Forms.GroupBox
    Friend WithEvents TbxOrderID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RtbOrderDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RdbPickup As System.Windows.Forms.RadioButton
    Friend WithEvents RdbDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents NudUserPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnGenerateEstimate As System.Windows.Forms.Button
    Friend WithEvents BtnUseRecommendedPrice As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DtpDeadline As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RtbConsiderations As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TbxRecommendedPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NudServingSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TbxVat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbxDeposit As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
