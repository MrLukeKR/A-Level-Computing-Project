Module Structures
    Structure Graph
        Dim Vertex() As Vertex
    End Structure
    Structure Vertex
        Dim Name As String
        Dim Connections() As Edge
        Dim DistanceToStart As Double
        Dim Index As Integer
        Dim Visited As Boolean
        Dim VisitedIndex As Integer
    End Structure
    Structure Edge
        Dim Destination As Vertex
        Dim Distance As Double
    End Structure
    Structure Customer
        Dim CustomerID As Integer
        Dim Forename As String
        Dim Surname As String
        Dim EMailAddress As String
        Dim PhoneNumber As String
        Dim HouseNumber As String
        Dim Street As String
        Dim Town As String
        Dim Postcode As String
    End Structure
    Structure Order
        Dim OrderID As Integer
        Dim CustomerIDLink As Integer
        Dim StockID As Integer
        Dim OrderDetails As String
        Dim ServingSize As Integer
        Dim SpecialConsiderations As String
        Dim Deadline As Date
        Dim ETADays As Double
        Dim Cost As Double
        Dim Completed As Boolean
        Dim IsDelivery As Boolean
        Dim PaidDeposit As Boolean
        Dim PaidInFull As Boolean
    End Structure
    Structure Stock
        Dim StockID As Integer
        Dim Item As String
        Dim Quantity As Integer
        Dim Status As String
        Dim Cost As Double
        Dim RestockQuantity As Integer
        Dim Ordered As Boolean
        Dim Discrepancy As Boolean
    End Structure
    Structure Finance
        Dim FinanceID As Integer
        Dim OrderIDLink As Integer
        Dim Amount As Double
        Dim Description As String
        Dim Type As String
        Dim FinanceDate As Date
    End Structure
    Structure Document
        Dim DocumentID As Integer
        Dim DocumentName As String
        Dim DocumentDirectory As String
    End Structure
End Module
