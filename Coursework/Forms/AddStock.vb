Public Class AddStock
    Dim TempStock As Stock
    Private Sub TbxItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxItem.TextChanged
        TbxItem.Text = AntiSQLInjection(TbxItem.Text)
        TempStock.Item = AntiSQLInjection(TbxItem.Text)

    End Sub

    Private Sub AddStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NudQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudQuantity.ValueChanged
        TempStock.Quantity = NudQuantity.Value
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        TempStock = Nothing
        Me.Close()
    End Sub

    Private Sub BtnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddStock.Click
        DatabaseHandling.AddStock(TempStock)
        MainMenu.LoadAll()
        Me.Close()

    End Sub

    Private Sub NudPricePerUnit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudPricePerUnit.ValueChanged
        TempStock.Cost = NudPricePerUnit.Value
    End Sub
End Class