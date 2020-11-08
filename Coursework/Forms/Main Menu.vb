Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Public Class MainMenu
    Dim CurrentOrderNotified As Boolean
    Dim CurrentCustomer As Customer
    Dim Priority As Order
    Dim TempStock As Stock = Nothing
    Dim TempOrder As Order = Nothing
    Dim TempDocument As Document = Nothing
    Dim CustomerIndex() As Integer
    Dim OrderIndex() As Integer
    Dim DocumentCustomer As Customer
    Dim DocumentOrder As Order
    Private Sub SwitchUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchUserToolStripMenuItem.Click
        AdminRightsForm.Show() 'Load the login module for administrator access
    End Sub
    Sub LoadSettings()

        FileOpen(1, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Createabake\Settings.cbm", OpenMode.Input) 'Opens the settings from its directory
        Try 'In case of file tampering - the program is protected from crashing
            DatabaseProvider = LineInput(1) 'Load database provider
            AdminEncryptedPassword = LineInput(1) 'Load admin settings access password
            DatabaseDirectory = LineInput(1) 'Load database directory
            MapDirectory = LineInput(1) 'Load map directory
            SpongeMultiplier = LineInput(1) 'Load the multiplier for a sponge cake
            FruitMultiplier = LineInput(1) 'Load the multiplier for a fruit cake
            ChocolateMultiplier = LineInput(1) 'Load the multiplier for a chocolate cake
            CostPerServingMultiplier = LineInput(1) 'Load the multiplier for each serving
            DepositPercent = LineInput(1) 'Load the deposit percentage
            VAT = LineInput(1) 'Load the Value Added Tax percentage
            SupplierURL = LineInput(1) 'Load the web address of the supplier's website
            SupplierEMail = LineInput(1) 'Load the supplier's e-mail address
            LowStockThreshold = LineInput(1) 'Load the low stock threshold
            DeliveryOriginName = LineInput(1) 'Load the starting point for deliveries
            FuelCostPerMile = LineInput(1) 'Load the fuel cost per mile
            EMailServer = LineInput(1)
            EMailPort = LineInput(1)
            EMailUser = LineInput(1)
        Catch er As Exception 'If the file has been tampered with...
            MsgBox("Your settings could not be applied: " & vbCr & er.Message, MsgBoxStyle.Critical, "Error") '...display a relevant error message
        End Try
        FileClose(1) 'Close the file so the IO allocation can be re-used
    End Sub
    Sub SortLowStock()
        For count = 0 To Stocks.Length - 1 'For the length of the stock array
            If Stocks(count).Quantity < LowStockThreshold Then 'If the stock level is less than the set "Low Stock Level"
                ClbLowStock.Items.Add(Stocks(count).Item) 'Add the stock item to the low stock list
            End If
        Next
    End Sub
    Sub LoadAll()
        TspLoadingBar.Style = Windows.Forms.ProgressBarStyle.Continuous 'Set the progress bar to be quantifiable
        TssLoadingStatus.Text = "Initialising database" 'Set the label text to relevant loading information
        DatabaseHandling.DataSetVar.Clear() 'Clears the database dataset for new data to be input
        TspLoadingBar.Value = 20 'Sets the progress bar to 20%
        TssLoadingStatus.Text = "Loading customers" 'Set the label text to relevant loading information
        LoadCustomers() 'Loads customer information
        TspLoadingBar.Value = 25 'Sets the progress bar to 25%
        TssLoadingStatus.Text = "Loading orders" 'Set the label text to relevant loading information
        LoadOrders() 'Loads order information
        TspLoadingBar.Value = 30 'Sets the progress bar to 30%
        TssLoadingStatus.Text = "Loading stock" 'Set the label text to relevant loading information
        LoadStock() 'Loads stock information
        TspLoadingBar.Value = 35 'Sets the progress bar to 35%
        TssLoadingStatus.Text = "Loading low stock" 'Set the label text to relevant loading information
        LoadLowStock() 'Loads the low stock list
        TspLoadingBar.Value = 40 'Sets the progress bar to 40%
        TssLoadingStatus.Text = "Loading order dates" 'Set the label text to relevant loading information
        LoadOrderDates() 'Loads the order dates
        TspLoadingBar.Value = 45 'Sets the progress bar to 45%
        TssLoadingStatus.Text = "Loading current orders" 'Set the label text to relevant loading information
        LoadCurrentOrders() 'Loads the current order dates that are unfinished
        TspLoadingBar.Value = 50 'Sets the progress bar to 50%
        TssLoadingStatus.Text = "Loading finances" 'Set the label text to relevant loading information
        LoadFinances() 'Loads the finance information from the database
        TspLoadingBar.Value = 55 'Sets the progress bar to 55%
        TssLoadingStatus.Text = "Loading route planning" 'Set the label text to relevant loading information
        Try
            RouteFinding.InitialiseMap(Map, Variables.MapDirectory)
            TspLoadingBar.Value = 60 'Sets the progress bar to 60%
            TssLoadingStatus.Text = "Loading locations" 'Set the label text to relevant loading information
            LoadRouteLocations() 'Loads the locations from the map file
            TspLoadingBar.Value = 65 'Sets the progress bar to 65%
        Catch err As Exception
            MsgBox("Map could not be loaded:" & vbCr & err.Message & vbCr & "Delivery will not be available", MsgBoxStyle.Exclamation, "Map Corrupted")
            TbcMainMenu.TabPages.RemoveAt(2)
        End Try
        TssLoadingStatus.Text = "Loading statistics" 'Set the label text to relevant loading information
        LoadStatistics() 'Loads analysis information from the database
        TspLoadingBar.Value = 70 'Sets the progress bar to 70%
        TssLoadingStatus.Text = "Loading admin control" 'Set the label text to relevant loading information
        LoadAdminValues()
        TspLoadingBar.Value = 75 'Sets the progress bar to 75%
        Try
            TssLoadingStatus.Text = "Setting delivery origin" 'Set the label text to relevant loading information
            DeliveryOrigin = FindVertex(Map, DeliveryOriginName)
        Catch err As Exception
        End Try
        TspLoadingBar.Value = 80 'Sets the progress bar to 80%
        TssLoadingStatus.Text = "Loading outstanding payments" 'Set the label text to relevant loading information
        LoadOutstandingPayments()
        TspLoadingBar.Value = 85
        TssLoadingStatus.Text = "Loading document directories" 'Set the label text to relevant loading information
        DatabaseHandling.LoadDocuments()
        TspLoadingBar.Value = 90
        TssLoadingStatus.Text = "Loading list of available documents" 'Set the label text to relevant loading information
        LoadDocuments()
        TspLoadingBar.Value = 95
        TssLoadingStatus.Text = "Loading E-Mail settings" 'Set the label text to relevant loading information

        TspLoadingBar.Value = 100
        TssLoadingStatus.Text = "" 'Clear the label text
        TspLoadingBar.Style = Windows.Forms.ProgressBarStyle.Marquee
    End Sub
    Sub LoadLowStock()
        ClbLowStock.Items.Clear() 'Removes all of the items from the Low Stock List view
        ReDim LowStockIndex(0) 'Reinitialises the Low Stock Array
        For Count = 0 To Stocks.Length - 1
            If Stocks(Count).Quantity < LowStockThreshold Then
                ClbLowStock.Items.Add(Stocks(Count).Item) 'Adds an item of stock that is low to the list view
                LowStockIndex(LowStockIndex.Length - 1) = Stocks(Count).StockID 'Adds the connecting ID to an array to lookup the info
                ReDim Preserve LowStockIndex(LowStockIndex.Length) 'Adds another memory location onto the array
            End If
        Next
    End Sub

    Sub LoadOutstandingPayments()
        ReDim OutstandingPaymentsIndex(0) 'Reinitialises the Payment ID Array
        Dim CurrentCustomer As Customer 'Creates a new temporary structure for use with this subroutine
        LbxOutstandingPayments.Items.Clear() 'Clears the list containing unpaid payments
        For count = 0 To Orders.Length - 1
            If Orders(count).PaidDeposit = False Or Orders(count).PaidInFull = False Then
                CurrentCustomer = FindCustomer(Orders(count).CustomerIDLink) 'Assigns a customer record to the temporary customer using the customer's ID connected to the order
                LbxOutstandingPayments.Items.Add(Orders(count).OrderID & ". " & CurrentCustomer.Forename & " " & CurrentCustomer.Surname & ": " & Orders(count).OrderDetails)
                OutstandingPaymentsIndex(OutstandingPaymentsIndex.Length - 1) = Orders(count).OrderID 'Adds the outstanding payments ID to the array
                ReDim Preserve OutstandingPaymentsIndex(OutstandingPaymentsIndex.Length) 'Reinitialises the array to add one more memory location
            End If
        Next
    End Sub
    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReDim CurrentOrderIndex(0) 'Reinitialises the Current Orders Array
        ReDim Customers(0) 'Reinitialises the Customer Array

        If My.Settings.FirstRun = True Then
            SetupWizard.Show()
            Me.Close()
        Else
            LoadSettings() 'Loads settings variables from the settings file
            LoadAll() 'Loads all variables and relative settings
            Try
                EMailPasswordForm.Show()
            Catch er As Exception
            End Try
        End If
    End Sub
    Sub LoadDocuments()
        LbxDocuments.Items.Clear() 'Removes all items from the list of documents
        For Counter = 0 To Documents.Length - 1
            LbxDocuments.Items.Add(Documents(Counter).DocumentName) 'Adds any un-added documents to the document list
        Next
    End Sub
    Sub LoadRouteLocations()
        CbxStartLocation.Items.Clear() 'Clears the combobox containing the start vertices
        CbxEndLocation.Items.Clear() 'Clears the combobox containing the end vertices
        For counter = 0 To Map.Vertex.Length - 1 'Loops for the length of the amount of map vertices 
            CbxStartLocation.Items.Add(Map.Vertex(counter).Name) 'Re-adds the updated vertices to the start location combobox
            CbxEndLocation.Items.Add(Map.Vertex(counter).Name) 'Re-adds the updated vertices to the end location combobox
        Next
    End Sub
    Sub LoadAdminValues()
        TbxChocolateMultiplier.Text = ChocolateMultiplier 'Sets the form textbox to its equivalent variable
        TbxSpongeMultiplier.Text = SpongeMultiplier 'Sets the form textbox to its equivalent variable
        TbxFruitMultiplier.Text = FruitMultiplier 'Sets the form textbox to its equivalent variable
        TbxDatabaseDirectory.Text = DatabaseDirectory 'Sets the form textbox to its equivalent variable
        TbxVAT.Text = VAT 'Sets the form textbox to its equivalent variable
        TbxCostPerServing.Text = CostPerServingMultiplier 'Sets the form textbox to its equivalent variable
        TbxLowStockThreshold.Text = LowStockThreshold 'Sets the form textbox to its equivalent variable
        TbxSupplierEmail.Text = SupplierEMail 'Sets the form textbox to its equivalent variable
        TbxSupplierURL.Text = SupplierURL 'Sets the form textbox to its equivalent variable
        TbxDeposit.Text = DepositPercent 'Sets the form textbox to its equivalent variable
        NudFuelCostPerMile.Value = FuelCostPerMile 'Sets the form textbox to its equivalent variable
        Try
            For count = 0 To Map.Vertex.Length - 1 'Loops for the amount of map vertices
                CbxDeliveryOrigin.Items.Add(Map.Vertex(count).Name) 'Adds the map vertices to the origin
            Next
            CbxDeliveryOrigin.SelectedIndex = FindIndex(Map, DeliveryOriginName) 'Locates the selected vertex in the storage map
        Catch err As Exception
        End Try
    End Sub

    Sub LoadCurrentOrders()

        LbxCurrentOrders.Items.Clear() 'Clears the current order list
        PopulatePriorityQueue() 'Calls a function to calculate the priority of the orders
        If PriorityQueue.Length > 0 Then 'Makes sure there is more than one order in the queue
            SortPriorityQueue() 'Sorts the priority of the orders in the queue
            SetPriority() 'Sets the individual priorities
        End If
        Dim CurrentOrderSize As Integer = 0
        For Count = 0 To PriorityQueue.Length - 1 'Loops for the amount of orders in the priority queue

            CurrentCustomer = FindCustomer(PriorityQueue(Count).CustomerIDLink) 'Sets the current customer to the customer with the ID stored in the priority queue
            LbxCurrentOrders.Items.Add(PriorityQueue(Count).OrderID & ". " & CurrentCustomer.Forename & " " & CurrentCustomer.Surname & ": " & PriorityQueue(Count).OrderDetails) 'Adds the orders in the priority queue to a visual representation of the ID codes (a list of the order details)
            CurrentOrderIndex(CurrentOrderIndex.Length - 1) = PriorityQueue(Count).OrderID 'Sets the upper bound of the Current Order Index to the order ID of the currently selected priority queue
            If PriorityQueue(Count).Deadline.Date = Now.Date And CurrentOrderNotified = False Then 'Checks if there are any orders due for Today
                MsgBox("Order #" & PriorityQueue(Count).OrderID & ": " & PriorityQueue(Count).OrderDetails & " has reached its deadline." & vbCr & "Please ensure the order is completed and delivered before the end of business hours!", MsgBoxStyle.Information, "Order deadline") 'Displays a notification message about the due order
            End If
            ReDim Preserve CurrentOrderIndex(CurrentOrderIndex.Length) 'Increases the size of the Current Order Index array by one element
        Next
        CurrentOrderNotified = True 'Stores that the notification message has been shown to the user
    End Sub
    Sub SetPriority()
        Priority = CurrentPriority(PriorityQueue) 'Sets the highest priority order from the priority queue
        RtbCurrentOrderDescription.Text = Priority.OrderDetails 'Displays the highest priority orders serving size
        NudCurrentServingSize.Value = Priority.ServingSize 'Displays the highest priority orders serving size
        RtbCurrentConsiderations.Text = Priority.SpecialConsiderations 'Displays the highest priority orders special considerations
        DtpCurrentDeadline.Value = Priority.Deadline.Date 'Displays the highest priority orders special considerations
        CurrentCustomer = FindCustomer(Priority.CustomerIDLink) 'Sets the current customer variable to the customer with the ID linked to the highest priority order
        TbxForename.Text = CurrentCustomer.Forename 'Displays the highest priority orders cutomers forename
        TbxSurname.Text = CurrentCustomer.Surname 'Displays the highest priority orders cutomers surname
        TbxEmail.Text = CurrentCustomer.EMailAddress 'Displays the highest priority orders cutomers e-mail address
        TbxPhone.Text = CurrentCustomer.PhoneNumber 'Displays the highest priority orders cutomers phone number
        TbxPostcode.Text = CurrentCustomer.Postcode 'Displays the highest priority orders cutomers postcode
        TbxTown.Text = CurrentCustomer.Town 'Displays the highest priority orders cutomers town
    End Sub
    Sub LoadOrderDates()
        For count = 0 To Variables.Orders.Length - 1 'Loops for the amount of orders
            OrderCalendar.AddBoldedDate(Variables.Orders(count).Deadline.Date) 'Sets the order dates to bold in the calendar view
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() 'Quits the application
    End Sub


    Private Sub BtnEditMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditMap.Click
        Edit_Map.Show() 'Opens the map editing form
    End Sub

    Private Sub TsbLogoutAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbLogoutAdmin.Click
        IsAdmin = False 'The user is not an admin
        GbxAdminPanel.Enabled = False 'The user cannot access admin controls
        TsbLogoutAdmin.Visible = False 'The user cannot logout an account that isn't logged in
        TsbLogoutAdmin.Enabled = False 'The user cannot logout an account that isn't logged in
        TsbChangePassword.Enabled = False 'The user cannot change the password of an account that they do not have access to
        TsbChangePassword.Visible = False 'The user cannot change the password of an account that they do not have access to
        LblUsername.Text = "Default User" 'The standard user (non-admin) username
        LblUsername.ForeColor = Drawing.Color.Black 'Sets the username colour to black (to indicate they are not in admin-mode)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Are you sure you want to select all low stock?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then 'Asks the user if they want to select all low stock
            For Counter = 0 To ClbLowStock.Items.Count - 1 'Loops for the length of the low stock list
                ClbLowStock.SetItemChecked(Counter, True) 'Checks the selected low stock item
            Next
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click
        If MsgBox("Are you sure you want to mark this order as complete?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then 'Asks the user if they want to set the order to completed
            CompleteOrder(Priority) 'Calls the function to set the order as completed
            LoadAll() 'Reloads all information required to run the program
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MsgBox("Are you sure you want to deselect all low stock?", MsgBoxStyle.YesNo, "Confirmation") = vbYes Then 'Asks the user if they want to deselect low stock items
            For Counter = 0 To ClbLowStock.Items.Count - 1 'Loops for the length of the low stock list
                ClbLowStock.SetItemChecked(Counter, False) 'Deselects the current low stock item
            Next
        End If
    End Sub

    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim emailprocess As String
        emailprocess = "mailto:" & TbxEmail.Text 'Acts as an e-mail command alongside the e-mail that the message is intended for
        Try
            System.Diagnostics.Process.Start(emailprocess) 'Executes the command
        Catch er As Exception
            MsgBox(er.Message.ToString & vbCr & "System may not have an e-mail client available") 'If there is an error, suggest that it is due to the configuration or non-existence of an e-mail client
        End Try
    End Sub

    Private Sub LbxCurrentOrders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxCurrentOrders.SelectedIndexChanged
        Dim TempOrder As Order
        If LbxCurrentOrders.SelectedItem.ToString <> Nothing Then
            BtnFullViewOrder.Enabled = True 'If something is selected, allow the full view button to be accessed
        Else
            BtnFullViewOrder.Enabled = False 'If nothing is selected, disallow the full view button from being accessed
        End If
        Try
            TempOrder = FindOrder(CurrentOrderIndex(LbxCurrentOrders.SelectedIndex)) 'Sets the temporder variable (used for data manipulation and interpretation) to the selected order
            RtbOrderInformation.Text = TempOrder.OrderDetails 'Displays the TempOrders order details
            RtbConsiderations.Text = TempOrder.SpecialConsiderations 'Displays the TempOrders special considerations
            LblDeadline.Text = TempOrder.Deadline 'Displays the TempOrders deadline
            LblETA.Text = DetermineCompletion(TempOrder, "HOURS") & " hours" 'Displays how long the program estimates the order will take

            LblLatestStart.Text = LatestStart(TempOrder) 'Displays (from the previous estimation) the latest time the order can be started and still be deliverable for the deadline
        Catch er As Exception
            MsgBox("Select a value") 'Asks the user to select a value
        End Try
    End Sub
    Function FindOrder(ByVal OrderID As Integer)
        For count = 0 To Orders.Length - 1 'Loop for the amount of orders
            If Orders(count).OrderID = OrderID Then 'If the Order ID of the currently selected order is the one we're looking for...
                Return Orders(count) 'Select this order as the required order and return it
                Exit Function
            Else
            End If
        Next
    End Function

    Private Sub TbxSpongeMultiplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSpongeMultiplier.TextChanged
        If IsNumeric(TbxSpongeMultiplier.Text) = True Then 'Makes sure the sponge multiplier value is numeric
            SpongeMultiplier = TbxSpongeMultiplier.Text 'Sets the sponge multiplier to the entered value
        Else
            TbxSpongeMultiplier.Clear() 'If it's not numeric, clear the textbox
        End If
    End Sub

    Private Sub TbxChocolateMultiplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxChocolateMultiplier.TextChanged
        If IsNumeric(TbxChocolateMultiplier.Text) = True Then 'Makes sure the chocolate multiplier value is numeric
            ChocolateMultiplier = TbxChocolateMultiplier.Text 'Sets the sponge multiplier to the entered value
        Else
            TbxChocolateMultiplier.Clear() 'If it's not numeric, clear the textbox
        End If

    End Sub

    Private Sub TbxFruitMultiplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxFruitMultiplier.TextChanged
        If IsNumeric(TbxFruitMultiplier.Text) = True Then 'Makes sure the fruit multiplier value is numeric
            FruitMultiplier = TbxFruitMultiplier.Text 'Sets the sponge multiplier to the entered value
        Else
            TbxFruitMultiplier.Clear() 'If it's not numeric, clear the textbox
        End If
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        Dim OpenNewOrder As New NewOrder 'Sets OpenNewOrder as an instance of the new order form
        OpenNewOrder.Show() 'Opens the new order form
    End Sub

    Private Sub TbxCostPerServing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxCostPerServing.TextChanged
        If IsNumeric(TbxCostPerServing.Text) = True Then 'Makes sure the cost per serving value is numeric
            CostPerServingMultiplier = TbxCostPerServing.Text 'Sets the cost per serving to the entered value
        Else
            TbxCostPerServing.Clear() 'If it's not numeric, clear the textbox
        End If
    End Sub

    Private Sub TbxDeposit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxDeposit.TextChanged
        If IsNumeric(TbxDeposit.Text) = True Then 'Makes sure the deposit value is numeric
            DepositPercent = TbxDeposit.Text 'Sets the depost to the entered value
        Else
            TbxDeposit.Clear() 'If it's not numeric, clear the textbox
        End If

    End Sub

    Private Sub TbxVAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxVAT.TextChanged
        If IsNumeric(TbxVAT.Text) = True Then 'Makes sure the VAT value is numeric
            VAT = TbxVAT.Text 'Sets the VAT to the entered value
        Else
            TbxVAT.Clear() 'If it's not numeric, clear the textbox
        End If

    End Sub

    Private Sub BtnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveSettings.Click
        SetupWizard.SaveSettings() 'Calls the save settings function (saves all variable values)
        LoadAll() 'Calls the load all function (loads all variable values into the program)
        MsgBox("Settings saved!", MsgBoxStyle.OkOnly, "Settings") 'Tells the user that the settings ahve been saved
    End Sub

    Private Sub BtnRefreshStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshStatistics.Click
        LoadStatistics() 'Calls the load statistics function (loads calculation results from various variables e.g. Total Profit - Total Loss --> Net Profit)
    End Sub
    Sub LoadStatistics()
        Dim TempCounter As Integer = 0
        Dim TempNeg As Double = 0
        Dim TempPos As Double = 0
        TbxCustomerCount.Text = Customers.Length 'Displays the amount of customers in the database
        TbxOrderCount.Text = Orders.Length 'Displays the amount of orders in the database
        For count = 0 To Orders.Length - 1
            If Orders(count).Deadline.Date < Today.Date And Orders(count).Completed = False Then
                TempCounter += 1
            End If
        Next
        TbxMissedOrders.Text = TempCounter
        TempCounter = 0
        For count = 0 To Finances.Length - 1
            If Finances(count).Amount > 0 Then
                TempPos = TempPos + Finances(count).Amount
            End If
            If Finances(count).Amount < 0 Then
                TempNeg = TempNeg + Finances(count).Amount
            End If
            TempCounter = TempCounter + Finances(count).Amount
        Next
        TbxTotalProfit.Text = TempPos
        TbxTotalLoss.Text = TempNeg
        TbxTotalNetProfit.Text = TempCounter

    End Sub

    Private Sub TbxSupplierURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSupplierURL.TextChanged
        SupplierURL = TbxSupplierURL.Text
    End Sub

    Private Sub TbxSupplierEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSupplierEmail.TextChanged
        SupplierEMail = TbxSupplierEmail.Text
    End Sub

    Private Sub TbxLowStockThreshold_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxLowStockThreshold.TextChanged

        If IsNumeric(TbxLowStockThreshold.Text) = True Then
            LowStockThreshold = TbxLowStockThreshold.Text
        Else
            TbxLowStockThreshold.Clear()
        End If
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustomerToolStripMenuItem.Click
        NewCustomer.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCustomer.Click
        NewCustomer.Show()
    End Sub

    Private Sub SearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchCustomer.Click
        FindCustomerBySurname(TbxSearchSurname.Text)
    End Sub

    Private Sub ClbLowStock_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ClbLowStock.ItemCheck

    End Sub

    Private Sub ClbLowStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClbLowStock.SelectedIndexChanged
        TempStock = FindStock(LowStockIndex(ClbLowStock.SelectedIndex))
        If ClbLowStock.CheckedItems.Count > 0 Then
            BtnRestock.Enabled = True
        Else
            BtnRestock.Enabled = False
        End If
        Try
            TbxItemName.Text = TempStock.Item
            TbxItemQuantity.Text = TempStock.Quantity
            TbxItemCost.Text = "£" & TempStock.Cost
            TbxStatus.Text = TempStock.Status
            ChbxDiscrepancy.Checked = TempStock.Discrepancy
            ChbxReOrdered.Checked = TempStock.Ordered
            NudRestockQuantity.Value = TempStock.RestockQuantity
        Catch er As Exception

        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestock.Click
        Dim SupplyList(0) As String
        Dim CheckedItemIndex(0) As Integer
        Dim RestockFinance As Finance
        For Count = 0 To ClbLowStock.CheckedItems.Count - 1
            SupplyList(Count) = ClbLowStock.CheckedItems(Count)
            ReDim Preserve SupplyList(SupplyList.Length)
        Next
        For Count = 0 To ClbLowStock.Items.Count - 1
            If ClbLowStock.GetItemChecked(Count) = True Then
                CheckedItemIndex(CheckedItemIndex.Length - 1) = Count
                ReDim Preserve CheckedItemIndex(CheckedItemIndex.Length)
            End If
        Next
        If MsgBox("You have added to the inventory:" & vbCr & GetSupplyFromList(SupplyList, True) & vbCr & "Confirm restock?", MsgBoxStyle.YesNo, "Confirm Restock") = vbYes Then
            RestockFinance.Description = "RESTOCK: "
            For Count = 0 To ClbLowStock.Items.Count - 1
                If ClbLowStock.CheckedItems.Contains(ClbLowStock.Items(Count)) Then
                    TempStock = FindStock(LowStockIndex(Count))
                    TempStock.Ordered = True
                    TempStock.Quantity = TempStock.RestockQuantity + TempStock.Quantity
                    RestockFinance.Amount = RestockFinance.Amount - (TempStock.Cost * TempStock.RestockQuantity)
                    TempStock.RestockQuantity = 0

                    If Count <> 0 Then
                        RestockFinance.Description = RestockFinance.Description & ", " & ClbLowStock.CheckedItems(Count).ToString
                    Else
                        RestockFinance.Description = RestockFinance.Description & ClbLowStock.CheckedItems(Count).ToString
                    End If
                    UpdateStockStatus(TempStock)
                End If


            Next

            RestockFinance.FinanceDate = Today.Date
            RestockFinance.Type = "LOSS"
            AddFinance(RestockFinance)
            LoadAll()
        End If

    End Sub
    Function GetSupplyFromList(ByVal SupplyList() As String, Optional ByVal AsString As Boolean = True)
        Dim StringList As String = Nothing
        If AsString = True Then
            For Count = 0 To SupplyList.Length - 1
                If Count = 0 Or Count = SupplyList.Length - 1 Then
                    StringList = StringList & SupplyList(Count)
                Else
                    StringList = StringList & ", " & SupplyList(Count)
                End If

            Next
            Return StringList
        Else
            For Count = 0 To SupplyList.Length - 1
                Return SupplyList(Count) & vbCr
            Next
        End If

    End Function
    Private Sub CbxDiscrpeancy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChbxDiscrepancy.CheckedChanged

        If ChbxDiscrepancy.Checked = True Then
            Try

                TempStock.Discrepancy = ChbxDiscrepancy.Checked
            Catch er As Exception
                MsgBox(er.Message)

                UpdateStockStatus(TempStock)
            End Try
            LoadAll()
        Else
            ChbxDiscrepancy.Checked = True
        End If

    End Sub

    Private Sub BtnFullViewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFullViewOrder.Click
        Dim TempOrder As Order
        Try
            TempOrder = FindOrder(CurrentOrderIndex(LbxCurrentOrders.SelectedIndex))
            MsgBox("Customer ID: " & TempOrder.CustomerIDLink & vbCr & "Order ID: " & TempOrder.OrderID & vbCr & "Order: " & TempOrder.OrderDetails & vbCr & "Special Considerations: " & TempOrder.SpecialConsiderations & vbCr & "Serving Size: " & TempOrder.ServingSize & vbCr & "Cost: £" & TempOrder.Cost & vbCr & "Deadline: " & TempOrder.Deadline)
        Catch er As Exception
            MsgBox("An order must be selected!" & vbCr & er.Message, MsgBoxStyle.Exclamation, "Error")
        End Try


    End Sub

    Private Sub BtnEmailSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmailSupplier.Click
        Dim emailprocess As String
        emailprocess = "mailto:" & SupplierEMail
        Try
            System.Diagnostics.Process.Start(emailprocess)
        Catch er As Exception
            MsgBox(er.Message.ToString & vbCr & "System may not have an e-mail client available")
        End Try
    End Sub

    Private Sub BtnViewSupplierWebsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewSupplierWebsite.Click
        Dim webprocess As String
        webprocess = "http://" & SupplierURL
        Try
            System.Diagnostics.Process.Start(webprocess)
        Catch er As Exception
            MsgBox(er.Message.ToString & vbCr & "System may not have a browser available")
        End Try
    End Sub

    Private Sub TbxTotalNetProfit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxTotalNetProfit.TextChanged
        If TbxTotalNetProfit.Text < 0 Then
            TbxTotalNetProfit.ForeColor = Drawing.Color.Red
        Else
            TbxTotalNetProfit.ForeColor = Drawing.Color.Green
        End If
    End Sub
    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Dim TempRoute() As Vertex
        Dim MapURL As String
        RtbDistances.Clear()
        TbxOrigin.Clear()
        LbxRouteLocationOrder.Items.Clear()
        TbxOrigin.Text = CbxStartLocation.SelectedItem.ToString
        TempRoute = Dijkstra(Map, FindVertex(Map, CbxStartLocation.SelectedItem.ToString), FindVertex(Map, CbxEndLocation.SelectedItem.ToString), False)

        Try
            For count = 0 To TempRoute.Length - 1
                If TempRoute(count).Name <> Nothing Then
                    LbxRouteLocationOrder.Items.Add(TempRoute(count).Name)
                End If
            Next
            For count = 0 To PublicVisited.Length - 1
                RtbDistances.AppendText(PublicVisited(count).Name & ": " & PublicVisited(count).DistanceToStart & " miles" & vbCr)
            Next

            MapURL = "http://maps.googleapis.com/maps/api/staticmap?center=" & Trim(DeliveryOrigin.Name) & ",England&size=625x432&path="
            For count = 0 To TempRoute.Length - 1
                If count < TempRoute.Length - 1 Then
                    MapURL = MapURL & TempRoute(count).Name & "|"
                Else
                    MapURL = MapURL & TempRoute(count).Name
                End If
            Next
            Debug.Print(MapURL)
            Try
                PcbMapImage.ImageLocation = MapURL
                PcbMapImage.Load()
            Catch er As Exception
                PcbMapImage.Image = PcbMapImage.ErrorImage
                If MsgBox("Map could not be downloaded!" & vbCr & er.Message & vbCr & "Download via web browser?", MsgBoxStyle.YesNo, "Map error") = vbYes Then
                    Dim webprocess As String
                    webprocess = MapURL
                    Try
                        System.Diagnostics.Process.Start(webprocess)
                    Catch err As Exception
                        MsgBox(err.Message.ToString & vbCr & "System may not have a browser available")
                    End Try
                End If
            End Try
        Catch err As Exception
            MsgBox("There is no available route from " & CbxStartLocation.SelectedItem.ToString & " to " & CbxEndLocation.SelectedItem.ToString & "." & vbCr & "Check with an administrator that all destinations are connected bidirectionally!", MsgBoxStyle.Exclamation, "Route Not Found")
        End Try

    End Sub
    Private Sub CbxDeliveryOrigin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxDeliveryOrigin.SelectedIndexChanged
        DeliveryOrigin = FindVertex(Map, CbxDeliveryOrigin.SelectedItem.ToString)
    End Sub
    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudFuelCostPerMile.ValueChanged
        FuelCostPerMile = NudFuelCostPerMile.Value
    End Sub
    Private Sub BtnPrintShoppingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintShoppingList.Click
        Dim SupplyList(0) As String
        Dim CheckedItemIndex(0) As Integer

        For Count = 0 To ClbLowStock.CheckedItems.Count - 1
            SupplyList(Count) = ClbLowStock.CheckedItems(Count)
            ReDim Preserve SupplyList(SupplyList.Length)
        Next
        For Count = 0 To ClbLowStock.Items.Count - 1
            If ClbLowStock.GetItemChecked(Count) = True Then
                CheckedItemIndex(CheckedItemIndex.Length - 1) = Count
                ReDim Preserve CheckedItemIndex(CheckedItemIndex.Length)
            End If
        Next

        If MsgBox("Print shopping list?", vbYesNo, "Shopping List") = vbYes Then
            PrintShoppingList(SupplyList)
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        OrderArchive.Show()
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        FinanceArchive.Show()
    End Sub
    Private Sub LbxOutstandingPayments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxOutstandingPayments.SelectedIndexChanged
        Try
            If LbxOutstandingPayments.SelectedItem.ToString <> Nothing Then
                BtnFullViewOrder.Enabled = True
            Else
                BtnFullViewOrder.Enabled = False

            End If
        Catch er As Exception

        End Try
        Try
            TempOrder = FindOrder(OutstandingPaymentsIndex(LbxOutstandingPayments.SelectedIndex))
            TbxDepositAmount.Text = "£" & (TempOrder.Cost / 100) * Variables.DepositPercent
            TbxFullCost.Text = "£" & TempOrder.Cost
            If TempOrder.PaidDeposit = True Then
                BtnDepositPaid.Enabled = False
                BtnFullyPaid.Enabled = True
            Else
                BtnDepositPaid.Enabled = True
                BtnFullyPaid.Enabled = False
            End If
        Catch er As Exception
            MsgBox("Select a value")
        End Try
    End Sub
    Private Sub BtnDepositPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDepositPaid.Click
        Dim TempOrder As Order
        Dim TempFinance As Finance = Nothing
        TempOrder = FindOrder(OutstandingPaymentsIndex(LbxOutstandingPayments.SelectedIndex))
        TempOrder.PaidDeposit = True
        TempFinance.Amount = (TempOrder.Cost / 100) * Variables.DepositPercent
        TempFinance.Description = "DEPOSIT: " & TempOrder.OrderDetails
        TempFinance.OrderIDLink = TempOrder.OrderID
        TempFinance.FinanceDate = Now.Date
        UpdateOrder(TempOrder)
        AddFinance(TempFinance)
        LoadAll()
    End Sub
    Private Sub BtnFullyPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFullyPaid.Click
        Dim TempOrder As Order
        Dim TempFinance As Finance = Nothing
        TempOrder = FindOrder(OutstandingPaymentsIndex(LbxOutstandingPayments.SelectedIndex))
        TempFinance.Amount = TempOrder.Cost - ((TempOrder.Cost / 100) * Variables.DepositPercent)
        TempFinance.Description = "FULL PAYMENT: " & TempOrder.OrderDetails
        TempFinance.OrderIDLink = TempOrder.OrderID
        TempFinance.FinanceDate = Now.Date
        If TempOrder.PaidDeposit = True Then
            TempOrder.PaidInFull = True
            UpdateOrder(TempOrder)
            AddFinance(TempFinance)
        End If
        LoadAll()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteCustomer.Click
        DeleteCustomer.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteOrder.Click
        DeleteOrder.Show()
    End Sub
    Private Sub BtnAddStockItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddStockItem.Click
        AddStock.Show()
    End Sub
    Private Sub BtnEditStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditStock.Click
        EditStock.Show()
    End Sub
    Private Sub NudRestockQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudRestockQuantity.ValueChanged
        If NudRestockQuantity.Value > 0 Then
            TempStock.RestockQuantity = NudRestockQuantity.Value
            UpdateStockStatus(TempStock)
        End If
        LoadAll()
    End Sub
    Private Sub BtnEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditCustomer.Click
        EditCustomer.Show()
    End Sub
    Private Sub BtnEditOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditOrder.Click
        EditOrder.Show()
    End Sub
    Private Sub BtnDeleteStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteStock.Click, BtnDeleteDocument.Click
        DeleteDocument.Show()
    End Sub
    Private Sub BtnDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDocument.Click
        AddDocument.Show()
    End Sub
    Private Sub LbxDocuments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxDocuments.SelectedIndexChanged
        Try
            TempDocument = FindDocumentByName(LbxDocuments.SelectedItem.ToString)
            BtnPrintDocument.Enabled = True
        Catch err As Exception
            Debug.Print(err.Message)
        End Try
        TbxDocumentName.Text = TempDocument.DocumentName
        TbxDocumentDirectory.Text = TempDocument.DocumentDirectory
    End Sub

    Private Sub BtnPrintDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintDocument.Click
        Dim Word As New Word.Application
        Dim Document As New Word.Document
      
           
                Word.Visible = False
                Document = Word.Documents.Open(TempDocument.DocumentDirectory, , False)
                Document.Activate()
        Document.Saved = False

        Word.Visible = False
            If MsgBox("Confirm print?", MsgBoxStyle.YesNo, "Printing") = vbYes Then
                Document.PrintOut()
            End If
            Document.Close()
            Word.Quit()

    End Sub
  

    Private Sub BtnViewDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewDocument.Click
        Try
            Dim Word As New Word.Application
            Dim Document As New Word.Document
            Document = Word.Documents.Open(TempDocument.DocumentDirectory)
            Document.Activate()

            Word.Visible = True
        Catch er As Exception
        End Try
    End Sub
    Private Sub BtnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackup.Click
        Dim TempBackupLocation As String
        FolderBrowserDialog.ShowDialog()
        TempBackupLocation = FolderBrowserDialog.SelectedPath
        If TempBackupLocation <> Nothing Then
            My.Computer.FileSystem.CopyDirectory(Mid(DatabaseDirectory, 1, DatabaseDirectory.Length - 17), TempBackupLocation)
            MsgBox("Backup complete", MsgBoxStyle.Information, "Backup")
        End If
    End Sub
    Private Sub TsbChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbChangePassword.Click
        ChangePassword.Show()
    End Sub
    Private Sub TbxDatabaseDirectory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxDatabaseDirectory.TextChanged
        DatabaseDirectory = TbxDatabaseDirectory.Text
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenFileDialog.ShowDialog()
        TbxDatabaseDirectory.Text = OpenFileDialog.FileName
    End Sub

    Private Sub BtnSendInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendInvoice.Click
        EMailInvoice(TempOrder, FindCustomer(TempOrder.CustomerIDLink))
    End Sub

    Private Sub BtnEmailSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmailSettings.Click
        Try
            EMailSettings.Show()
        Catch er As Exception
        End Try
    End Sub

    Private Sub GbxDocuments_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GbxDocuments.Enter

    End Sub
End Class