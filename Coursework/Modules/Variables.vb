Module Variables
#Region "Instances"
    Public Map As New Graph
#End Region
#Region "Single Variables"
    Public SpongeMultiplier As Double
    Public ChocolateMultiplier As Double
    Public FruitMultiplier As Double
    Public IsAdmin As Boolean
    Public DatabaseProvider As String
    Public AdminEncryptedPassword As String
    Public DatabaseDirectory As String
    Public RouteString As String
    Public MapDirectory As String
    Public SupplierURL As String
    Public SupplierEMail As String
    Public LowStockThreshold As Integer
    Public VAT As Double
    Public DepositPercent As Double
    Public CostPerServingMultiplier As Double
    Public DeliveryOrigin As Vertex
    Public DeliveryOriginName As String
    Public FuelCostPerMile
    Public EMailServer As String
    Public EMailPort As String
    Public EMailUser As String
    Public EMailPassword As String
    Public SMTPServer As New System.Net.Mail.SmtpClient
    Public EMail As System.Net.Mail.MailMessage
#End Region
#Region "Arrays"
    Public Customers() As Customer
    Public Orders() As Order
    Public Finances() As Finance
    Public Stocks() As Stock
    Public Documents() As Document
    Public PriorityQueue() As Order
    Public CurrentOrderIndex() As Integer
    Public NewOrderIndex() As Integer
    Public LowStockIndex() As Integer
    Public TodaysFinances() As Finance
    Public OutstandingPaymentsIndex() As Integer
#End Region
End Module

