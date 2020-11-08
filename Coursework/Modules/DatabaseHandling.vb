Imports System.Data
Imports System.Data.OleDb
Module DatabaseHandling
#Region "Database Variables"
    Dim DatabaseConnection As String = "Provider=" & DatabaseProvider
    Dim DatabaseSource As String = "Data Source=" & DatabaseDirectory
    Dim Connection As OleDbConnection = New OleDbConnection(DatabaseConnection & DatabaseSource)
    Dim SQLCommand As String
    Dim DataAdapter As New OleDbDataAdapter
    Public DataSetVar As New DataSet
#End Region
    Sub CompleteOrder(ByRef Order As Order)
        Order.Completed = True
        Connection.Open()
        SQLCommand = "UPDATE [Order] SET [Complete]=" & Order.Completed & " WHERE [Order ID]=" & Order.OrderID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
        If MsgBox("Print delivery label?", MsgBoxStyle.YesNo, "Delivery") = vbYes Then
            PrintDeliveryLabel(Map, FindCustomer(Order.CustomerIDLink), Order, DeliveryOrigin)
        End If
        If MsgBox("Print invoice?", MsgBoxStyle.YesNo, "Invoice") = vbYes Then
            PrintInvoice(FindDocumentByName("Invoice"), Order, FindCustomer(Order.CustomerIDLink), True)
        End If
        If MsgBox("Print allergy label?", MsgBoxStyle.YesNo, "Allergy") = vbYes Then
            PrintAllergyLabel()
        End If
        If MsgBox("Print vegan label?", MsgBoxStyle.YesNo, "Vegan") = vbYes Then
            PrintVeganLabel()
        End If
    End Sub
    Sub FindCustomerBySurname(ByVal Surname As String)
        For count = 0 To MainMenu.DgvCustomer.Rows.Count - 1
            MainMenu.DgvCustomer.Rows(count).Selected = False
        Next
        For count = 0 To Customers.Length - 1
            If Customers(count).Surname.ToUpper = Surname.ToUpper Then
                MainMenu.DgvCustomer.Rows(count).Selected = True
            End If
        Next
    End Sub
#Region "Loading"
    Sub LoadOrders()
        ReDim Orders(0)
        MainMenu.LbxCurrentOrders.Items.Clear()
        SQLCommand = "SELECT * FROM [Order]"
        DataAdapter = New OleDbDataAdapter(SQLCommand, Connection)
        Connection.Open()
        DataAdapter.Fill(DataSetVar, "Orders")

        For Count = 0 To DataSetVar.Tables("Orders").Rows.Count - 1
            ReDim Preserve Orders(Count)
            Orders(Count).OrderID = DataSetVar.Tables("Orders").Rows(Count).Item(0)
            Orders(Count).CustomerIDLink = DataSetVar.Tables("Orders").Rows(Count).Item(1)
            Orders(Count).OrderDetails = DataSetVar.Tables("Orders").Rows(Count).Item(2)
            Orders(Count).ServingSize = DataSetVar.Tables("Orders").Rows(Count).Item(3)
            Orders(Count).SpecialConsiderations = DataSetVar.Tables("Orders").Rows(Count).Item(4)
            Orders(Count).Deadline = DataSetVar.Tables("Orders").Rows(Count).Item(5)

            Orders(Count).Cost = DataSetVar.Tables("Orders").Rows(Count).Item(6)
            Orders(Count).Completed = DataSetVar.Tables("Orders").Rows(Count).Item(7)
            Orders(Count).IsDelivery = DataSetVar.Tables("Orders").Rows(Count).Item(8)
            Orders(Count).PaidDeposit = DataSetVar.Tables("Orders").Rows(Count).Item(9)
            Orders(Count).PaidInFull = DataSetVar.Tables("Orders").Rows(Count).Item(10)
        Next

        Connection.Close()
    End Sub
    Sub LoadDocuments()
        ReDim Documents(0)
        SQLCommand = "SELECT * FROM [Document]"
        DataAdapter = New OleDbDataAdapter(SQLCommand, Connection)
        Connection.Open()
        DataAdapter.Fill(DataSetVar, "Documents")

        For Count = 0 To DataSetVar.Tables("Documents").Rows.Count - 1
            ReDim Preserve Documents(Count)
            Documents(Count).DocumentID = DataSetVar.Tables("Documents").Rows(Count).Item(0)
            Documents(Count).DocumentName = DataSetVar.Tables("Documents").Rows(Count).Item(1)
            Documents(Count).DocumentDirectory = DataSetVar.Tables("Documents").Rows(Count).Item(2)
        Next
        Connection.Close()
    End Sub
    Sub LoadTodaysFinance()
        ReDim TodaysFinances(0)
        SQLCommand = "SELECT * FROM [Finance] WHERE [Date]=#" & Today.Month & "/" & Today.Day & "/" & Today.Year & "#"
        DataAdapter = New OleDbDataAdapter(SQLCommand, Connection)
        Connection.Open()
        DataAdapter.Fill(DataSetVar, "TodaysFinances")
        For count = 0 To Finances.Length - 1
            If Finances(count).FinanceDate.Date = Now.Date Then
                TodaysFinances(TodaysFinances.Length - 1) = Finances(count)
                ReDim Preserve TodaysFinances(TodaysFinances.Length)
            End If
        Next
        MainMenu.DgvFinances.DataSource = DataSetVar.Tables("TodaysFinances")
        Connection.Close()
    End Sub
    Sub LoadStock()
        ReDim Stocks(0)
        SQLCommand = "SELECT * FROM [Stock]"
        DataAdapter = New OleDbDataAdapter(SQLCommand, Connection)
        Connection.Open()
        DataAdapter.Fill(DataSetVar, "Stocks")

        For Count = 0 To DataSetVar.Tables("Stocks").Rows.Count - 1
            ReDim Preserve Stocks(Count)
            Stocks(Count).StockID = DataSetVar.Tables("Stocks").Rows(Count).Item(0)
            Stocks(Count).Item = DataSetVar.Tables("Stocks").Rows(Count).Item(1)
            Stocks(Count).Quantity = DataSetVar.Tables("Stocks").Rows(Count).Item(2)
            Stocks(Count).Status = DataSetVar.Tables("Stocks").Rows(Count).Item(3)
            Stocks(Count).Cost = DataSetVar.Tables("Stocks").Rows(Count).Item(4)
            Stocks(Count).RestockQuantity = DataSetVar.Tables("Stocks").Rows(Count).Item(5)
            Stocks(Count).Ordered = DataSetVar.Tables("Stocks").Rows(Count).Item(6)
            Stocks(Count).Discrepancy = DataSetVar.Tables("Stocks").Rows(Count).Item(7)
        Next
        MainMenu.DgvStock.DataSource = DataSetVar.Tables("Stocks")
        Connection.Close()
    End Sub
    Sub LoadFinances()
        ReDim Finances(0)
        SQLCommand = "SELECT * FROM [Finance]"
        DataAdapter = New OleDbDataAdapter(SQLCommand, Connection)
        Connection.Open()
        DataAdapter.Fill(DataSetVar, "Finances")

        For Count = 0 To DataSetVar.Tables("Finances").Rows.Count - 1
            ReDim Preserve Finances(Count)
            Finances(Count).FinanceID = DataSetVar.Tables("Finances").Rows(Count).Item(0)
            Finances(Count).OrderIDLink = CInt(DataSetVar.Tables("Finances").Rows(Count).Item(1))
            Finances(Count).Amount = DataSetVar.Tables("Finances").Rows(Count).Item(2)
            Finances(Count).Description = DataSetVar.Tables("Finances").Rows(Count).Item(3)
            Finances(Count).Type = DataSetVar.Tables("Finances").Rows(Count).Item(4)
            Finances(Count).FinanceDate = DataSetVar.Tables("Finances").Rows(Count).Item(5)
        Next
        Connection.Close()
        LoadTodaysFinance()



    End Sub
    Sub LoadCustomers()
        ReDim Customers(0)
        SQLCommand = "SELECT * FROM [Customer]"
        DataAdapter = New OleDbDataAdapter(SQLCommand, Connection)
        Connection.Open()
        DataAdapter.Fill(DataSetVar, "Customers")

        For Count = 0 To DataSetVar.Tables("Customers").Rows.Count - 1
            ReDim Preserve Customers(Count)
            Customers(Count).CustomerID = DataSetVar.Tables("Customers").Rows(Count).Item(0)
            Customers(Count).Forename = DataSetVar.Tables("Customers").Rows(Count).Item(1)
            Customers(Count).Surname = DataSetVar.Tables("Customers").Rows(Count).Item(2)
            Customers(Count).HouseNumber = DataSetVar.Tables("Customers").Rows(Count).Item(3)
            Customers(Count).Street = DataSetVar.Tables("Customers").Rows(Count).Item(4)
            Customers(Count).Town = DataSetVar.Tables("Customers").Rows(Count).Item(5)
            Customers(Count).Postcode = DataSetVar.Tables("Customers").Rows(Count).Item(6)
            Customers(Count).PhoneNumber = DataSetVar.Tables("Customers").Rows(Count).Item(7)
            Customers(Count).EMailAddress = DataSetVar.Tables("Customers").Rows(Count).Item(8)
        Next
        MainMenu.DgvCustomer.DataSource = DataSetVar.Tables("Customers")
        Connection.Close()
    End Sub
#End Region
#Region "Adding"
    Sub AddCustomer(ByVal Customer As Customer)
        Connection.Open()
        SQLCommand = "INSERT INTO [Customer] ([Forename],[Surname],[House Number],[Street],[Town],[Postcode],[Contact Number], [E-Mail Address]) VALUES ('"
        SQLCommand = SQLCommand & Customer.Forename & "','"
        SQLCommand = SQLCommand & Customer.Surname & "','"
        SQLCommand = SQLCommand & Customer.HouseNumber & "','"
        SQLCommand = SQLCommand & Customer.Street & "','"
        SQLCommand = SQLCommand & Customer.Town & "','"
        SQLCommand = SQLCommand & Customer.Postcode & "','"
        SQLCommand = SQLCommand & Customer.PhoneNumber & "','"
        SQLCommand = SQLCommand & Customer.EMailAddress & "')"
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub AddDocument(ByVal Document As Document)
        Connection.Open()
        SQLCommand = "INSERT INTO [Document] ([Document Name],[Document Directory],[Mail Merged?]) VALUES ('"
        SQLCommand = SQLCommand & Document.DocumentName & "','"
        SQLCommand = SQLCommand & Document.DocumentDirectory & "')"
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub AddStock(ByVal Stock As Stock)
        Connection.Open()
        SQLCommand = "INSERT INTO [Stock] ([Item],[Quantity],[Cost],[Restock Quantity]) VALUES ('"
        SQLCommand = SQLCommand & Stock.Item & "',"
        SQLCommand = SQLCommand & Stock.Quantity & ","
        SQLCommand = SQLCommand & Stock.Cost & ","
        SQLCommand = SQLCommand & Stock.RestockQuantity & ")"
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub AddOrder(ByVal Order As Order)
        Connection.Open()
        SQLCommand = "INSERT INTO [Order] ([Customer ID],[Order Details],[Serving Size],[Special Considerations],[Deadline],[Cost],[Complete],[Delivery],[Paid Deposit],[Paid In Full]) VALUES ("
        SQLCommand = SQLCommand & Order.CustomerIDLink & ",'"
        SQLCommand = SQLCommand & Order.OrderDetails & "',"
        SQLCommand = SQLCommand & Order.ServingSize & ",'"
        SQLCommand = SQLCommand & Order.SpecialConsiderations & "','"
        SQLCommand = SQLCommand & Order.Deadline.Date & "',"
        SQLCommand = SQLCommand & Order.Cost & ","
        SQLCommand = SQLCommand & Order.Completed & ","
        SQLCommand = SQLCommand & Order.IsDelivery & ","
        SQLCommand = SQLCommand & Order.PaidDeposit & ","
        SQLCommand = SQLCommand & Order.PaidInFull & ")"

        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub AddFinance(ByVal Finance As Finance)
        Connection.Open()
        SQLCommand = "INSERT INTO [Finance] ([Order ID],[Amount],[Description],[Date]) VALUES ("
        SQLCommand = SQLCommand & Finance.OrderIDLink & ","
        SQLCommand = SQLCommand & Finance.Amount & ",'"
        SQLCommand = SQLCommand & Finance.Description & "','"
        SQLCommand = SQLCommand & Finance.FinanceDate & "')"
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub AddStockFinance(ByVal Finance As Finance)
        Connection.Open()
        SQLCommand = "INSERT INTO [Finance] ([Amount],[Description],[Date]) VALUES ("

        SQLCommand = SQLCommand & Finance.Amount & ",'"
        SQLCommand = SQLCommand & Finance.Description & "','"
        SQLCommand = SQLCommand & Finance.FinanceDate & "')"
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
#End Region
#Region "Updating"
    Sub UpdateStockStatus(ByVal Stock As Stock)
        Connection.Open()
        SQLCommand = "UPDATE [Stock] SET [Discrepancy]=" & Stock.Discrepancy & ", [Ordered]=" & Stock.Ordered & ", [Restock Quantity]=" & Stock.RestockQuantity & ", [Quantity]=" & Stock.Quantity & " WHERE [Stock ID]=" & Stock.StockID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub UpdateStock(ByVal Stock As Stock)
        Connection.Open()
        SQLCommand = "UPDATE [Stock] SET [Item]='" & Stock.Item & "', [Quantity]=" & Stock.Quantity & ", [Cost]=" & Stock.Cost & " WHERE [Stock ID]=" & Stock.StockID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub UpdateOrder(ByVal Order As Order)
        Connection.Open()
        SQLCommand = "UPDATE [Order] SET [Paid Deposit]=" & Order.PaidDeposit & ", [Paid In Full]=" & Order.PaidInFull & " WHERE [Order ID]=" & Order.OrderID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub UpdateCustomer(ByVal Customer As Customer)
        Connection.Open()
        SQLCommand = "UPDATE [Customer] SET [Forename]='" & Customer.Forename & "', [Surname]='" & Customer.Surname & "', [House Number]='" & Customer.HouseNumber & "', [Street]='" & Customer.Street & "', [Town]='" & Customer.Town & "', [Postcode]='" & Customer.Postcode & "', [Contact Number]='" & Customer.PhoneNumber & "', [E-Mail Address]='" & Customer.EMailAddress & "' WHERE [ID]=" & Customer.CustomerID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub EditOrder(ByVal Order As Order)
        Connection.Open()
        SQLCommand = "UPDATE [Order] SET [Order Details]='" & Order.OrderDetails & "', [Serving Size]=" & Order.ServingSize & ", [Special Considerations]='" & Order.SpecialConsiderations & "', [Deadline]=#" & Order.Deadline & "#, [Cost]=" & Order.Cost & ", [Delivery]=" & Order.IsDelivery & " WHERE [Order ID]=" & Order.OrderID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
#End Region
#Region "Deleting"
    Sub DeleteStock(ByVal Stock As Stock)
        Connection.Open()
        SQLCommand = "DELETE FROM [Stock] WHERE [Stock ID]=" & Stock.StockID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub DeleteDocument(ByVal Document As Document)
        Connection.Open()
        SQLCommand = "DELETE FROM [Document] WHERE [Document Name]='" & Document.DocumentName & "'"
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub DeleteOrder(ByVal Order As Order)
        Connection.Open()
        SQLCommand = "DELETE FROM [Order] WHERE [Order ID]=" & Order.OrderID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Sub DeleteCustomer(ByVal Customer As Customer)
        Connection.Open()
        SQLCommand = "DELETE FROM [Customer] WHERE [ID]=" & Customer.CustomerID
        Dim CMD As New OleDbCommand(SQLCommand, Connection)
        CMD.ExecuteNonQuery()
        Connection.Close()
    End Sub
#End Region
End Module