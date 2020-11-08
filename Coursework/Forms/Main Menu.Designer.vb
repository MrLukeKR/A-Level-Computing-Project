<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TssLoadingStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TspLoadingBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SwitchUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsbChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsbLogoutAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderCalendar = New System.Windows.Forms.MonthCalendar()
        Me.LbxCurrentOrders = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbcMainMenu = New System.Windows.Forms.TabControl()
        Me.TbpOrders = New System.Windows.Forms.TabPage()
        Me.GbxOrderDetails = New System.Windows.Forms.GroupBox()
        Me.BtnFullViewOrder = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LblETA = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblLatestStart = New System.Windows.Forms.Label()
        Me.LblDeadline = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.RtbConsiderations = New System.Windows.Forms.RichTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RtbOrderInformation = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnComplete = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DtpCurrentDeadline = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RtbCurrentConsiderations = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NudCurrentServingSize = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RtbCurrentOrderDescription = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEmail = New System.Windows.Forms.Button()
        Me.TbxPostcode = New System.Windows.Forms.TextBox()
        Me.TbxTown = New System.Windows.Forms.TextBox()
        Me.TbxPhone = New System.Windows.Forms.TextBox()
        Me.TbxEmail = New System.Windows.Forms.TextBox()
        Me.TbxSurname = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbxForename = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbpCustomers = New System.Windows.Forms.TabPage()
        Me.GbxCustomerSearch = New System.Windows.Forms.GroupBox()
        Me.BtnSearchCustomer = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnNewCustomer = New System.Windows.Forms.Button()
        Me.TbxSearchSurname = New System.Windows.Forms.TextBox()
        Me.GbxCustomerGrid = New System.Windows.Forms.GroupBox()
        Me.DgvCustomer = New System.Windows.Forms.DataGridView()
        Me.TbpDelivery = New System.Windows.Forms.TabPage()
        Me.GbxRouteLocationOrder = New System.Windows.Forms.GroupBox()
        Me.LbxRouteLocationOrder = New System.Windows.Forms.ListBox()
        Me.GbxCalculationData = New System.Windows.Forms.GroupBox()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.TbxOrigin = New System.Windows.Forms.TextBox()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.RtbDistances = New System.Windows.Forms.RichTextBox()
        Me.GbxRouteInformation = New System.Windows.Forms.GroupBox()
        Me.PcbMapImage = New System.Windows.Forms.PictureBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxEndLocation = New System.Windows.Forms.ComboBox()
        Me.CbxStartLocation = New System.Windows.Forms.ComboBox()
        Me.TbpStock = New System.Windows.Forms.TabPage()
        Me.GbxStock = New System.Windows.Forms.GroupBox()
        Me.DgvStock = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ClbLowStock = New System.Windows.Forms.CheckedListBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BtnPrintShoppingList = New System.Windows.Forms.Button()
        Me.BtnRestock = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnEmailSupplier = New System.Windows.Forms.Button()
        Me.BtnViewSupplierWebsite = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.NudRestockQuantity = New System.Windows.Forms.NumericUpDown()
        Me.ChbxReOrdered = New System.Windows.Forms.CheckBox()
        Me.ChbxDiscrepancy = New System.Windows.Forms.CheckBox()
        Me.TbxStatus = New System.Windows.Forms.TextBox()
        Me.TbxItemCost = New System.Windows.Forms.TextBox()
        Me.TbxItemQuantity = New System.Windows.Forms.TextBox()
        Me.TbxItemName = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbpFinance = New System.Windows.Forms.TabPage()
        Me.GbxOrderFinances = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TbxFullCost = New System.Windows.Forms.TextBox()
        Me.TbxDepositAmount = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.BtnFullyPaid = New System.Windows.Forms.Button()
        Me.BtnDepositPaid = New System.Windows.Forms.Button()
        Me.BtnSendInvoice = New System.Windows.Forms.Button()
        Me.BtnFullViewFinance = New System.Windows.Forms.Button()
        Me.LbxOutstandingPayments = New System.Windows.Forms.ListBox()
        Me.GbxTodaysFinances = New System.Windows.Forms.GroupBox()
        Me.DgvFinances = New System.Windows.Forms.DataGridView()
        Me.TbpDocumentation = New System.Windows.Forms.TabPage()
        Me.GbxDocuments = New System.Windows.Forms.GroupBox()
        Me.GbxDocumentInformation = New System.Windows.Forms.GroupBox()
        Me.BtnViewDocument = New System.Windows.Forms.Button()
        Me.TbxDocumentDirectory = New System.Windows.Forms.TextBox()
        Me.TbxDocumentName = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.BtnPrintDocument = New System.Windows.Forms.Button()
        Me.LbxDocuments = New System.Windows.Forms.ListBox()
        Me.TbpAdmin = New System.Windows.Forms.TabPage()
        Me.GbxAdminPanel = New System.Windows.Forms.GroupBox()
        Me.NudFuelCostPerMile = New System.Windows.Forms.NumericUpDown()
        Me.CbxDeliveryOrigin = New System.Windows.Forms.ComboBox()
        Me.BtnSaveSettings = New System.Windows.Forms.Button()
        Me.GbxStatistics = New System.Windows.Forms.GroupBox()
        Me.BtnRefreshStatistics = New System.Windows.Forms.Button()
        Me.TbxMissedOrders = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TbxTotalLoss = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TbxTotalProfit = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TbxTotalNetProfit = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TbxOrderCount = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TbxCustomerCount = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TbxCostPerServing = New System.Windows.Forms.TextBox()
        Me.TbxDeposit = New System.Windows.Forms.TextBox()
        Me.TbxVAT = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TbxLowStockThreshold = New System.Windows.Forms.TextBox()
        Me.TbxSupplierEmail = New System.Windows.Forms.TextBox()
        Me.TbxSupplierURL = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GbxMultipliers = New System.Windows.Forms.GroupBox()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.TbxFruitMultiplier = New System.Windows.Forms.TextBox()
        Me.TbxChocolateMultiplier = New System.Windows.Forms.TextBox()
        Me.TbxSpongeMultiplier = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GbxSystemControl = New System.Windows.Forms.GroupBox()
        Me.BtnEmailSettings = New System.Windows.Forms.Button()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnEditOrder = New System.Windows.Forms.Button()
        Me.BtnEditCustomer = New System.Windows.Forms.Button()
        Me.BtnEditStock = New System.Windows.Forms.Button()
        Me.BtnDeleteDocument = New System.Windows.Forms.Button()
        Me.BtnDeleteStock = New System.Windows.Forms.Button()
        Me.BtnDocument = New System.Windows.Forms.Button()
        Me.BtnAddStockItem = New System.Windows.Forms.Button()
        Me.BtnEditMap = New System.Windows.Forms.Button()
        Me.BtnDeleteOrder = New System.Windows.Forms.Button()
        Me.BtnDeleteCustomer = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxDatabaseDirectory = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TbcMainMenu.SuspendLayout()
        Me.TbpOrders.SuspendLayout()
        Me.GbxOrderDetails.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NudCurrentServingSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TbpCustomers.SuspendLayout()
        Me.GbxCustomerSearch.SuspendLayout()
        Me.GbxCustomerGrid.SuspendLayout()
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpDelivery.SuspendLayout()
        Me.GbxRouteLocationOrder.SuspendLayout()
        Me.GbxCalculationData.SuspendLayout()
        Me.GbxRouteInformation.SuspendLayout()
        CType(Me.PcbMapImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpStock.SuspendLayout()
        Me.GbxStock.SuspendLayout()
        CType(Me.DgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NudRestockQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpFinance.SuspendLayout()
        Me.GbxOrderFinances.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GbxTodaysFinances.SuspendLayout()
        CType(Me.DgvFinances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpDocumentation.SuspendLayout()
        Me.GbxDocuments.SuspendLayout()
        Me.GbxDocumentInformation.SuspendLayout()
        Me.TbpAdmin.SuspendLayout()
        Me.GbxAdminPanel.SuspendLayout()
        CType(Me.NudFuelCostPerMile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxStatistics.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GbxMultipliers.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GbxSystemControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblUsername, Me.TssLoadingStatus, Me.TspLoadingBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(845, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblUsername
        '
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(71, 17)
        Me.LblUsername.Text = "Default User"
        '
        'TssLoadingStatus
        '
        Me.TssLoadingStatus.Name = "TssLoadingStatus"
        Me.TssLoadingStatus.Size = New System.Drawing.Size(657, 17)
        Me.TssLoadingStatus.Spring = True
        '
        'TspLoadingBar
        '
        Me.TspLoadingBar.Name = "TspLoadingBar"
        Me.TspLoadingBar.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(845, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.NewOrderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewOrderToolStripMenuItem.Text = "New Order"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchUserToolStripMenuItem, Me.TsbChangePassword, Me.TsbLogoutAdmin})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripDropDownButton2.Text = "User"
        '
        'SwitchUserToolStripMenuItem
        '
        Me.SwitchUserToolStripMenuItem.Name = "SwitchUserToolStripMenuItem"
        Me.SwitchUserToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SwitchUserToolStripMenuItem.Text = "Access Admin Rights"
        '
        'TsbChangePassword
        '
        Me.TsbChangePassword.Enabled = False
        Me.TsbChangePassword.Name = "TsbChangePassword"
        Me.TsbChangePassword.Size = New System.Drawing.Size(185, 22)
        Me.TsbChangePassword.Text = "Change Password"
        Me.TsbChangePassword.Visible = False
        '
        'TsbLogoutAdmin
        '
        Me.TsbLogoutAdmin.Enabled = False
        Me.TsbLogoutAdmin.Name = "TsbLogoutAdmin"
        Me.TsbLogoutAdmin.Size = New System.Drawing.Size(185, 22)
        Me.TsbLogoutAdmin.Text = "Logout Admin"
        Me.TsbLogoutAdmin.Visible = False
        '
        'OrderCalendar
        '
        Me.OrderCalendar.Location = New System.Drawing.Point(601, 31)
        Me.OrderCalendar.Name = "OrderCalendar"
        Me.OrderCalendar.TabIndex = 4
        '
        'LbxCurrentOrders
        '
        Me.LbxCurrentOrders.FormattingEnabled = True
        Me.LbxCurrentOrders.Location = New System.Drawing.Point(8, 33)
        Me.LbxCurrentOrders.Name = "LbxCurrentOrders"
        Me.LbxCurrentOrders.Size = New System.Drawing.Size(231, 160)
        Me.LbxCurrentOrders.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Orders"
        '
        'TbcMainMenu
        '
        Me.TbcMainMenu.Controls.Add(Me.TbpOrders)
        Me.TbcMainMenu.Controls.Add(Me.TbpCustomers)
        Me.TbcMainMenu.Controls.Add(Me.TbpDelivery)
        Me.TbcMainMenu.Controls.Add(Me.TbpStock)
        Me.TbcMainMenu.Controls.Add(Me.TbpFinance)
        Me.TbcMainMenu.Controls.Add(Me.TbpDocumentation)
        Me.TbcMainMenu.Controls.Add(Me.TbpAdmin)
        Me.TbcMainMenu.Location = New System.Drawing.Point(0, 28)
        Me.TbcMainMenu.Name = "TbcMainMenu"
        Me.TbcMainMenu.SelectedIndex = 0
        Me.TbcMainMenu.Size = New System.Drawing.Size(845, 514)
        Me.TbcMainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TbcMainMenu.TabIndex = 8
        '
        'TbpOrders
        '
        Me.TbpOrders.Controls.Add(Me.GbxOrderDetails)
        Me.TbpOrders.Controls.Add(Me.GroupBox4)
        Me.TbpOrders.Controls.Add(Me.Label1)
        Me.TbpOrders.Controls.Add(Me.LbxCurrentOrders)
        Me.TbpOrders.Controls.Add(Me.OrderCalendar)
        Me.TbpOrders.Location = New System.Drawing.Point(4, 22)
        Me.TbpOrders.Name = "TbpOrders"
        Me.TbpOrders.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpOrders.Size = New System.Drawing.Size(837, 488)
        Me.TbpOrders.TabIndex = 0
        Me.TbpOrders.Text = "Orders"
        Me.TbpOrders.UseVisualStyleBackColor = True
        '
        'GbxOrderDetails
        '
        Me.GbxOrderDetails.Controls.Add(Me.BtnFullViewOrder)
        Me.GbxOrderDetails.Controls.Add(Me.Label27)
        Me.GbxOrderDetails.Controls.Add(Me.LblETA)
        Me.GbxOrderDetails.Controls.Add(Me.Label23)
        Me.GbxOrderDetails.Controls.Add(Me.LblLatestStart)
        Me.GbxOrderDetails.Controls.Add(Me.LblDeadline)
        Me.GbxOrderDetails.Controls.Add(Me.Label20)
        Me.GbxOrderDetails.Controls.Add(Me.RtbConsiderations)
        Me.GbxOrderDetails.Controls.Add(Me.Label22)
        Me.GbxOrderDetails.Controls.Add(Me.RtbOrderInformation)
        Me.GbxOrderDetails.Controls.Add(Me.Label21)
        Me.GbxOrderDetails.Location = New System.Drawing.Point(245, 31)
        Me.GbxOrderDetails.Name = "GbxOrderDetails"
        Me.GbxOrderDetails.Size = New System.Drawing.Size(344, 160)
        Me.GbxOrderDetails.TabIndex = 7
        Me.GbxOrderDetails.TabStop = False
        Me.GbxOrderDetails.Text = "Selected Order Details"
        '
        'BtnFullViewOrder
        '
        Me.BtnFullViewOrder.Enabled = False
        Me.BtnFullViewOrder.Location = New System.Drawing.Point(263, 126)
        Me.BtnFullViewOrder.Name = "BtnFullViewOrder"
        Me.BtnFullViewOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnFullViewOrder.TabIndex = 11
        Me.BtnFullViewOrder.Text = "Full View"
        Me.BtnFullViewOrder.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(165, 107)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Latest Start:"
        '
        'LblETA
        '
        Me.LblETA.AutoSize = True
        Me.LblETA.Location = New System.Drawing.Point(89, 131)
        Me.LblETA.Name = "LblETA"
        Me.LblETA.Size = New System.Drawing.Size(58, 13)
        Me.LblETA.TabIndex = 9
        Me.LblETA.Text = "ETA Value"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(54, 131)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "ETA:"
        '
        'LblLatestStart
        '
        Me.LblLatestStart.AutoSize = True
        Me.LblLatestStart.Location = New System.Drawing.Point(235, 107)
        Me.LblLatestStart.Name = "LblLatestStart"
        Me.LblLatestStart.Size = New System.Drawing.Size(66, 13)
        Me.LblLatestStart.TabIndex = 7
        Me.LblLatestStart.Text = "Latest Value"
        '
        'LblDeadline
        '
        Me.LblDeadline.AutoSize = True
        Me.LblDeadline.Location = New System.Drawing.Point(89, 107)
        Me.LblDeadline.Name = "LblDeadline"
        Me.LblDeadline.Size = New System.Drawing.Size(79, 13)
        Me.LblDeadline.TabIndex = 7
        Me.LblDeadline.Text = "DD/MM/YYYY"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(33, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Deadline:"
        '
        'RtbConsiderations
        '
        Me.RtbConsiderations.Location = New System.Drawing.Point(92, 62)
        Me.RtbConsiderations.Name = "RtbConsiderations"
        Me.RtbConsiderations.ReadOnly = True
        Me.RtbConsiderations.Size = New System.Drawing.Size(246, 37)
        Me.RtbConsiderations.TabIndex = 5
        Me.RtbConsiderations.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Considerations:"
        '
        'RtbOrderInformation
        '
        Me.RtbOrderInformation.Location = New System.Drawing.Point(92, 19)
        Me.RtbOrderInformation.Name = "RtbOrderInformation"
        Me.RtbOrderInformation.ReadOnly = True
        Me.RtbOrderInformation.Size = New System.Drawing.Size(246, 37)
        Me.RtbOrderInformation.TabIndex = 3
        Me.RtbOrderInformation.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Order:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnComplete)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(8, 199)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(821, 283)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Prioity Order"
        '
        'BtnComplete
        '
        Me.BtnComplete.Location = New System.Drawing.Point(7, 248)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(809, 29)
        Me.BtnComplete.TabIndex = 10
        Me.BtnComplete.Text = "Mark as Complete"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DtpCurrentDeadline)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.RtbCurrentConsiderations)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.NudCurrentServingSize)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.RtbCurrentOrderDescription)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(237, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(578, 222)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Order Details"
        '
        'DtpCurrentDeadline
        '
        Me.DtpCurrentDeadline.CalendarForeColor = System.Drawing.Color.Black
        Me.DtpCurrentDeadline.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.DtpCurrentDeadline.Enabled = False
        Me.DtpCurrentDeadline.Location = New System.Drawing.Point(105, 189)
        Me.DtpCurrentDeadline.Name = "DtpCurrentDeadline"
        Me.DtpCurrentDeadline.Size = New System.Drawing.Size(467, 20)
        Me.DtpCurrentDeadline.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Deadline:"
        '
        'RtbCurrentConsiderations
        '
        Me.RtbCurrentConsiderations.Location = New System.Drawing.Point(105, 113)
        Me.RtbCurrentConsiderations.Name = "RtbCurrentConsiderations"
        Me.RtbCurrentConsiderations.ReadOnly = True
        Me.RtbCurrentConsiderations.Size = New System.Drawing.Size(467, 64)
        Me.RtbCurrentConsiderations.TabIndex = 5
        Me.RtbCurrentConsiderations.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Considerations:"
        '
        'NudCurrentServingSize
        '
        Me.NudCurrentServingSize.Location = New System.Drawing.Point(105, 87)
        Me.NudCurrentServingSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudCurrentServingSize.Name = "NudCurrentServingSize"
        Me.NudCurrentServingSize.ReadOnly = True
        Me.NudCurrentServingSize.Size = New System.Drawing.Size(467, 20)
        Me.NudCurrentServingSize.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Serving Size:"
        '
        'RtbCurrentOrderDescription
        '
        Me.RtbCurrentOrderDescription.Location = New System.Drawing.Point(105, 16)
        Me.RtbCurrentOrderDescription.Name = "RtbCurrentOrderDescription"
        Me.RtbCurrentOrderDescription.ReadOnly = True
        Me.RtbCurrentOrderDescription.Size = New System.Drawing.Size(467, 64)
        Me.RtbCurrentOrderDescription.TabIndex = 1
        Me.RtbCurrentOrderDescription.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Order Description:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEmail)
        Me.GroupBox2.Controls.Add(Me.TbxPostcode)
        Me.GroupBox2.Controls.Add(Me.TbxTown)
        Me.GroupBox2.Controls.Add(Me.TbxPhone)
        Me.GroupBox2.Controls.Add(Me.TbxEmail)
        Me.GroupBox2.Controls.Add(Me.TbxSurname)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TbxForename)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 222)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer"
        '
        'BtnEmail
        '
        Me.BtnEmail.Location = New System.Drawing.Point(6, 173)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(211, 43)
        Me.BtnEmail.TabIndex = 12
        Me.BtnEmail.Text = "Send E-Mail"
        Me.BtnEmail.UseVisualStyleBackColor = True
        '
        'TbxPostcode
        '
        Me.TbxPostcode.Location = New System.Drawing.Point(71, 147)
        Me.TbxPostcode.Name = "TbxPostcode"
        Me.TbxPostcode.ReadOnly = True
        Me.TbxPostcode.Size = New System.Drawing.Size(147, 20)
        Me.TbxPostcode.TabIndex = 11
        '
        'TbxTown
        '
        Me.TbxTown.Location = New System.Drawing.Point(71, 121)
        Me.TbxTown.Name = "TbxTown"
        Me.TbxTown.ReadOnly = True
        Me.TbxTown.Size = New System.Drawing.Size(147, 20)
        Me.TbxTown.TabIndex = 10
        '
        'TbxPhone
        '
        Me.TbxPhone.Location = New System.Drawing.Point(71, 95)
        Me.TbxPhone.Name = "TbxPhone"
        Me.TbxPhone.ReadOnly = True
        Me.TbxPhone.Size = New System.Drawing.Size(147, 20)
        Me.TbxPhone.TabIndex = 9
        '
        'TbxEmail
        '
        Me.TbxEmail.Location = New System.Drawing.Point(71, 69)
        Me.TbxEmail.Name = "TbxEmail"
        Me.TbxEmail.ReadOnly = True
        Me.TbxEmail.Size = New System.Drawing.Size(147, 20)
        Me.TbxEmail.TabIndex = 8
        '
        'TbxSurname
        '
        Me.TbxSurname.Location = New System.Drawing.Point(71, 43)
        Me.TbxSurname.Name = "TbxSurname"
        Me.TbxSurname.ReadOnly = True
        Me.TbxSurname.Size = New System.Drawing.Size(147, 20)
        Me.TbxSurname.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(13, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Surname:"
        '
        'TbxForename
        '
        Me.TbxForename.Location = New System.Drawing.Point(71, 17)
        Me.TbxForename.Name = "TbxForename"
        Me.TbxForename.ReadOnly = True
        Me.TbxForename.Size = New System.Drawing.Size(147, 20)
        Me.TbxForename.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(10, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Postcode:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(28, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Town:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(26, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Phone:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(26, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "E-Mail:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Forename:"
        '
        'TbpCustomers
        '
        Me.TbpCustomers.Controls.Add(Me.GbxCustomerSearch)
        Me.TbpCustomers.Controls.Add(Me.GbxCustomerGrid)
        Me.TbpCustomers.Location = New System.Drawing.Point(4, 22)
        Me.TbpCustomers.Name = "TbpCustomers"
        Me.TbpCustomers.Size = New System.Drawing.Size(837, 488)
        Me.TbpCustomers.TabIndex = 3
        Me.TbpCustomers.Text = "Customers"
        Me.TbpCustomers.UseVisualStyleBackColor = True
        '
        'GbxCustomerSearch
        '
        Me.GbxCustomerSearch.Controls.Add(Me.BtnSearchCustomer)
        Me.GbxCustomerSearch.Controls.Add(Me.Label19)
        Me.GbxCustomerSearch.Controls.Add(Me.BtnNewCustomer)
        Me.GbxCustomerSearch.Controls.Add(Me.TbxSearchSurname)
        Me.GbxCustomerSearch.Location = New System.Drawing.Point(8, 434)
        Me.GbxCustomerSearch.Name = "GbxCustomerSearch"
        Me.GbxCustomerSearch.Size = New System.Drawing.Size(821, 51)
        Me.GbxCustomerSearch.TabIndex = 6
        Me.GbxCustomerSearch.TabStop = False
        Me.GbxCustomerSearch.Text = "Search Customer"
        '
        'BtnSearchCustomer
        '
        Me.BtnSearchCustomer.Location = New System.Drawing.Point(715, 19)
        Me.BtnSearchCustomer.Name = "BtnSearchCustomer"
        Me.BtnSearchCustomer.Size = New System.Drawing.Size(100, 23)
        Me.BtnSearchCustomer.TabIndex = 1
        Me.BtnSearchCustomer.Text = "Search Customer"
        Me.BtnSearchCustomer.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(436, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Surname:"
        '
        'BtnNewCustomer
        '
        Me.BtnNewCustomer.Location = New System.Drawing.Point(6, 19)
        Me.BtnNewCustomer.Name = "BtnNewCustomer"
        Me.BtnNewCustomer.Size = New System.Drawing.Size(92, 23)
        Me.BtnNewCustomer.TabIndex = 2
        Me.BtnNewCustomer.Text = "New Customer"
        Me.BtnNewCustomer.UseVisualStyleBackColor = True
        '
        'TbxSearchSurname
        '
        Me.TbxSearchSurname.Location = New System.Drawing.Point(494, 21)
        Me.TbxSearchSurname.Name = "TbxSearchSurname"
        Me.TbxSearchSurname.Size = New System.Drawing.Size(215, 20)
        Me.TbxSearchSurname.TabIndex = 3
        '
        'GbxCustomerGrid
        '
        Me.GbxCustomerGrid.Controls.Add(Me.DgvCustomer)
        Me.GbxCustomerGrid.Location = New System.Drawing.Point(8, 3)
        Me.GbxCustomerGrid.Name = "GbxCustomerGrid"
        Me.GbxCustomerGrid.Size = New System.Drawing.Size(821, 425)
        Me.GbxCustomerGrid.TabIndex = 5
        Me.GbxCustomerGrid.TabStop = False
        Me.GbxCustomerGrid.Text = "Customers"
        '
        'DgvCustomer
        '
        Me.DgvCustomer.AllowUserToDeleteRows = False
        Me.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomer.Location = New System.Drawing.Point(6, 19)
        Me.DgvCustomer.Name = "DgvCustomer"
        Me.DgvCustomer.ReadOnly = True
        Me.DgvCustomer.Size = New System.Drawing.Size(809, 400)
        Me.DgvCustomer.TabIndex = 0
        '
        'TbpDelivery
        '
        Me.TbpDelivery.Controls.Add(Me.GbxRouteLocationOrder)
        Me.TbpDelivery.Controls.Add(Me.GbxCalculationData)
        Me.TbpDelivery.Controls.Add(Me.GbxRouteInformation)
        Me.TbpDelivery.Controls.Add(Me.BtnCalculate)
        Me.TbpDelivery.Controls.Add(Me.Label4)
        Me.TbpDelivery.Controls.Add(Me.Label3)
        Me.TbpDelivery.Controls.Add(Me.CbxEndLocation)
        Me.TbpDelivery.Controls.Add(Me.CbxStartLocation)
        Me.TbpDelivery.Location = New System.Drawing.Point(4, 22)
        Me.TbpDelivery.Name = "TbpDelivery"
        Me.TbpDelivery.Size = New System.Drawing.Size(837, 488)
        Me.TbpDelivery.TabIndex = 4
        Me.TbpDelivery.Text = "Delivery"
        Me.TbpDelivery.UseVisualStyleBackColor = True
        '
        'GbxRouteLocationOrder
        '
        Me.GbxRouteLocationOrder.Controls.Add(Me.LbxRouteLocationOrder)
        Me.GbxRouteLocationOrder.Location = New System.Drawing.Point(650, 229)
        Me.GbxRouteLocationOrder.Name = "GbxRouteLocationOrder"
        Me.GbxRouteLocationOrder.Size = New System.Drawing.Size(179, 256)
        Me.GbxRouteLocationOrder.TabIndex = 8
        Me.GbxRouteLocationOrder.TabStop = False
        Me.GbxRouteLocationOrder.Text = "Route Location Order"
        '
        'LbxRouteLocationOrder
        '
        Me.LbxRouteLocationOrder.FormattingEnabled = True
        Me.LbxRouteLocationOrder.Location = New System.Drawing.Point(6, 19)
        Me.LbxRouteLocationOrder.Name = "LbxRouteLocationOrder"
        Me.LbxRouteLocationOrder.Size = New System.Drawing.Size(166, 225)
        Me.LbxRouteLocationOrder.TabIndex = 0
        '
        'GbxCalculationData
        '
        Me.GbxCalculationData.Controls.Add(Me.LblTo)
        Me.GbxCalculationData.Controls.Add(Me.TbxOrigin)
        Me.GbxCalculationData.Controls.Add(Me.LblFrom)
        Me.GbxCalculationData.Controls.Add(Me.RtbDistances)
        Me.GbxCalculationData.Location = New System.Drawing.Point(649, 35)
        Me.GbxCalculationData.Name = "GbxCalculationData"
        Me.GbxCalculationData.Size = New System.Drawing.Size(179, 188)
        Me.GbxCalculationData.TabIndex = 7
        Me.GbxCalculationData.TabStop = False
        Me.GbxCalculationData.Text = "Calculation Data"
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(76, 55)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(22, 13)
        Me.LblTo.TabIndex = 3
        Me.LblTo.Text = "TO"
        '
        'TbxOrigin
        '
        Me.TbxOrigin.Location = New System.Drawing.Point(6, 32)
        Me.TbxOrigin.Name = "TbxOrigin"
        Me.TbxOrigin.ReadOnly = True
        Me.TbxOrigin.Size = New System.Drawing.Size(167, 20)
        Me.TbxOrigin.TabIndex = 2
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Location = New System.Drawing.Point(68, 16)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(38, 13)
        Me.LblFrom.TabIndex = 1
        Me.LblFrom.Text = "FROM"
        '
        'RtbDistances
        '
        Me.RtbDistances.Location = New System.Drawing.Point(6, 71)
        Me.RtbDistances.Name = "RtbDistances"
        Me.RtbDistances.ReadOnly = True
        Me.RtbDistances.Size = New System.Drawing.Size(167, 109)
        Me.RtbDistances.TabIndex = 0
        Me.RtbDistances.Text = ""
        '
        'GbxRouteInformation
        '
        Me.GbxRouteInformation.Controls.Add(Me.PcbMapImage)
        Me.GbxRouteInformation.Location = New System.Drawing.Point(11, 34)
        Me.GbxRouteInformation.Name = "GbxRouteInformation"
        Me.GbxRouteInformation.Size = New System.Drawing.Size(631, 451)
        Me.GbxRouteInformation.TabIndex = 6
        Me.GbxRouteInformation.TabStop = False
        Me.GbxRouteInformation.Text = "Map"
        '
        'PcbMapImage
        '
        Me.PcbMapImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PcbMapImage.Location = New System.Drawing.Point(3, 16)
        Me.PcbMapImage.Name = "PcbMapImage"
        Me.PcbMapImage.Size = New System.Drawing.Size(625, 432)
        Me.PcbMapImage.TabIndex = 0
        Me.PcbMapImage.TabStop = False
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(648, 7)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(180, 21)
        Me.BtnCalculate.TabIndex = 3
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "From"
        '
        'CbxEndLocation
        '
        Me.CbxEndLocation.FormattingEnabled = True
        Me.CbxEndLocation.Location = New System.Drawing.Point(357, 7)
        Me.CbxEndLocation.Name = "CbxEndLocation"
        Me.CbxEndLocation.Size = New System.Drawing.Size(285, 21)
        Me.CbxEndLocation.TabIndex = 0
        '
        'CbxStartLocation
        '
        Me.CbxStartLocation.FormattingEnabled = True
        Me.CbxStartLocation.Location = New System.Drawing.Point(44, 7)
        Me.CbxStartLocation.Name = "CbxStartLocation"
        Me.CbxStartLocation.Size = New System.Drawing.Size(285, 21)
        Me.CbxStartLocation.TabIndex = 0
        '
        'TbpStock
        '
        Me.TbpStock.Controls.Add(Me.GbxStock)
        Me.TbpStock.Controls.Add(Me.GroupBox9)
        Me.TbpStock.Location = New System.Drawing.Point(4, 22)
        Me.TbpStock.Name = "TbpStock"
        Me.TbpStock.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpStock.Size = New System.Drawing.Size(837, 488)
        Me.TbpStock.TabIndex = 1
        Me.TbpStock.Text = "Stock"
        Me.TbpStock.UseVisualStyleBackColor = True
        '
        'GbxStock
        '
        Me.GbxStock.Controls.Add(Me.DgvStock)
        Me.GbxStock.Location = New System.Drawing.Point(8, 6)
        Me.GbxStock.Name = "GbxStock"
        Me.GbxStock.Size = New System.Drawing.Size(823, 208)
        Me.GbxStock.TabIndex = 15
        Me.GbxStock.TabStop = False
        Me.GbxStock.Text = "Stock"
        '
        'DgvStock
        '
        Me.DgvStock.AllowUserToDeleteRows = False
        Me.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStock.Location = New System.Drawing.Point(8, 19)
        Me.DgvStock.Name = "DgvStock"
        Me.DgvStock.ReadOnly = True
        Me.DgvStock.Size = New System.Drawing.Size(809, 183)
        Me.DgvStock.TabIndex = 1
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ClbLowStock)
        Me.GroupBox9.Controls.Add(Me.Button7)
        Me.GroupBox9.Controls.Add(Me.BtnPrintShoppingList)
        Me.GroupBox9.Controls.Add(Me.BtnRestock)
        Me.GroupBox9.Controls.Add(Me.Button4)
        Me.GroupBox9.Controls.Add(Me.BtnEmailSupplier)
        Me.GroupBox9.Controls.Add(Me.BtnViewSupplierWebsite)
        Me.GroupBox9.Controls.Add(Me.GroupBox3)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 220)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(825, 265)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Restock"
        '
        'ClbLowStock
        '
        Me.ClbLowStock.FormattingEnabled = True
        Me.ClbLowStock.Location = New System.Drawing.Point(7, 32)
        Me.ClbLowStock.Name = "ClbLowStock"
        Me.ClbLowStock.Size = New System.Drawing.Size(327, 124)
        Me.ClbLowStock.TabIndex = 3
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(180, 162)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(157, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Uncheck All"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BtnPrintShoppingList
        '
        Me.BtnPrintShoppingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintShoppingList.Location = New System.Drawing.Point(424, 191)
        Me.BtnPrintShoppingList.Name = "BtnPrintShoppingList"
        Me.BtnPrintShoppingList.Size = New System.Drawing.Size(395, 36)
        Me.BtnPrintShoppingList.TabIndex = 10
        Me.BtnPrintShoppingList.Text = "Print Shopping List"
        Me.BtnPrintShoppingList.UseVisualStyleBackColor = True
        '
        'BtnRestock
        '
        Me.BtnRestock.Enabled = False
        Me.BtnRestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestock.Location = New System.Drawing.Point(7, 191)
        Me.BtnRestock.Name = "BtnRestock"
        Me.BtnRestock.Size = New System.Drawing.Size(411, 36)
        Me.BtnRestock.TabIndex = 10
        Me.BtnRestock.Text = "Restock"
        Me.BtnRestock.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(7, 162)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Check All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnEmailSupplier
        '
        Me.BtnEmailSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmailSupplier.Location = New System.Drawing.Point(7, 233)
        Me.BtnEmailSupplier.Name = "BtnEmailSupplier"
        Me.BtnEmailSupplier.Size = New System.Drawing.Size(411, 28)
        Me.BtnEmailSupplier.TabIndex = 10
        Me.BtnEmailSupplier.Text = "E-Mail Supplier"
        Me.BtnEmailSupplier.UseVisualStyleBackColor = True
        '
        'BtnViewSupplierWebsite
        '
        Me.BtnViewSupplierWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewSupplierWebsite.Location = New System.Drawing.Point(427, 233)
        Me.BtnViewSupplierWebsite.Name = "BtnViewSupplierWebsite"
        Me.BtnViewSupplierWebsite.Size = New System.Drawing.Size(392, 28)
        Me.BtnViewSupplierWebsite.TabIndex = 10
        Me.BtnViewSupplierWebsite.Text = "View Supplier Website"
        Me.BtnViewSupplierWebsite.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.NudRestockQuantity)
        Me.GroupBox3.Controls.Add(Me.ChbxReOrdered)
        Me.GroupBox3.Controls.Add(Me.ChbxDiscrepancy)
        Me.GroupBox3.Controls.Add(Me.TbxStatus)
        Me.GroupBox3.Controls.Add(Me.TbxItemCost)
        Me.GroupBox3.Controls.Add(Me.TbxItemQuantity)
        Me.GroupBox3.Controls.Add(Me.TbxItemName)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(340, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(479, 153)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Information"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 127)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(92, 13)
        Me.Label46.TabIndex = 17
        Me.Label46.Text = "Restock Quantity:"
        '
        'NudRestockQuantity
        '
        Me.NudRestockQuantity.Location = New System.Drawing.Point(98, 125)
        Me.NudRestockQuantity.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NudRestockQuantity.Name = "NudRestockQuantity"
        Me.NudRestockQuantity.Size = New System.Drawing.Size(133, 20)
        Me.NudRestockQuantity.TabIndex = 16
        '
        'ChbxReOrdered
        '
        Me.ChbxReOrdered.AutoSize = True
        Me.ChbxReOrdered.Enabled = False
        Me.ChbxReOrdered.Location = New System.Drawing.Point(392, 97)
        Me.ChbxReOrdered.Name = "ChbxReOrdered"
        Me.ChbxReOrdered.Size = New System.Drawing.Size(81, 17)
        Me.ChbxReOrdered.TabIndex = 4
        Me.ChbxReOrdered.Text = "Re-Ordered"
        Me.ChbxReOrdered.UseVisualStyleBackColor = True
        '
        'ChbxDiscrepancy
        '
        Me.ChbxDiscrepancy.AutoSize = True
        Me.ChbxDiscrepancy.Location = New System.Drawing.Point(305, 97)
        Me.ChbxDiscrepancy.Name = "ChbxDiscrepancy"
        Me.ChbxDiscrepancy.Size = New System.Drawing.Size(85, 17)
        Me.ChbxDiscrepancy.TabIndex = 4
        Me.ChbxDiscrepancy.Text = "Discrepancy"
        Me.ChbxDiscrepancy.UseVisualStyleBackColor = True
        '
        'TbxStatus
        '
        Me.TbxStatus.Location = New System.Drawing.Point(98, 94)
        Me.TbxStatus.Name = "TbxStatus"
        Me.TbxStatus.ReadOnly = True
        Me.TbxStatus.Size = New System.Drawing.Size(193, 20)
        Me.TbxStatus.TabIndex = 3
        '
        'TbxItemCost
        '
        Me.TbxItemCost.Location = New System.Drawing.Point(98, 68)
        Me.TbxItemCost.Name = "TbxItemCost"
        Me.TbxItemCost.ReadOnly = True
        Me.TbxItemCost.Size = New System.Drawing.Size(375, 20)
        Me.TbxItemCost.TabIndex = 3
        '
        'TbxItemQuantity
        '
        Me.TbxItemQuantity.Location = New System.Drawing.Point(98, 42)
        Me.TbxItemQuantity.Name = "TbxItemQuantity"
        Me.TbxItemQuantity.ReadOnly = True
        Me.TbxItemQuantity.Size = New System.Drawing.Size(375, 20)
        Me.TbxItemQuantity.TabIndex = 3
        '
        'TbxItemName
        '
        Me.TbxItemName.Location = New System.Drawing.Point(98, 16)
        Me.TbxItemName.Name = "TbxItemName"
        Me.TbxItemName.ReadOnly = True
        Me.TbxItemName.Size = New System.Drawing.Size(375, 20)
        Me.TbxItemName.TabIndex = 3
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(52, 97)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 13)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Status:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Item Cost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Item Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Low Stock Levels"
        '
        'TbpFinance
        '
        Me.TbpFinance.Controls.Add(Me.GbxOrderFinances)
        Me.TbpFinance.Controls.Add(Me.GbxTodaysFinances)
        Me.TbpFinance.Location = New System.Drawing.Point(4, 22)
        Me.TbpFinance.Name = "TbpFinance"
        Me.TbpFinance.Size = New System.Drawing.Size(837, 488)
        Me.TbpFinance.TabIndex = 5
        Me.TbpFinance.Text = "Finances"
        Me.TbpFinance.UseVisualStyleBackColor = True
        '
        'GbxOrderFinances
        '
        Me.GbxOrderFinances.Controls.Add(Me.GroupBox10)
        Me.GbxOrderFinances.Controls.Add(Me.LbxOutstandingPayments)
        Me.GbxOrderFinances.Location = New System.Drawing.Point(8, 279)
        Me.GbxOrderFinances.Name = "GbxOrderFinances"
        Me.GbxOrderFinances.Size = New System.Drawing.Size(821, 206)
        Me.GbxOrderFinances.TabIndex = 2
        Me.GbxOrderFinances.TabStop = False
        Me.GbxOrderFinances.Text = "Order Finances"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TbxFullCost)
        Me.GroupBox10.Controls.Add(Me.TbxDepositAmount)
        Me.GroupBox10.Controls.Add(Me.Label45)
        Me.GroupBox10.Controls.Add(Me.Label44)
        Me.GroupBox10.Controls.Add(Me.BtnFullyPaid)
        Me.GroupBox10.Controls.Add(Me.BtnDepositPaid)
        Me.GroupBox10.Controls.Add(Me.BtnSendInvoice)
        Me.GroupBox10.Controls.Add(Me.BtnFullViewFinance)
        Me.GroupBox10.Location = New System.Drawing.Point(243, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(572, 173)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Selected Order Details"
        '
        'TbxFullCost
        '
        Me.TbxFullCost.Location = New System.Drawing.Point(59, 48)
        Me.TbxFullCost.Name = "TbxFullCost"
        Me.TbxFullCost.ReadOnly = True
        Me.TbxFullCost.Size = New System.Drawing.Size(111, 20)
        Me.TbxFullCost.TabIndex = 14
        '
        'TbxDepositAmount
        '
        Me.TbxDepositAmount.Location = New System.Drawing.Point(59, 16)
        Me.TbxDepositAmount.Name = "TbxDepositAmount"
        Me.TbxDepositAmount.ReadOnly = True
        Me.TbxDepositAmount.Size = New System.Drawing.Size(111, 20)
        Me.TbxDepositAmount.TabIndex = 14
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(7, 19)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(46, 13)
        Me.Label45.TabIndex = 13
        Me.Label45.Text = "Deposit:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 51)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(50, 13)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Full Cost:"
        '
        'BtnFullyPaid
        '
        Me.BtnFullyPaid.Enabled = False
        Me.BtnFullyPaid.ForeColor = System.Drawing.Color.Red
        Me.BtnFullyPaid.Location = New System.Drawing.Point(6, 144)
        Me.BtnFullyPaid.Name = "BtnFullyPaid"
        Me.BtnFullyPaid.Size = New System.Drawing.Size(560, 23)
        Me.BtnFullyPaid.TabIndex = 12
        Me.BtnFullyPaid.Text = "Full Payment Received"
        Me.BtnFullyPaid.UseVisualStyleBackColor = True
        '
        'BtnDepositPaid
        '
        Me.BtnDepositPaid.Enabled = False
        Me.BtnDepositPaid.ForeColor = System.Drawing.Color.Red
        Me.BtnDepositPaid.Location = New System.Drawing.Point(6, 115)
        Me.BtnDepositPaid.Name = "BtnDepositPaid"
        Me.BtnDepositPaid.Size = New System.Drawing.Size(560, 23)
        Me.BtnDepositPaid.TabIndex = 12
        Me.BtnDepositPaid.Text = "Deposit Received"
        Me.BtnDepositPaid.UseVisualStyleBackColor = True
        '
        'BtnSendInvoice
        '
        Me.BtnSendInvoice.Location = New System.Drawing.Point(6, 86)
        Me.BtnSendInvoice.Name = "BtnSendInvoice"
        Me.BtnSendInvoice.Size = New System.Drawing.Size(450, 23)
        Me.BtnSendInvoice.TabIndex = 11
        Me.BtnSendInvoice.Text = "Send Reminder Invoice"
        Me.BtnSendInvoice.UseVisualStyleBackColor = True
        '
        'BtnFullViewFinance
        '
        Me.BtnFullViewFinance.Enabled = False
        Me.BtnFullViewFinance.Location = New System.Drawing.Point(462, 86)
        Me.BtnFullViewFinance.Name = "BtnFullViewFinance"
        Me.BtnFullViewFinance.Size = New System.Drawing.Size(104, 23)
        Me.BtnFullViewFinance.TabIndex = 11
        Me.BtnFullViewFinance.Text = "Full View"
        Me.BtnFullViewFinance.UseVisualStyleBackColor = True
        '
        'LbxOutstandingPayments
        '
        Me.LbxOutstandingPayments.FormattingEnabled = True
        Me.LbxOutstandingPayments.Location = New System.Drawing.Point(6, 19)
        Me.LbxOutstandingPayments.Name = "LbxOutstandingPayments"
        Me.LbxOutstandingPayments.Size = New System.Drawing.Size(231, 173)
        Me.LbxOutstandingPayments.TabIndex = 6
        '
        'GbxTodaysFinances
        '
        Me.GbxTodaysFinances.Controls.Add(Me.DgvFinances)
        Me.GbxTodaysFinances.Location = New System.Drawing.Point(8, 3)
        Me.GbxTodaysFinances.Name = "GbxTodaysFinances"
        Me.GbxTodaysFinances.Size = New System.Drawing.Size(821, 270)
        Me.GbxTodaysFinances.TabIndex = 1
        Me.GbxTodaysFinances.TabStop = False
        Me.GbxTodaysFinances.Text = "Today's Finances"
        '
        'DgvFinances
        '
        Me.DgvFinances.AllowUserToAddRows = False
        Me.DgvFinances.AllowUserToDeleteRows = False
        Me.DgvFinances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFinances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFinances.Location = New System.Drawing.Point(6, 19)
        Me.DgvFinances.Name = "DgvFinances"
        Me.DgvFinances.ReadOnly = True
        Me.DgvFinances.Size = New System.Drawing.Size(809, 245)
        Me.DgvFinances.TabIndex = 0
        '
        'TbpDocumentation
        '
        Me.TbpDocumentation.Controls.Add(Me.GbxDocuments)
        Me.TbpDocumentation.Location = New System.Drawing.Point(4, 22)
        Me.TbpDocumentation.Name = "TbpDocumentation"
        Me.TbpDocumentation.Size = New System.Drawing.Size(837, 488)
        Me.TbpDocumentation.TabIndex = 6
        Me.TbpDocumentation.Text = "Documentation"
        Me.TbpDocumentation.UseVisualStyleBackColor = True
        '
        'GbxDocuments
        '
        Me.GbxDocuments.Controls.Add(Me.BtnViewDocument)
        Me.GbxDocuments.Controls.Add(Me.GbxDocumentInformation)
        Me.GbxDocuments.Controls.Add(Me.BtnPrintDocument)
        Me.GbxDocuments.Controls.Add(Me.LbxDocuments)
        Me.GbxDocuments.Location = New System.Drawing.Point(8, 4)
        Me.GbxDocuments.Name = "GbxDocuments"
        Me.GbxDocuments.Size = New System.Drawing.Size(821, 481)
        Me.GbxDocuments.TabIndex = 1
        Me.GbxDocuments.TabStop = False
        Me.GbxDocuments.Text = "Print Document"
        '
        'GbxDocumentInformation
        '
        Me.GbxDocumentInformation.Controls.Add(Me.TbxDocumentDirectory)
        Me.GbxDocumentInformation.Controls.Add(Me.TbxDocumentName)
        Me.GbxDocumentInformation.Controls.Add(Me.Label49)
        Me.GbxDocumentInformation.Controls.Add(Me.Label48)
        Me.GbxDocumentInformation.Location = New System.Drawing.Point(7, 277)
        Me.GbxDocumentInformation.Name = "GbxDocumentInformation"
        Me.GbxDocumentInformation.Size = New System.Drawing.Size(802, 70)
        Me.GbxDocumentInformation.TabIndex = 7
        Me.GbxDocumentInformation.TabStop = False
        Me.GbxDocumentInformation.Text = "Document"
        '
        'BtnViewDocument
        '
        Me.BtnViewDocument.Location = New System.Drawing.Point(7, 353)
        Me.BtnViewDocument.Name = "BtnViewDocument"
        Me.BtnViewDocument.Size = New System.Drawing.Size(802, 45)
        Me.BtnViewDocument.TabIndex = 2
        Me.BtnViewDocument.Text = "View Document"
        Me.BtnViewDocument.UseVisualStyleBackColor = True
        '
        'TbxDocumentDirectory
        '
        Me.TbxDocumentDirectory.Location = New System.Drawing.Point(113, 45)
        Me.TbxDocumentDirectory.Name = "TbxDocumentDirectory"
        Me.TbxDocumentDirectory.ReadOnly = True
        Me.TbxDocumentDirectory.Size = New System.Drawing.Size(683, 20)
        Me.TbxDocumentDirectory.TabIndex = 1
        '
        'TbxDocumentName
        '
        Me.TbxDocumentName.Location = New System.Drawing.Point(113, 19)
        Me.TbxDocumentName.Name = "TbxDocumentName"
        Me.TbxDocumentName.ReadOnly = True
        Me.TbxDocumentName.Size = New System.Drawing.Size(683, 20)
        Me.TbxDocumentName.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(3, 48)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(104, 13)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Document Directory:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(17, 22)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(90, 13)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Document Name:"
        '
        'BtnPrintDocument
        '
        Me.BtnPrintDocument.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintDocument.Location = New System.Drawing.Point(7, 404)
        Me.BtnPrintDocument.Name = "BtnPrintDocument"
        Me.BtnPrintDocument.Size = New System.Drawing.Size(802, 71)
        Me.BtnPrintDocument.TabIndex = 3
        Me.BtnPrintDocument.Text = "Print Document"
        Me.BtnPrintDocument.UseVisualStyleBackColor = True
        '
        'LbxDocuments
        '
        Me.LbxDocuments.FormattingEnabled = True
        Me.LbxDocuments.Location = New System.Drawing.Point(7, 20)
        Me.LbxDocuments.Name = "LbxDocuments"
        Me.LbxDocuments.Size = New System.Drawing.Size(802, 251)
        Me.LbxDocuments.TabIndex = 0
        '
        'TbpAdmin
        '
        Me.TbpAdmin.Controls.Add(Me.GbxAdminPanel)
        Me.TbpAdmin.Location = New System.Drawing.Point(4, 22)
        Me.TbpAdmin.Name = "TbpAdmin"
        Me.TbpAdmin.Size = New System.Drawing.Size(837, 488)
        Me.TbpAdmin.TabIndex = 2
        Me.TbpAdmin.Text = "Admin"
        Me.TbpAdmin.UseVisualStyleBackColor = True
        '
        'GbxAdminPanel
        '
        Me.GbxAdminPanel.Controls.Add(Me.NudFuelCostPerMile)
        Me.GbxAdminPanel.Controls.Add(Me.CbxDeliveryOrigin)
        Me.GbxAdminPanel.Controls.Add(Me.BtnSaveSettings)
        Me.GbxAdminPanel.Controls.Add(Me.GbxStatistics)
        Me.GbxAdminPanel.Controls.Add(Me.GroupBox8)
        Me.GbxAdminPanel.Controls.Add(Me.GroupBox7)
        Me.GbxAdminPanel.Controls.Add(Me.GbxMultipliers)
        Me.GbxAdminPanel.Controls.Add(Me.GroupBox6)
        Me.GbxAdminPanel.Controls.Add(Me.GbxSystemControl)
        Me.GbxAdminPanel.Controls.Add(Me.Label43)
        Me.GbxAdminPanel.Controls.Add(Me.Button6)
        Me.GbxAdminPanel.Controls.Add(Me.Label42)
        Me.GbxAdminPanel.Controls.Add(Me.Label8)
        Me.GbxAdminPanel.Controls.Add(Me.TbxDatabaseDirectory)
        Me.GbxAdminPanel.Enabled = False
        Me.GbxAdminPanel.Location = New System.Drawing.Point(8, 3)
        Me.GbxAdminPanel.Name = "GbxAdminPanel"
        Me.GbxAdminPanel.Size = New System.Drawing.Size(821, 485)
        Me.GbxAdminPanel.TabIndex = 9
        Me.GbxAdminPanel.TabStop = False
        Me.GbxAdminPanel.Text = "Admin Panel"
        '
        'NudFuelCostPerMile
        '
        Me.NudFuelCostPerMile.DecimalPlaces = 2
        Me.NudFuelCostPerMile.Location = New System.Drawing.Point(578, 48)
        Me.NudFuelCostPerMile.Name = "NudFuelCostPerMile"
        Me.NudFuelCostPerMile.Size = New System.Drawing.Size(78, 20)
        Me.NudFuelCostPerMile.TabIndex = 14
        '
        'CbxDeliveryOrigin
        '
        Me.CbxDeliveryOrigin.FormattingEnabled = True
        Me.CbxDeliveryOrigin.Location = New System.Drawing.Point(320, 46)
        Me.CbxDeliveryOrigin.Name = "CbxDeliveryOrigin"
        Me.CbxDeliveryOrigin.Size = New System.Drawing.Size(153, 21)
        Me.CbxDeliveryOrigin.TabIndex = 13
        '
        'BtnSaveSettings
        '
        Me.BtnSaveSettings.Location = New System.Drawing.Point(216, 456)
        Me.BtnSaveSettings.Name = "BtnSaveSettings"
        Me.BtnSaveSettings.Size = New System.Drawing.Size(440, 23)
        Me.BtnSaveSettings.TabIndex = 12
        Me.BtnSaveSettings.Text = "Save Settings"
        Me.BtnSaveSettings.UseVisualStyleBackColor = True
        '
        'GbxStatistics
        '
        Me.GbxStatistics.Controls.Add(Me.BtnRefreshStatistics)
        Me.GbxStatistics.Controls.Add(Me.TbxMissedOrders)
        Me.GbxStatistics.Controls.Add(Me.Label40)
        Me.GbxStatistics.Controls.Add(Me.TbxTotalLoss)
        Me.GbxStatistics.Controls.Add(Me.Label39)
        Me.GbxStatistics.Controls.Add(Me.TbxTotalProfit)
        Me.GbxStatistics.Controls.Add(Me.Label38)
        Me.GbxStatistics.Controls.Add(Me.TbxTotalNetProfit)
        Me.GbxStatistics.Controls.Add(Me.Label37)
        Me.GbxStatistics.Controls.Add(Me.TbxOrderCount)
        Me.GbxStatistics.Controls.Add(Me.Label36)
        Me.GbxStatistics.Controls.Add(Me.TbxCustomerCount)
        Me.GbxStatistics.Controls.Add(Me.Label35)
        Me.GbxStatistics.Location = New System.Drawing.Point(662, 62)
        Me.GbxStatistics.Name = "GbxStatistics"
        Me.GbxStatistics.Size = New System.Drawing.Size(153, 334)
        Me.GbxStatistics.TabIndex = 11
        Me.GbxStatistics.TabStop = False
        Me.GbxStatistics.Text = "Statistics"
        '
        'BtnRefreshStatistics
        '
        Me.BtnRefreshStatistics.Location = New System.Drawing.Point(10, 306)
        Me.BtnRefreshStatistics.Name = "BtnRefreshStatistics"
        Me.BtnRefreshStatistics.Size = New System.Drawing.Size(137, 23)
        Me.BtnRefreshStatistics.TabIndex = 12
        Me.BtnRefreshStatistics.Text = "Refresh Statistics"
        Me.BtnRefreshStatistics.UseVisualStyleBackColor = True
        '
        'TbxMissedOrders
        '
        Me.TbxMissedOrders.ForeColor = System.Drawing.Color.Red
        Me.TbxMissedOrders.Location = New System.Drawing.Point(10, 136)
        Me.TbxMissedOrders.Name = "TbxMissedOrders"
        Me.TbxMissedOrders.ReadOnly = True
        Me.TbxMissedOrders.Size = New System.Drawing.Size(137, 20)
        Me.TbxMissedOrders.TabIndex = 11
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(7, 120)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(74, 13)
        Me.Label40.TabIndex = 10
        Me.Label40.Text = "Missed Orders"
        '
        'TbxTotalLoss
        '
        Me.TbxTotalLoss.ForeColor = System.Drawing.Color.Red
        Me.TbxTotalLoss.Location = New System.Drawing.Point(10, 232)
        Me.TbxTotalLoss.Name = "TbxTotalLoss"
        Me.TbxTotalLoss.ReadOnly = True
        Me.TbxTotalLoss.Size = New System.Drawing.Size(137, 20)
        Me.TbxTotalLoss.TabIndex = 9
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(7, 216)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 13)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "Total Loss"
        '
        'TbxTotalProfit
        '
        Me.TbxTotalProfit.ForeColor = System.Drawing.Color.Lime
        Me.TbxTotalProfit.Location = New System.Drawing.Point(10, 182)
        Me.TbxTotalProfit.Name = "TbxTotalProfit"
        Me.TbxTotalProfit.ReadOnly = True
        Me.TbxTotalProfit.Size = New System.Drawing.Size(137, 20)
        Me.TbxTotalProfit.TabIndex = 7
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(7, 165)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(58, 13)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = "Total Profit"
        '
        'TbxTotalNetProfit
        '
        Me.TbxTotalNetProfit.Location = New System.Drawing.Point(10, 280)
        Me.TbxTotalNetProfit.Name = "TbxTotalNetProfit"
        Me.TbxTotalNetProfit.ReadOnly = True
        Me.TbxTotalNetProfit.Size = New System.Drawing.Size(137, 20)
        Me.TbxTotalNetProfit.TabIndex = 5
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 264)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(78, 13)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "Total Net Profit"
        '
        'TbxOrderCount
        '
        Me.TbxOrderCount.Location = New System.Drawing.Point(10, 87)
        Me.TbxOrderCount.Name = "TbxOrderCount"
        Me.TbxOrderCount.ReadOnly = True
        Me.TbxOrderCount.Size = New System.Drawing.Size(137, 20)
        Me.TbxOrderCount.TabIndex = 3
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 71)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Total Orders"
        '
        'TbxCustomerCount
        '
        Me.TbxCustomerCount.Location = New System.Drawing.Point(10, 36)
        Me.TbxCustomerCount.Name = "TbxCustomerCount"
        Me.TbxCustomerCount.ReadOnly = True
        Me.TbxCustomerCount.Size = New System.Drawing.Size(137, 20)
        Me.TbxCustomerCount.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(7, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Total Customers"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.TbxCostPerServing)
        Me.GroupBox8.Controls.Add(Me.TbxDeposit)
        Me.GroupBox8.Controls.Add(Me.TbxVAT)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.Label33)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Location = New System.Drawing.Point(223, 210)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(433, 131)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cost Multipliers"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(293, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Enter the cost variables that will determine the total or orders:"
        '
        'TbxCostPerServing
        '
        Me.TbxCostPerServing.Location = New System.Drawing.Point(149, 94)
        Me.TbxCostPerServing.Name = "TbxCostPerServing"
        Me.TbxCostPerServing.Size = New System.Drawing.Size(278, 20)
        Me.TbxCostPerServing.TabIndex = 6
        '
        'TbxDeposit
        '
        Me.TbxDeposit.Location = New System.Drawing.Point(149, 68)
        Me.TbxDeposit.Name = "TbxDeposit"
        Me.TbxDeposit.Size = New System.Drawing.Size(278, 20)
        Me.TbxDeposit.TabIndex = 5
        '
        'TbxVAT
        '
        Me.TbxVAT.Location = New System.Drawing.Point(149, 42)
        Me.TbxVAT.Name = "TbxVAT"
        Me.TbxVAT.Size = New System.Drawing.Size(278, 20)
        Me.TbxVAT.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(10, 97)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(133, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Cost Per Serving Multiplier:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(86, 71)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Deposit %:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(101, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "VAT %:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TbxLowStockThreshold)
        Me.GroupBox7.Controls.Add(Me.TbxSupplierEmail)
        Me.GroupBox7.Controls.Add(Me.TbxSupplierURL)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Location = New System.Drawing.Point(223, 347)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(433, 103)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Stock"
        '
        'TbxLowStockThreshold
        '
        Me.TbxLowStockThreshold.Location = New System.Drawing.Point(125, 71)
        Me.TbxLowStockThreshold.Name = "TbxLowStockThreshold"
        Me.TbxLowStockThreshold.Size = New System.Drawing.Size(302, 20)
        Me.TbxLowStockThreshold.TabIndex = 9
        '
        'TbxSupplierEmail
        '
        Me.TbxSupplierEmail.Location = New System.Drawing.Point(125, 45)
        Me.TbxSupplierEmail.Name = "TbxSupplierEmail"
        Me.TbxSupplierEmail.Size = New System.Drawing.Size(302, 20)
        Me.TbxSupplierEmail.TabIndex = 8
        '
        'TbxSupplierURL
        '
        Me.TbxSupplierURL.Location = New System.Drawing.Point(125, 19)
        Me.TbxSupplierURL.Name = "TbxSupplierURL"
        Me.TbxSupplierURL.Size = New System.Drawing.Size(302, 20)
        Me.TbxSupplierURL.TabIndex = 7
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(10, 74)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(111, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Low Stock Threshold:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(39, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Supplier E-Mail:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(46, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(73, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Supplier URL:"
        '
        'GbxMultipliers
        '
        Me.GbxMultipliers.Controls.Add(Me.LblInfo)
        Me.GbxMultipliers.Controls.Add(Me.TbxFruitMultiplier)
        Me.GbxMultipliers.Controls.Add(Me.TbxChocolateMultiplier)
        Me.GbxMultipliers.Controls.Add(Me.TbxSpongeMultiplier)
        Me.GbxMultipliers.Controls.Add(Me.Label26)
        Me.GbxMultipliers.Controls.Add(Me.Label25)
        Me.GbxMultipliers.Controls.Add(Me.Label24)
        Me.GbxMultipliers.Location = New System.Drawing.Point(223, 73)
        Me.GbxMultipliers.Name = "GbxMultipliers"
        Me.GbxMultipliers.Size = New System.Drawing.Size(433, 131)
        Me.GbxMultipliers.TabIndex = 9
        Me.GbxMultipliers.TabStop = False
        Me.GbxMultipliers.Text = "Time Multipliers"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Location = New System.Drawing.Point(6, 16)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(421, 13)
        Me.LblInfo.TabIndex = 2
        Me.LblInfo.Text = "Enter the average amount of time in minutes per serving it takes to complete each" & _
            " cake:"
        '
        'TbxFruitMultiplier
        '
        Me.TbxFruitMultiplier.Location = New System.Drawing.Point(70, 94)
        Me.TbxFruitMultiplier.Name = "TbxFruitMultiplier"
        Me.TbxFruitMultiplier.Size = New System.Drawing.Size(357, 20)
        Me.TbxFruitMultiplier.TabIndex = 3
        '
        'TbxChocolateMultiplier
        '
        Me.TbxChocolateMultiplier.Location = New System.Drawing.Point(70, 68)
        Me.TbxChocolateMultiplier.Name = "TbxChocolateMultiplier"
        Me.TbxChocolateMultiplier.Size = New System.Drawing.Size(357, 20)
        Me.TbxChocolateMultiplier.TabIndex = 2
        '
        'TbxSpongeMultiplier
        '
        Me.TbxSpongeMultiplier.Location = New System.Drawing.Point(70, 42)
        Me.TbxSpongeMultiplier.Name = "TbxSpongeMultiplier"
        Me.TbxSpongeMultiplier.Size = New System.Drawing.Size(357, 20)
        Me.TbxSpongeMultiplier.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(34, 97)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Fruit:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Chocolate:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Sponge:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button11)
        Me.GroupBox6.Controls.Add(Me.Button9)
        Me.GroupBox6.Location = New System.Drawing.Point(662, 402)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(153, 82)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Archives"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Black
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(6, 47)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(141, 23)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "View Finance Archives"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Black
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(6, 15)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(141, 26)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "View Order Archives"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'GbxSystemControl
        '
        Me.GbxSystemControl.Controls.Add(Me.BtnEmailSettings)
        Me.GbxSystemControl.Controls.Add(Me.BtnBackup)
        Me.GbxSystemControl.Controls.Add(Me.BtnEditOrder)
        Me.GbxSystemControl.Controls.Add(Me.BtnEditCustomer)
        Me.GbxSystemControl.Controls.Add(Me.BtnEditStock)
        Me.GbxSystemControl.Controls.Add(Me.BtnDeleteDocument)
        Me.GbxSystemControl.Controls.Add(Me.BtnDeleteStock)
        Me.GbxSystemControl.Controls.Add(Me.BtnDocument)
        Me.GbxSystemControl.Controls.Add(Me.BtnAddStockItem)
        Me.GbxSystemControl.Controls.Add(Me.BtnEditMap)
        Me.GbxSystemControl.Controls.Add(Me.BtnDeleteOrder)
        Me.GbxSystemControl.Controls.Add(Me.BtnDeleteCustomer)
        Me.GbxSystemControl.Location = New System.Drawing.Point(6, 19)
        Me.GbxSystemControl.Name = "GbxSystemControl"
        Me.GbxSystemControl.Size = New System.Drawing.Size(200, 460)
        Me.GbxSystemControl.TabIndex = 5
        Me.GbxSystemControl.TabStop = False
        Me.GbxSystemControl.Text = "System Control"
        '
        'BtnEmailSettings
        '
        Me.BtnEmailSettings.Location = New System.Drawing.Point(6, 326)
        Me.BtnEmailSettings.Name = "BtnEmailSettings"
        Me.BtnEmailSettings.Size = New System.Drawing.Size(188, 23)
        Me.BtnEmailSettings.TabIndex = 15
        Me.BtnEmailSettings.Text = "E-Mail Settings"
        Me.BtnEmailSettings.UseVisualStyleBackColor = True
        '
        'BtnBackup
        '
        Me.BtnBackup.Location = New System.Drawing.Point(6, 355)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(188, 23)
        Me.BtnBackup.TabIndex = 9
        Me.BtnBackup.Text = "Backup"
        Me.BtnBackup.UseVisualStyleBackColor = True
        '
        'BtnEditOrder
        '
        Me.BtnEditOrder.Location = New System.Drawing.Point(6, 140)
        Me.BtnEditOrder.Name = "BtnEditOrder"
        Me.BtnEditOrder.Size = New System.Drawing.Size(188, 26)
        Me.BtnEditOrder.TabIndex = 8
        Me.BtnEditOrder.Text = "Edit Order"
        Me.BtnEditOrder.UseVisualStyleBackColor = True
        '
        'BtnEditCustomer
        '
        Me.BtnEditCustomer.Location = New System.Drawing.Point(6, 109)
        Me.BtnEditCustomer.Name = "BtnEditCustomer"
        Me.BtnEditCustomer.Size = New System.Drawing.Size(188, 26)
        Me.BtnEditCustomer.TabIndex = 7
        Me.BtnEditCustomer.Text = "Edit Customer"
        Me.BtnEditCustomer.UseVisualStyleBackColor = True
        '
        'BtnEditStock
        '
        Me.BtnEditStock.Location = New System.Drawing.Point(6, 79)
        Me.BtnEditStock.Name = "BtnEditStock"
        Me.BtnEditStock.Size = New System.Drawing.Size(188, 24)
        Me.BtnEditStock.TabIndex = 6
        Me.BtnEditStock.Text = "Edit Stock Item"
        Me.BtnEditStock.UseVisualStyleBackColor = True
        '
        'BtnDeleteDocument
        '
        Me.BtnDeleteDocument.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteDocument.Location = New System.Drawing.Point(6, 172)
        Me.BtnDeleteDocument.Name = "BtnDeleteDocument"
        Me.BtnDeleteDocument.Size = New System.Drawing.Size(188, 24)
        Me.BtnDeleteDocument.TabIndex = 3
        Me.BtnDeleteDocument.Text = "Delete Document"
        Me.BtnDeleteDocument.UseVisualStyleBackColor = True
        '
        'BtnDeleteStock
        '
        Me.BtnDeleteStock.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteStock.Location = New System.Drawing.Point(6, 202)
        Me.BtnDeleteStock.Name = "BtnDeleteStock"
        Me.BtnDeleteStock.Size = New System.Drawing.Size(188, 24)
        Me.BtnDeleteStock.TabIndex = 3
        Me.BtnDeleteStock.Text = "Delete Stock Item"
        Me.BtnDeleteStock.UseVisualStyleBackColor = True
        '
        'BtnDocument
        '
        Me.BtnDocument.Location = New System.Drawing.Point(6, 49)
        Me.BtnDocument.Name = "BtnDocument"
        Me.BtnDocument.Size = New System.Drawing.Size(188, 24)
        Me.BtnDocument.TabIndex = 3
        Me.BtnDocument.Text = "Add Document"
        Me.BtnDocument.UseVisualStyleBackColor = True
        '
        'BtnAddStockItem
        '
        Me.BtnAddStockItem.Location = New System.Drawing.Point(6, 19)
        Me.BtnAddStockItem.Name = "BtnAddStockItem"
        Me.BtnAddStockItem.Size = New System.Drawing.Size(188, 24)
        Me.BtnAddStockItem.TabIndex = 3
        Me.BtnAddStockItem.Text = "Add New Stock Item"
        Me.BtnAddStockItem.UseVisualStyleBackColor = True
        '
        'BtnEditMap
        '
        Me.BtnEditMap.Location = New System.Drawing.Point(6, 296)
        Me.BtnEditMap.Name = "BtnEditMap"
        Me.BtnEditMap.Size = New System.Drawing.Size(188, 24)
        Me.BtnEditMap.TabIndex = 3
        Me.BtnEditMap.Text = "Edit Map"
        Me.BtnEditMap.UseVisualStyleBackColor = True
        '
        'BtnDeleteOrder
        '
        Me.BtnDeleteOrder.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteOrder.Location = New System.Drawing.Point(6, 264)
        Me.BtnDeleteOrder.Name = "BtnDeleteOrder"
        Me.BtnDeleteOrder.Size = New System.Drawing.Size(188, 26)
        Me.BtnDeleteOrder.TabIndex = 5
        Me.BtnDeleteOrder.Text = "Delete Order"
        Me.BtnDeleteOrder.UseVisualStyleBackColor = True
        '
        'BtnDeleteCustomer
        '
        Me.BtnDeleteCustomer.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteCustomer.Location = New System.Drawing.Point(6, 232)
        Me.BtnDeleteCustomer.Name = "BtnDeleteCustomer"
        Me.BtnDeleteCustomer.Size = New System.Drawing.Size(188, 26)
        Me.BtnDeleteCustomer.TabIndex = 4
        Me.BtnDeleteCustomer.Text = "Delete Customer"
        Me.BtnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(479, 50)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(93, 13)
        Me.Label43.TabIndex = 7
        Me.Label43.Text = "Fuel Cost / Mile: £"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(662, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Browse"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(233, 50)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(81, 13)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "Delivery  Origin:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Database Directory:"
        '
        'TbxDatabaseDirectory
        '
        Me.TbxDatabaseDirectory.Location = New System.Drawing.Point(320, 19)
        Me.TbxDatabaseDirectory.Name = "TbxDatabaseDirectory"
        Me.TbxDatabaseDirectory.Size = New System.Drawing.Size(336, 20)
        Me.TbxDatabaseDirectory.TabIndex = 0
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 567)
        Me.Controls.Add(Me.TbcMainMenu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TbcMainMenu.ResumeLayout(False)
        Me.TbpOrders.ResumeLayout(False)
        Me.TbpOrders.PerformLayout()
        Me.GbxOrderDetails.ResumeLayout(False)
        Me.GbxOrderDetails.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NudCurrentServingSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TbpCustomers.ResumeLayout(False)
        Me.GbxCustomerSearch.ResumeLayout(False)
        Me.GbxCustomerSearch.PerformLayout()
        Me.GbxCustomerGrid.ResumeLayout(False)
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpDelivery.ResumeLayout(False)
        Me.TbpDelivery.PerformLayout()
        Me.GbxRouteLocationOrder.ResumeLayout(False)
        Me.GbxCalculationData.ResumeLayout(False)
        Me.GbxCalculationData.PerformLayout()
        Me.GbxRouteInformation.ResumeLayout(False)
        CType(Me.PcbMapImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpStock.ResumeLayout(False)
        Me.GbxStock.ResumeLayout(False)
        CType(Me.DgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NudRestockQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpFinance.ResumeLayout(False)
        Me.GbxOrderFinances.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GbxTodaysFinances.ResumeLayout(False)
        CType(Me.DgvFinances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpDocumentation.ResumeLayout(False)
        Me.GbxDocuments.ResumeLayout(False)
        Me.GbxDocumentInformation.ResumeLayout(False)
        Me.GbxDocumentInformation.PerformLayout()
        Me.TbpAdmin.ResumeLayout(False)
        Me.GbxAdminPanel.ResumeLayout(False)
        Me.GbxAdminPanel.PerformLayout()
        CType(Me.NudFuelCostPerMile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxStatistics.ResumeLayout(False)
        Me.GbxStatistics.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GbxMultipliers.ResumeLayout(False)
        Me.GbxMultipliers.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GbxSystemControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SwitchUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsbChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OrderCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbxCurrentOrders As System.Windows.Forms.ListBox
    Friend WithEvents NewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbcMainMenu As System.Windows.Forms.TabControl
    Friend WithEvents TbpOrders As System.Windows.Forms.TabPage
    Friend WithEvents TbpStock As System.Windows.Forms.TabPage
    Friend WithEvents BtnRestock As System.Windows.Forms.Button
    Friend WithEvents TbpCustomers As System.Windows.Forms.TabPage
    Friend WithEvents TbpAdmin As System.Windows.Forms.TabPage
    Friend WithEvents BtnEditMap As System.Windows.Forms.Button
    Friend WithEvents GbxSystemControl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents TbpDelivery As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxEndLocation As System.Windows.Forms.ComboBox
    Friend WithEvents CbxStartLocation As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GbxOrderDetails As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDeleteOrder As System.Windows.Forms.Button
    Friend WithEvents TbpFinance As System.Windows.Forms.TabPage
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsbLogoutAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbxDatabaseDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RtbCurrentOrderDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NudCurrentServingSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RtbCurrentConsiderations As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DtpCurrentDeadline As System.Windows.Forms.DateTimePicker
    Friend WithEvents GbxAdminPanel As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TbxSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TbxForename As System.Windows.Forms.TextBox
    Friend WithEvents TbxPostcode As System.Windows.Forms.TextBox
    Friend WithEvents TbxTown As System.Windows.Forms.TextBox
    Friend WithEvents TbxPhone As System.Windows.Forms.TextBox
    Friend WithEvents TbxEmail As System.Windows.Forms.TextBox
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ClbLowStock As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents BtnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TbxSearchSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents RtbOrderInformation As System.Windows.Forms.RichTextBox
    Friend WithEvents RtbConsiderations As System.Windows.Forms.RichTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LblDeadline As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LblETA As System.Windows.Forms.Label
    Friend WithEvents GbxMultipliers As System.Windows.Forms.GroupBox
    Friend WithEvents TbxFruitMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents TbxChocolateMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents TbxSpongeMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents LblLatestStart As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TbxLowStockThreshold As System.Windows.Forms.TextBox
    Friend WithEvents TbxSupplierEmail As System.Windows.Forms.TextBox
    Friend WithEvents TbxSupplierURL As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TbpDocumentation As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TbxCostPerServing As System.Windows.Forms.TextBox
    Friend WithEvents TbxDeposit As System.Windows.Forms.TextBox
    Friend WithEvents TbxVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GbxStatistics As System.Windows.Forms.GroupBox
    Friend WithEvents TbxTotalNetProfit As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TbxOrderCount As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TbxCustomerCount As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TbxTotalLoss As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TbxTotalProfit As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TbxMissedOrders As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BtnFullViewOrder As System.Windows.Forms.Button
    Friend WithEvents BtnRefreshStatistics As System.Windows.Forms.Button
    Friend WithEvents BtnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents GbxDocuments As System.Windows.Forms.GroupBox
    Friend WithEvents LbxDocuments As System.Windows.Forms.ListBox
    Friend WithEvents GbxCustomerGrid As System.Windows.Forms.GroupBox
    Friend WithEvents GbxCustomerSearch As System.Windows.Forms.GroupBox
    Friend WithEvents BtnViewSupplierWebsite As System.Windows.Forms.Button
    Friend WithEvents BtnEmailSupplier As System.Windows.Forms.Button
    Friend WithEvents TbxItemName As System.Windows.Forms.TextBox
    Friend WithEvents TbxItemCost As System.Windows.Forms.TextBox
    Friend WithEvents TbxItemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TbxStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents ChbxReOrdered As System.Windows.Forms.CheckBox
    Friend WithEvents ChbxDiscrepancy As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GbxStock As System.Windows.Forms.GroupBox
    Friend WithEvents DgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents TssLoadingStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TspLoadingBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents GbxTodaysFinances As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFinances As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAddStockItem As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteStock As System.Windows.Forms.Button
    Friend WithEvents GbxRouteInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GbxCalculationData As System.Windows.Forms.GroupBox
    Friend WithEvents RtbDistances As System.Windows.Forms.RichTextBox
    Friend WithEvents TbxOrigin As System.Windows.Forms.TextBox
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents GbxRouteLocationOrder As System.Windows.Forms.GroupBox
    Friend WithEvents LbxRouteLocationOrder As System.Windows.Forms.ListBox
    Friend WithEvents CbxDeliveryOrigin As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents NudFuelCostPerMile As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnEditStock As System.Windows.Forms.Button
    Friend WithEvents BtnEditCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnPrintShoppingList As System.Windows.Forms.Button
    Friend WithEvents PcbMapImage As System.Windows.Forms.PictureBox
    Friend WithEvents GbxOrderFinances As System.Windows.Forms.GroupBox
    Friend WithEvents LbxOutstandingPayments As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFullViewFinance As System.Windows.Forms.Button
    Friend WithEvents BtnFullyPaid As System.Windows.Forms.Button
    Friend WithEvents BtnDepositPaid As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TbxDepositAmount As System.Windows.Forms.TextBox
    Friend WithEvents TbxFullCost As System.Windows.Forms.TextBox
    Friend WithEvents BtnSendInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnPrintDocument As System.Windows.Forms.Button
    Friend WithEvents BtnEditOrder As System.Windows.Forms.Button
    Friend WithEvents BtnBackup As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents NudRestockQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnDocument As System.Windows.Forms.Button
    Friend WithEvents GbxDocumentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TbxDocumentName As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TbxDocumentDirectory As System.Windows.Forms.TextBox
    Friend WithEvents BtnViewDocument As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnDeleteDocument As System.Windows.Forms.Button
    Friend WithEvents BtnEmailSettings As System.Windows.Forms.Button
End Class
