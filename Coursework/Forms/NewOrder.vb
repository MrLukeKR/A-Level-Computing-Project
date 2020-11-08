Public Class NewOrder
    Dim NewOrderCustomer As Customer
    Dim ThisOrder As Order
    Dim Price As Double
    Private Sub BtnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchCustomer.Click
        ReDim NewOrderIndex(0)
        LbxSelectCustomer.Items.Clear()
        For Count = 0 To Customers.Length - 1
            If Customers(Count).Surname.ToUpper = Trim(TbxNameSearch.Text.ToUpper) Then
                LbxSelectCustomer.Items.Add(Customers(Count).Surname & ", " & Customers(Count).Forename & ": " & Customers(Count).HouseNumber & " " & Customers(Count).Street & " " & Customers(Count).Postcode)
                NewOrderIndex(NewOrderIndex.Length - 1) = Customers(Count).CustomerID
                ReDim Preserve NewOrderIndex(NewOrderIndex.Length)
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveOrder.Click
        ThisOrder.CustomerIDLink = TbxCustomerID.Text
        ThisOrder.OrderDetails = RtbOrderDescription.Text
        ThisOrder.SpecialConsiderations = RtbConsiderations.Text
        ThisOrder.ServingSize = NudServingSize.Value
        ThisOrder.Deadline = DtpDeadline.Value.Date
        ThisOrder.Cost = NudUserPrice.Value

        If CheckAvailability(ThisOrder) = True Then
            AddOrder(ThisOrder)
            EMailInvoice(ThisOrder, FindCustomer(ThisOrder.CustomerIDLink))
            MainMenu.LoadAll()
            Me.Close()
        End If
    End Sub

    Private Sub LbxSelectCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectCustomer.SelectedIndexChanged
        If LbxSelectCustomer.SelectedItem <> "" Then
            GbxOrder.Enabled = True
        End If
        Try
            NewOrderCustomer = FindCustomer(NewOrderIndex(LbxSelectCustomer.SelectedIndex))
            TbxCustomerID.Text = NewOrderCustomer.CustomerID
            TbxCustomerSurname.Text = NewOrderCustomer.Surname
            If FindVertex(Map, NewOrderCustomer.Town).Name = Nothing Then
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

    Private Sub BtnCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelOrder.Click
        Me.Close()
    End Sub


    Private Sub NudServingSize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudServingSize.ValueChanged


    End Sub
    Sub UpdatePrice()
        If RtbOrderDescription.Text.Contains("SPONGE") Then
            Price = NudServingSize.Value * SpongeMultiplier * CostPerServingMultiplier
        End If
        If RtbOrderDescription.Text.Contains("CHOCOLATE") Then
            Price = NudServingSize.Value * ChocolateMultiplier * CostPerServingMultiplier
        End If
        If RtbOrderDescription.Text.Contains("FRUIT") Then
            Price = NudServingSize.Value * FruitMultiplier * CostPerServingMultiplier
        End If
       
        If ThisOrder.IsDelivery = True Then
            Price = Dijkstra(Map, DeliveryOrigin, Map.Vertex(FindVertexIndex(Map, FindVertex(Map, NewOrderCustomer.Town))), True) * FuelCostPerMile + Price
        End If
        TbxRecommendedPrice.Text = "£" & Price
    End Sub
   

    

    Private Sub TbxTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxTotal.TextChanged
        BtnSaveOrder.Enabled = True
    End Sub

    Private Sub BtnUseRecommendedPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUseRecommendedPrice.Click
        NudUserPrice.Value = Mid(TbxRecommendedPrice.Text, 2)
    End Sub

    Private Sub RdbDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbDelivery.CheckedChanged
        If RdbDelivery.Checked = True Then
            ThisOrder.IsDelivery = True
        End If

    End Sub

    Private Sub RdbPickup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbPickup.CheckedChanged
        If RdbPickup.Checked = True Then
            ThisOrder.IsDelivery = False
        End If
    End Sub

    Private Sub BtnGenerateEstimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerateEstimate.Click
        UpdatePrice()
        BtnUseRecommendedPrice.Enabled = True
    End Sub

    Private Sub NudUserPrice_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudUserPrice.ValueChanged
        TbxVat.Text = NudUserPrice.Value * (VAT / 100)
        TbxTotal.Text = CDbl(NudUserPrice.Value) + CDbl(TbxVat.Text)
        TbxDeposit.Text = TbxTotal.Text * (DepositPercent / 100)
    End Sub

    Private Sub NewOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThisOrder.IsDelivery = False
    End Sub

    Private Sub RtbOrderDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RtbOrderDescription.Leave
        RtbOrderDescription.Text = (AntiSQLInjection(RtbOrderDescription.Text))
    End Sub

    Private Sub RtbConsiderations_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RtbConsiderations.Leave
        RtbConsiderations.Text = AntiSQLInjection(RtbConsiderations.Text)
    End Sub

    Private Sub DtpDeadline_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDeadline.ValueChanged
        If DtpDeadline.Value.Date < Today.Date Then
            DtpDeadline.Value = Today.Date
        End If
        MsgBox("Cannot be a date in the past")
    End Sub
End Class