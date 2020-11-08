Public Class EditStock
    Dim FindStockIndex(0)
    Dim UpdateStock As Stock
    Private Sub BtnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchCustomer.Click
        ReDim FindStockIndex(0)
        LbxSelectStock.Items.Clear()
        For Count = 0 To Stocks.Length - 1
            If Stocks(Count).Item.ToUpper.Contains(Trim(TbxItemSearch.Text.ToUpper)) Then
                LbxSelectStock.Items.Add(Stocks(Count).StockID & ": " & Stocks(Count).Item & " x" & Stocks(Count).Quantity & " @ £" & Stocks(Count).Cost)
                FindStockIndex(FindStockIndex.Length - 1) = Stocks(Count).StockID
                ReDim Preserve FindStockIndex(FindStockIndex.Length)
            End If
        Next
    End Sub

    Private Sub LbxSelectStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectStock.SelectedIndexChanged
        Try
            Dim FindStockVal As Stock = FindStock(FindStockIndex(LbxSelectStock.SelectedIndex.ToString))
            TbxStockID.Text = FindStockVal.StockID
            NudQuantity.Value = FindStockVal.Quantity
            TbxItemName.Text = FindStockVal.Item
            NudPricePerUnit.Value = FindStockVal.Cost
            UpdateStock = FindStockVal
        Catch er As Exception
            Debug.Print("User selected outside of the list")
        End Try
    End Sub


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateStock.Click
        DatabaseHandling.UpdateStock(UpdateStock)
        MainMenu.LoadAll()
        Me.Close()
    End Sub

    Private Sub NudQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudQuantity.ValueChanged
        UpdateStock.Quantity = NudQuantity.Value
    End Sub

    Private Sub NudPricePerUnit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudPricePerUnit.ValueChanged
        UpdateStock.Cost = NudPricePerUnit.Value
    End Sub

    Private Sub TbxItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxItemName.TextChanged
        UpdateStock.Item = AntiSQLInjection(TbxItemName.Text)
    End Sub
End Class