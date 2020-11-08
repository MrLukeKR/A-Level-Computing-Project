Public Class DeleteStock
    Dim FindStockindex() As Integer
    Dim TempStock As Stock
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

    Private Sub TbxConfirmDeletion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxConfirmDeletion.TextChanged
        If TbxConfirmDeletion.Text = "CREATEABAKE" Then
            BtnDeleteStock.Enabled = True
        Else
            BtnDeleteStock.Enabled = False
        End If
    End Sub

    Private Sub BtnDeleteStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteStock.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete Stock") = vbYes Then
            DatabaseHandling.DeleteStock(TempStock)
            MainMenu.LoadAll()
            Me.Close()
        End If
    End Sub

    Private Sub LbxSelectStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectStock.SelectedIndexChanged
        TempStock = FindStock(FindStockindex(LbxSelectStock.SelectedIndex))
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class