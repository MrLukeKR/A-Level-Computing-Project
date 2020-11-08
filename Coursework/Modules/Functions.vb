Module Functions
    Function FindCustomer(ByVal ID As Integer) As Customer
        For count = 0 To Customers.Length - 1
            If Customers(count).CustomerID = ID Then
                Return Customers(count)
            End If
        Next
    End Function
    Function FindDocumentByName(ByVal DocumentName As String) As Document
        For count = 0 To Documents.Length - 1
            If Documents(count).DocumentName.ToUpper = DocumentName.ToUpper Then
                Return Documents(count)
            End If
        Next
    End Function
    Function FindStock(ByVal ID As Integer) As Stock
        For count = 0 To Stocks.Length - 1
            If Stocks(count).StockID = ID Then
                Return Stocks(count)
            End If
        Next
    End Function
    Function FindOrder(ByVal ID As Integer) As Order
        For count = 0 To Orders.Length - 1
            If Orders(count).OrderID = ID Then
                Return Orders(count)
            End If
        Next
    End Function
    Function SizeToMinutes(ByVal Order As Order) As Double
        Return Order.ServingSize * DetermineMultiplier(Order) 'Minutes per serving average (can be set in admin settings)
    End Function
    Function LatestStart(ByVal Order As Order) As Date
        Dim LatestDate As Date = Order.Deadline.Date.AddDays(-Order.ETADays)
        Return LatestDate
    End Function
    Function DaysToDeadline(ByVal Order As Order) As Double
        Dim DaysToGo As TimeSpan = Order.Deadline.Date - Now.Date
        Return DaysToGo.TotalDays
    End Function
    Function DetermineMultiplier(ByVal Order As Order)
        If Order.OrderDetails.Contains("SPONGE") Then
            Return SpongeMultiplier
        ElseIf Order.OrderDetails.Contains("CHOCOLATE") Then
            Return ChocolateMultiplier
        ElseIf Order.OrderDetails.Contains("FRUIT") Then
            Return FruitMultiplier
        End If
    End Function
    Function CurrentPriority(ByVal PriorityQueue() As Order)
        Return PriorityQueue(0)
    End Function
    Function DetermineCompletion(ByVal Order As Order, Optional ByVal TimeSpan As String = "DAYS") As Double

        Dim Minutes As Double
        Dim Hours As Double
        Dim Days As Double

        Minutes = SizeToMinutes(Order) * 3
        Hours = Minutes / 60
        Days = Hours / 24
        Select Case TimeSpan
            Case Is = "DAYS"
                Return Days
            Case Is = "MINUTES"
                Return Minutes
            Case Is = "HOURS"
                Return Hours
        End Select
    End Function
    Function CheckAvailability(ByVal Order As Order) As Boolean
        Dim DaysToDeadline As Double = Functions.DaysToDeadline(Order)
        Dim CompletionTimeAvailable As Double = DaysToDeadline - Order.ETADays
        If Order.Deadline.Date.AddDays(-CompletionTimeAvailable) < Now.Date Or Order.Deadline.Date = Now.Date Then
            MsgBox("There is not enough time to complete the order!", MsgBoxStyle.Exclamation, "Scheduling error")
            Return False
        Else
            Return True
        End If
    End Function
    Function AntiSQLInjection(ByVal UserSQLCommand As String)
        Dim CorrectedSQL As String = Nothing
        Dim SQLChar As Char

        If UserSQLCommand.Contains("'") Or UserSQLCommand.Contains("[") Or UserSQLCommand.Contains("]") Or UserSQLCommand.Contains(";") Or UserSQLCommand.Contains("=") Then
            MsgBox("For security reasons, certain characters cannot be entered as part of a value.", MsgBoxStyle.Critical, "Security Risk")
            For count = 1 To UserSQLCommand.Length
                SQLChar = Mid(UserSQLCommand, count, 1)
                If (CChar(SQLChar) <> "'") And (CChar(SQLChar) <> "[") And (CChar(SQLChar) <> "]") And (CChar(SQLChar) <> ";") And (CChar(SQLChar) <> "=") Then
                    CorrectedSQL = CorrectedSQL & SQLChar
                End If
            Next
        Else
            CorrectedSQL = UserSQLCommand
        End If

        If UserSQLCommand.ToUpper.Contains("INSERT") Or UserSQLCommand.ToUpper.Contains("DELETE") Or UserSQLCommand.ToUpper.Contains("UPDATE") Or UserSQLCommand.ToUpper.Contains("CREATE") Or UserSQLCommand.ToUpper.Contains("ALTER") Or UserSQLCommand.ToUpper.Contains("DROP") Or UserSQLCommand.ToUpper.Contains("REVOKE") Then
            MsgBox("For security reasons, keywords contained in the entry parameters have triggered an alert." & vbCr & "Entry has been rejected.", MsgBoxStyle.Critical, "Security Risk")
            CorrectedSQL = Nothing
        End If
        Return CorrectedSQL
    End Function
End Module
