Public Class EditOrder
    Dim OrderIndex() As Integer
    Dim CustomerIndex() As Integer
    Dim TempCustomer As Customer
    Dim TempOrder As Order
    Dim Price As Double
    Private Sub BtnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchCustomer.Click
        LbxSelectCustomer.Items.Clear()
        ReDim CustomerIndex(0)
        For Count = 0 To Customers.Length - 1
            If Customers(Count).Surname.ToUpper = Trim(TbxNameSearch.Text.ToUpper) Then
                LbxSelectCustomer.Items.Add(Customers(Count).Surname & ", " & Customers(Count).Forename)
                CustomerIndex(CustomerIndex.Length - 1) = Customers(Count).CustomerID
                ReDim Preserve CustomerIndex(CustomerIndex.Length)
            End If
        Next
    End Sub

    Private Sub LbxSelectCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectCustomer.SelectedIndexChanged
        LbxSelectOrder.Items.Clear()
        ReDim OrderIndex(0)
        For Count = 0 To Orders.Length - 1
            If Orders(Count).CustomerIDLink = CustomerIndex(LbxSelectCustomer.SelectedIndex) Then
                LbxSelectOrder.Items.Add(Orders(Count).OrderID & ": " & Orders(Count).OrderDetails)
                OrderIndex(OrderIndex.Length - 1) = Orders(Count).OrderID
                ReDim Preserve OrderIndex(OrderIndex.Length)
            End If
        Next
        TempCustomer = FindCustomer(CustomerIndex(LbxSelectCustomer.SelectedIndex))
        Try
            If FindVertex(Map, TempCustomer.Town).Name = Nothing Then
                MsgBox("Delivery is unavailable: Customer location has not been found." & vbCr & "Please contact an administrator to edit the map file!", MsgBoxStyle.Exclamation, "Location not found")
                RdbDelivery.Checked = False
                RdbDelivery.Enabled = False
            Else
                RdbDelivery.Checked = True
                RdbDelivery.Enabled = True
            End If
        Catch err As Exception
        End Try
    End Sub

    Private Sub LbxSelectOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectOrder.SelectedIndexChanged
        TempOrder = FindOrder(OrderIndex(LbxSelectOrder.SelectedIndex))
        TbxOrderID.Text = TempOrder.OrderID
        RtbOrderDetails.Text = TempOrder.OrderDetails
        NudServingSize.Value = TempOrder.ServingSize
        RdbDelivery.Checked = TempOrder.IsDelivery
        RdbPickup.Checked = Not TempOrder.IsDelivery
        RtbConsiderations.Text = TempOrder.SpecialConsiderations
        DtpDeadline.Value = TempOrder.Deadline
        NudUserPrice.Value = TempOrder.Cost
    End Sub

    Private Sub RtbOrderDetails_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RtbOrderDetails.TextChanged

        TempOrder.OrderDetails = AntiSQLInjection(RtbOrderDetails.Text)
    End Sub

    Private Sub NudServingSize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudServingSize.ValueChanged
        TempOrder.ServingSize = NudServingSize.Value
    End Sub

    Private Sub RdbDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbDelivery.CheckedChanged
        TempOrder.IsDelivery = RdbDelivery.Checked
    End Sub

    Private Sub RtbConsiderations_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RtbConsiderations.TextChanged
        TempOrder.SpecialConsiderations = AntiSQLInjection(RtbConsiderations.Text)
    End Sub

    Private Sub DtpDeadline_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDeadline.ValueChanged
        TempOrder.Deadline = DtpDeadline.Value
    End Sub

    Private Sub TbxTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxTotal.TextChanged
        TempOrder.Cost = TbxTotal.Text
    End Sub

    Private Sub BtnUseRecommendedPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUseRecommendedPrice.Click
        NudUserPrice.Value = CDbl(TbxRecommendedPrice.Text)
    End Sub

    Private Sub BtnGenerateEstimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerateEstimate.Click
        UpdatePrice()
        BtnUseRecommendedPrice.Enabled = True
    End Sub
    Sub UpdatePrice()
        If RtbOrderDetails.Text.Contains("SPONGE") Then
            Price = NudServingSize.Value * SpongeMultiplier * CostPerServingMultiplier
        End If
        If RtbOrderDetails.Text.Contains("CHOCOLATE") Then
            Price = NudServingSize.Value * ChocolateMultiplier * CostPerServingMultiplier
        End If
        If RtbOrderDetails.Text.Contains("FRUIT") Then
            Price = NudServingSize.Value * FruitMultiplier * CostPerServingMultiplier
        End If
        If TempOrder.IsDelivery = True Then
            Price = Dijkstra(Map, DeliveryOrigin, Map.Vertex(FindVertexIndex(Map, FindVertex(Map, TempCustomer.Town))), True) * FuelCostPerMile + Price
        End If
        TbxRecommendedPrice.Text = "£" & Price
    End Sub

    Private Sub NudUserPrice_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudUserPrice.ValueChanged
        TbxVat.Text = NudUserPrice.Value * (VAT / 100)
        TbxTotal.Text = CDbl(NudUserPrice.Value) + CDbl(TbxVat.Text)
        TbxDeposit.Text = TbxTotal.Text * (DepositPercent / 100)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DatabaseHandling.EditOrder(TempOrder)
        MainMenu.LoadAll()
        Me.Close()
    End Sub
End Class