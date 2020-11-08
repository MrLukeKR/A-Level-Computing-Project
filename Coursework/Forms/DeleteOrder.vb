Public Class DeleteOrder
    Dim CustomerIndex() As Integer
    Dim OrderIndex() As Integer
    Dim TempCustomer As Customer
    Dim TempOrder As Order
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
    End Sub

    Private Sub LbxSelectOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectOrder.SelectedIndexChanged
        TempOrder = FindOrder(OrderIndex(LbxSelectOrder.SelectedIndex))
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TbxConfirmDeletion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxConfirmDeletion.TextChanged
        If TbxConfirmDeletion.Text = "CREATEABAKE" Then
            BtnDeleteOrder.Enabled = True
        Else
            BtnDeleteOrder.Enabled = False
        End If
    End Sub

    Private Sub BtnDeleteStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteOrder.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete Order") = vbYes Then
            DatabaseHandling.DeleteOrder(TempOrder)
            MainMenu.LoadAll()
            Me.Close()
        End If

    End Sub
End Class