<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupWizard
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
        Me.FinishPanel = New System.Windows.Forms.Panel()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.TbxEncryptedPassword = New System.Windows.Forms.TextBox()
        Me.BtnViewPassword = New System.Windows.Forms.Button()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.BtnNextMap = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VariablesPanel = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TbxLowStockThreshold = New System.Windows.Forms.TextBox()
        Me.TbxSupplierEmail = New System.Windows.Forms.TextBox()
        Me.TbxSupplierURL = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TbxCostPerServing = New System.Windows.Forms.TextBox()
        Me.TbxDeposit = New System.Windows.Forms.TextBox()
        Me.TbxVAT = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnBackToDatabase = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GbxMultipliers = New System.Windows.Forms.GroupBox()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.TbxFruitMultiplier = New System.Windows.Forms.TextBox()
        Me.TbxChocolateMultiplier = New System.Windows.Forms.TextBox()
        Me.TbxSpongeMultiplier = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnNextEmail = New System.Windows.Forms.Button()
        Me.MapPanel = New System.Windows.Forms.Panel()
        Me.NudFuelCost = New System.Windows.Forms.NumericUpDown()
        Me.CbxPossibleOrigins = New System.Windows.Forms.ComboBox()
        Me.BtnLoadMap = New System.Windows.Forms.Button()
        Me.BtnBackToAdmin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbxMapDirectory = New System.Windows.Forms.TextBox()
        Me.BtnBackAdmin = New System.Windows.Forms.Button()
        Me.BtnNextDatabase = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DatabasePanel = New System.Windows.Forms.Panel()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.TbxDatabaseDirectory = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BtnBackMap = New System.Windows.Forms.Button()
        Me.BtnNextVariables = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.EMailPanel = New System.Windows.Forms.Panel()
        Me.TbxEMailPassword = New System.Windows.Forms.TextBox()
        Me.TbxEMailPort = New System.Windows.Forms.TextBox()
        Me.BtnBackToVariables = New System.Windows.Forms.Button()
        Me.TbxEMailServer = New System.Windows.Forms.TextBox()
        Me.TbxEMailAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnToFinish = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FinishPanel.SuspendLayout()
        Me.AdminPanel.SuspendLayout()
        Me.VariablesPanel.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GbxMultipliers.SuspendLayout()
        Me.MapPanel.SuspendLayout()
        CType(Me.NudFuelCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatabasePanel.SuspendLayout()
        Me.EMailPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FinishPanel
        '
        Me.FinishPanel.Controls.Add(Me.BtnFinish)
        Me.FinishPanel.Controls.Add(Me.Label2)
        Me.FinishPanel.Controls.Add(Me.Label1)
        Me.FinishPanel.Location = New System.Drawing.Point(18, 7)
        Me.FinishPanel.Name = "FinishPanel"
        Me.FinishPanel.Size = New System.Drawing.Size(521, 466)
        Me.FinishPanel.TabIndex = 0
        Me.FinishPanel.Visible = False
        '
        'BtnFinish
        '
        Me.BtnFinish.Location = New System.Drawing.Point(428, 434)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(90, 23)
        Me.BtnFinish.TabIndex = 2
        Me.BtnFinish.Text = "Finish"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You have now completed the setup process. Click finish to start using the CBMS!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congratulations!"
        '
        'AdminPanel
        '
        Me.AdminPanel.Controls.Add(Me.TbxEncryptedPassword)
        Me.AdminPanel.Controls.Add(Me.BtnViewPassword)
        Me.AdminPanel.Controls.Add(Me.TbxPassword)
        Me.AdminPanel.Controls.Add(Me.BtnNextMap)
        Me.AdminPanel.Controls.Add(Me.Label7)
        Me.AdminPanel.Controls.Add(Me.Label8)
        Me.AdminPanel.Location = New System.Drawing.Point(12, 12)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(521, 466)
        Me.AdminPanel.TabIndex = 7
        '
        'TbxEncryptedPassword
        '
        Me.TbxEncryptedPassword.Location = New System.Drawing.Point(10, 79)
        Me.TbxEncryptedPassword.Name = "TbxEncryptedPassword"
        Me.TbxEncryptedPassword.ReadOnly = True
        Me.TbxEncryptedPassword.Size = New System.Drawing.Size(508, 20)
        Me.TbxEncryptedPassword.TabIndex = 7
        '
        'BtnViewPassword
        '
        Me.BtnViewPassword.Location = New System.Drawing.Point(400, 50)
        Me.BtnViewPassword.Name = "BtnViewPassword"
        Me.BtnViewPassword.Size = New System.Drawing.Size(118, 23)
        Me.BtnViewPassword.TabIndex = 6
        Me.BtnViewPassword.Text = "View Password"
        Me.BtnViewPassword.UseVisualStyleBackColor = True
        '
        'TbxPassword
        '
        Me.TbxPassword.Location = New System.Drawing.Point(10, 52)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TbxPassword.Size = New System.Drawing.Size(384, 20)
        Me.TbxPassword.TabIndex = 5
        '
        'BtnNextMap
        '
        Me.BtnNextMap.Location = New System.Drawing.Point(443, 434)
        Me.BtnNextMap.Name = "BtnNextMap"
        Me.BtnNextMap.Size = New System.Drawing.Size(75, 23)
        Me.BtnNextMap.TabIndex = 2
        Me.BtnNextMap.Text = "Next"
        Me.BtnNextMap.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Please enter a password that will be used to access restricted functions:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Admin"
        '
        'VariablesPanel
        '
        Me.VariablesPanel.Controls.Add(Me.GroupBox7)
        Me.VariablesPanel.Controls.Add(Me.GroupBox8)
        Me.VariablesPanel.Controls.Add(Me.BtnBackToDatabase)
        Me.VariablesPanel.Controls.Add(Me.Label9)
        Me.VariablesPanel.Controls.Add(Me.GbxMultipliers)
        Me.VariablesPanel.Controls.Add(Me.Label10)
        Me.VariablesPanel.Controls.Add(Me.BtnNextEmail)
        Me.VariablesPanel.Location = New System.Drawing.Point(5, 13)
        Me.VariablesPanel.Name = "VariablesPanel"
        Me.VariablesPanel.Size = New System.Drawing.Size(521, 466)
        Me.VariablesPanel.TabIndex = 0
        Me.VariablesPanel.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TbxLowStockThreshold)
        Me.GroupBox7.Controls.Add(Me.TbxSupplierEmail)
        Me.GroupBox7.Controls.Add(Me.TbxSupplierURL)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 325)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(502, 103)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Stock"
        '
        'TbxLowStockThreshold
        '
        Me.TbxLowStockThreshold.Location = New System.Drawing.Point(125, 71)
        Me.TbxLowStockThreshold.Name = "TbxLowStockThreshold"
        Me.TbxLowStockThreshold.Size = New System.Drawing.Size(364, 20)
        Me.TbxLowStockThreshold.TabIndex = 9
        '
        'TbxSupplierEmail
        '
        Me.TbxSupplierEmail.Location = New System.Drawing.Point(125, 45)
        Me.TbxSupplierEmail.Name = "TbxSupplierEmail"
        Me.TbxSupplierEmail.Size = New System.Drawing.Size(364, 20)
        Me.TbxSupplierEmail.TabIndex = 8
        '
        'TbxSupplierURL
        '
        Me.TbxSupplierURL.Location = New System.Drawing.Point(125, 19)
        Me.TbxSupplierURL.Name = "TbxSupplierURL"
        Me.TbxSupplierURL.Size = New System.Drawing.Size(364, 20)
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.TbxCostPerServing)
        Me.GroupBox8.Controls.Add(Me.TbxDeposit)
        Me.GroupBox8.Controls.Add(Me.TbxVAT)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.Label33)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Location = New System.Drawing.Point(10, 188)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(502, 131)
        Me.GroupBox8.TabIndex = 12
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
        Me.TbxCostPerServing.Size = New System.Drawing.Size(340, 20)
        Me.TbxCostPerServing.TabIndex = 6
        '
        'TbxDeposit
        '
        Me.TbxDeposit.Location = New System.Drawing.Point(149, 68)
        Me.TbxDeposit.Name = "TbxDeposit"
        Me.TbxDeposit.Size = New System.Drawing.Size(340, 20)
        Me.TbxDeposit.TabIndex = 5
        '
        'TbxVAT
        '
        Me.TbxVAT.Location = New System.Drawing.Point(149, 42)
        Me.TbxVAT.Name = "TbxVAT"
        Me.TbxVAT.Size = New System.Drawing.Size(340, 20)
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
        'BtnBackToDatabase
        '
        Me.BtnBackToDatabase.Location = New System.Drawing.Point(10, 434)
        Me.BtnBackToDatabase.Name = "BtnBackToDatabase"
        Me.BtnBackToDatabase.Size = New System.Drawing.Size(75, 23)
        Me.BtnBackToDatabase.TabIndex = 4
        Me.BtnBackToDatabase.Text = "Back"
        Me.BtnBackToDatabase.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Enter the various variables required:"
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
        Me.GbxMultipliers.Location = New System.Drawing.Point(10, 51)
        Me.GbxMultipliers.Name = "GbxMultipliers"
        Me.GbxMultipliers.Size = New System.Drawing.Size(502, 131)
        Me.GbxMultipliers.TabIndex = 11
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
        Me.TbxFruitMultiplier.Size = New System.Drawing.Size(419, 20)
        Me.TbxFruitMultiplier.TabIndex = 3
        '
        'TbxChocolateMultiplier
        '
        Me.TbxChocolateMultiplier.Location = New System.Drawing.Point(70, 68)
        Me.TbxChocolateMultiplier.Name = "TbxChocolateMultiplier"
        Me.TbxChocolateMultiplier.Size = New System.Drawing.Size(419, 20)
        Me.TbxChocolateMultiplier.TabIndex = 2
        '
        'TbxSpongeMultiplier
        '
        Me.TbxSpongeMultiplier.Location = New System.Drawing.Point(70, 42)
        Me.TbxSpongeMultiplier.Name = "TbxSpongeMultiplier"
        Me.TbxSpongeMultiplier.Size = New System.Drawing.Size(419, 20)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 31)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Variables"
        '
        'BtnNextEmail
        '
        Me.BtnNextEmail.Location = New System.Drawing.Point(437, 434)
        Me.BtnNextEmail.Name = "BtnNextEmail"
        Me.BtnNextEmail.Size = New System.Drawing.Size(75, 23)
        Me.BtnNextEmail.TabIndex = 2
        Me.BtnNextEmail.Text = "Next"
        Me.BtnNextEmail.UseVisualStyleBackColor = True
        '
        'MapPanel
        '
        Me.MapPanel.Controls.Add(Me.NudFuelCost)
        Me.MapPanel.Controls.Add(Me.CbxPossibleOrigins)
        Me.MapPanel.Controls.Add(Me.BtnLoadMap)
        Me.MapPanel.Controls.Add(Me.BtnBackToAdmin)
        Me.MapPanel.Controls.Add(Me.Button1)
        Me.MapPanel.Controls.Add(Me.TbxMapDirectory)
        Me.MapPanel.Controls.Add(Me.BtnBackAdmin)
        Me.MapPanel.Controls.Add(Me.BtnNextDatabase)
        Me.MapPanel.Controls.Add(Me.Label12)
        Me.MapPanel.Controls.Add(Me.Label11)
        Me.MapPanel.Controls.Add(Me.Label5)
        Me.MapPanel.Controls.Add(Me.Label6)
        Me.MapPanel.Location = New System.Drawing.Point(9, 15)
        Me.MapPanel.Name = "MapPanel"
        Me.MapPanel.Size = New System.Drawing.Size(521, 466)
        Me.MapPanel.TabIndex = 7
        Me.MapPanel.Visible = False
        '
        'NudFuelCost
        '
        Me.NudFuelCost.DecimalPlaces = 2
        Me.NudFuelCost.Location = New System.Drawing.Point(272, 150)
        Me.NudFuelCost.Name = "NudFuelCost"
        Me.NudFuelCost.Size = New System.Drawing.Size(245, 20)
        Me.NudFuelCost.TabIndex = 9
        '
        'CbxPossibleOrigins
        '
        Me.CbxPossibleOrigins.FormattingEnabled = True
        Me.CbxPossibleOrigins.Location = New System.Drawing.Point(272, 119)
        Me.CbxPossibleOrigins.Name = "CbxPossibleOrigins"
        Me.CbxPossibleOrigins.Size = New System.Drawing.Size(245, 21)
        Me.CbxPossibleOrigins.TabIndex = 8
        '
        'BtnLoadMap
        '
        Me.BtnLoadMap.Enabled = False
        Me.BtnLoadMap.Location = New System.Drawing.Point(10, 78)
        Me.BtnLoadMap.Name = "BtnLoadMap"
        Me.BtnLoadMap.Size = New System.Drawing.Size(508, 23)
        Me.BtnLoadMap.TabIndex = 7
        Me.BtnLoadMap.Text = "Load Map"
        Me.BtnLoadMap.UseVisualStyleBackColor = True
        '
        'BtnBackToAdmin
        '
        Me.BtnBackToAdmin.Location = New System.Drawing.Point(3, 440)
        Me.BtnBackToAdmin.Name = "BtnBackToAdmin"
        Me.BtnBackToAdmin.Size = New System.Drawing.Size(75, 23)
        Me.BtnBackToAdmin.TabIndex = 4
        Me.BtnBackToAdmin.Text = "Back"
        Me.BtnBackToAdmin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TbxMapDirectory
        '
        Me.TbxMapDirectory.Location = New System.Drawing.Point(10, 52)
        Me.TbxMapDirectory.Name = "TbxMapDirectory"
        Me.TbxMapDirectory.Size = New System.Drawing.Size(427, 20)
        Me.TbxMapDirectory.TabIndex = 5
        '
        'BtnBackAdmin
        '
        Me.BtnBackAdmin.Location = New System.Drawing.Point(4, 439)
        Me.BtnBackAdmin.Name = "BtnBackAdmin"
        Me.BtnBackAdmin.Size = New System.Drawing.Size(75, 23)
        Me.BtnBackAdmin.TabIndex = 3
        Me.BtnBackAdmin.Text = "Back"
        Me.BtnBackAdmin.UseVisualStyleBackColor = True
        '
        'BtnNextDatabase
        '
        Me.BtnNextDatabase.Location = New System.Drawing.Point(443, 440)
        Me.BtnNextDatabase.Name = "BtnNextDatabase"
        Me.BtnNextDatabase.Size = New System.Drawing.Size(75, 23)
        Me.BtnNextDatabase.TabIndex = 2
        Me.BtnNextDatabase.Text = "Next"
        Me.BtnNextDatabase.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(261, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Enter the cost of fuel per mile for your transportation: £"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(255, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Select an origin point (where you will start a delivery):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Please select you map file:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 31)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Delivery"
        '
        'DatabasePanel
        '
        Me.DatabasePanel.Controls.Add(Me.BtnBrowse)
        Me.DatabasePanel.Controls.Add(Me.TbxDatabaseDirectory)
        Me.DatabasePanel.Controls.Add(Me.RadioButton1)
        Me.DatabasePanel.Controls.Add(Me.BtnBackMap)
        Me.DatabasePanel.Controls.Add(Me.BtnNextVariables)
        Me.DatabasePanel.Controls.Add(Me.Label4)
        Me.DatabasePanel.Controls.Add(Me.Label3)
        Me.DatabasePanel.Location = New System.Drawing.Point(9, 15)
        Me.DatabasePanel.Name = "DatabasePanel"
        Me.DatabasePanel.Size = New System.Drawing.Size(521, 466)
        Me.DatabasePanel.TabIndex = 3
        Me.DatabasePanel.Visible = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(443, 50)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 6
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'TbxDatabaseDirectory
        '
        Me.TbxDatabaseDirectory.Location = New System.Drawing.Point(10, 52)
        Me.TbxDatabaseDirectory.Name = "TbxDatabaseDirectory"
        Me.TbxDatabaseDirectory.Size = New System.Drawing.Size(427, 20)
        Me.TbxDatabaseDirectory.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 78)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Microsoft Access 2010"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BtnBackMap
        '
        Me.BtnBackMap.Location = New System.Drawing.Point(3, 439)
        Me.BtnBackMap.Name = "BtnBackMap"
        Me.BtnBackMap.Size = New System.Drawing.Size(75, 23)
        Me.BtnBackMap.TabIndex = 3
        Me.BtnBackMap.Text = "Back"
        Me.BtnBackMap.UseVisualStyleBackColor = True
        '
        'BtnNextVariables
        '
        Me.BtnNextVariables.Location = New System.Drawing.Point(442, 440)
        Me.BtnNextVariables.Name = "BtnNextVariables"
        Me.BtnNextVariables.Size = New System.Drawing.Size(75, 23)
        Me.BtnNextVariables.TabIndex = 2
        Me.BtnNextVariables.Text = "Next"
        Me.BtnNextVariables.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(355, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Please select your database and the version of Microsoft Access you use:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Database"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'EMailPanel
        '
        Me.EMailPanel.Controls.Add(Me.TbxEMailPassword)
        Me.EMailPanel.Controls.Add(Me.TbxEMailPort)
        Me.EMailPanel.Controls.Add(Me.BtnBackToVariables)
        Me.EMailPanel.Controls.Add(Me.TbxEMailServer)
        Me.EMailPanel.Controls.Add(Me.TbxEMailAddress)
        Me.EMailPanel.Controls.Add(Me.Label15)
        Me.EMailPanel.Controls.Add(Me.Label16)
        Me.EMailPanel.Controls.Add(Me.Label17)
        Me.EMailPanel.Controls.Add(Me.Label18)
        Me.EMailPanel.Controls.Add(Me.BtnToFinish)
        Me.EMailPanel.Controls.Add(Me.Label13)
        Me.EMailPanel.Controls.Add(Me.Label14)
        Me.EMailPanel.Location = New System.Drawing.Point(15, 10)
        Me.EMailPanel.Name = "EMailPanel"
        Me.EMailPanel.Size = New System.Drawing.Size(521, 466)
        Me.EMailPanel.TabIndex = 8
        Me.EMailPanel.Visible = False
        '
        'TbxEMailPassword
        '
        Me.TbxEMailPassword.Location = New System.Drawing.Point(103, 86)
        Me.TbxEMailPassword.Name = "TbxEMailPassword"
        Me.TbxEMailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxEMailPassword.Size = New System.Drawing.Size(381, 20)
        Me.TbxEMailPassword.TabIndex = 13
        '
        'TbxEMailPort
        '
        Me.TbxEMailPort.Location = New System.Drawing.Point(103, 139)
        Me.TbxEMailPort.Name = "TbxEMailPort"
        Me.TbxEMailPort.Size = New System.Drawing.Size(73, 20)
        Me.TbxEMailPort.TabIndex = 14
        '
        'BtnBackToVariables
        '
        Me.BtnBackToVariables.Location = New System.Drawing.Point(12, 434)
        Me.BtnBackToVariables.Name = "BtnBackToVariables"
        Me.BtnBackToVariables.Size = New System.Drawing.Size(75, 23)
        Me.BtnBackToVariables.TabIndex = 4
        Me.BtnBackToVariables.Text = "Back"
        Me.BtnBackToVariables.UseVisualStyleBackColor = True
        '
        'TbxEMailServer
        '
        Me.TbxEMailServer.Location = New System.Drawing.Point(103, 115)
        Me.TbxEMailServer.Name = "TbxEMailServer"
        Me.TbxEMailServer.Size = New System.Drawing.Size(174, 20)
        Me.TbxEMailServer.TabIndex = 15
        '
        'TbxEMailAddress
        '
        Me.TbxEMailAddress.Location = New System.Drawing.Point(103, 61)
        Me.TbxEMailAddress.Name = "TbxEMailAddress"
        Me.TbxEMailAddress.Size = New System.Drawing.Size(381, 20)
        Me.TbxEMailAddress.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "E-Mail Server:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "E-Mail Password:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 142)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "E-Mail Port:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "E-Mail Address:"
        '
        'BtnToFinish
        '
        Me.BtnToFinish.Location = New System.Drawing.Point(443, 434)
        Me.BtnToFinish.Name = "BtnToFinish"
        Me.BtnToFinish.Size = New System.Drawing.Size(75, 23)
        Me.BtnToFinish.TabIndex = 2
        Me.BtnToFinish.Text = "Next"
        Me.BtnToFinish.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Please enter your e-mail server settings:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 31)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "E-Mail"
        '
        'SetupWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 485)
        Me.Controls.Add(Me.EMailPanel)
        Me.Controls.Add(Me.AdminPanel)
        Me.Controls.Add(Me.MapPanel)
        Me.Controls.Add(Me.FinishPanel)
        Me.Controls.Add(Me.DatabasePanel)
        Me.Controls.Add(Me.VariablesPanel)
        Me.Name = "SetupWizard"
        Me.Text = "Setup Wizard"
        Me.FinishPanel.ResumeLayout(False)
        Me.FinishPanel.PerformLayout()
        Me.AdminPanel.ResumeLayout(False)
        Me.AdminPanel.PerformLayout()
        Me.VariablesPanel.ResumeLayout(False)
        Me.VariablesPanel.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GbxMultipliers.ResumeLayout(False)
        Me.GbxMultipliers.PerformLayout()
        Me.MapPanel.ResumeLayout(False)
        Me.MapPanel.PerformLayout()
        CType(Me.NudFuelCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatabasePanel.ResumeLayout(False)
        Me.DatabasePanel.PerformLayout()
        Me.EMailPanel.ResumeLayout(False)
        Me.EMailPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FinishPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnFinish As System.Windows.Forms.Button
    Friend WithEvents DatabasePanel As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBackToAdmin As System.Windows.Forms.Button
    Friend WithEvents BtnNextVariables As System.Windows.Forms.Button
    Friend WithEvents BtnBackMap As System.Windows.Forms.Button
    Friend WithEvents TbxDatabaseDirectory As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MapPanel As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TbxMapDirectory As System.Windows.Forms.TextBox
    Friend WithEvents BtnBackAdmin As System.Windows.Forms.Button
    Friend WithEvents BtnNextDatabase As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AdminPanel As System.Windows.Forms.Panel
    Friend WithEvents BtnViewPassword As System.Windows.Forms.Button
    Friend WithEvents TbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnNextMap As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbxEncryptedPassword As System.Windows.Forms.TextBox
    Friend WithEvents VariablesPanel As System.Windows.Forms.Panel
    Friend WithEvents BtnBackToDatabase As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnNextEmail As System.Windows.Forms.Button
    Friend WithEvents GbxMultipliers As System.Windows.Forms.GroupBox
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents TbxFruitMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents TbxChocolateMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents TbxSpongeMultiplier As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TbxCostPerServing As System.Windows.Forms.TextBox
    Friend WithEvents TbxDeposit As System.Windows.Forms.TextBox
    Friend WithEvents TbxVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TbxLowStockThreshold As System.Windows.Forms.TextBox
    Friend WithEvents TbxSupplierEmail As System.Windows.Forms.TextBox
    Friend WithEvents TbxSupplierURL As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents BtnLoadMap As System.Windows.Forms.Button
    Friend WithEvents CbxPossibleOrigins As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NudFuelCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EMailPanel As System.Windows.Forms.Panel
    Friend WithEvents BtnToFinish As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TbxEMailPassword As System.Windows.Forms.TextBox
    Friend WithEvents TbxEMailPort As System.Windows.Forms.TextBox
    Friend WithEvents BtnBackToVariables As System.Windows.Forms.Button
    Friend WithEvents TbxEMailServer As System.Windows.Forms.TextBox
    Friend WithEvents TbxEMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
