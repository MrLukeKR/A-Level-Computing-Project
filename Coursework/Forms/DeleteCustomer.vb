Public Class DeleteCustomer
    Dim CustomerIndex() As Integer
    Dim TempCustomer As Customer
    Private Sub BtnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchCustomer.Click
        LbxSelectCustomer.Items.Clear()
        ReDim CustomerIndex(0)
        For Count = 0 To Customers.Length - 1
            If Customers(Count).Surname.ToUpper = Trim(TbxNameSearch.Text.ToUpper) Then
                LbxSelectCustomer.Items.Add(Customers(Count).Surname & ", " & Customers(Count).Forename & ": " & Customers(Count).HouseNumber & " " & Customers(Count).Street & " " & Customers(Count).Postcode)
                CustomerIndex(CustomerIndex.Length - 1) = Customers(Count).CustomerID
                ReDim Preserve CustomerIndex(CustomerIndex.length)
            End If
        Next
    End Sub

    Private Sub LbxSelectCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectCustomer.SelectedIndexChanged
        TempCustomer = FindCustomer(CustomerIndex(LbxSelectCustomer.SelectedIndex))
    End Sub

    Private Sub TbxConfirmDeletion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxConfirmDeletion.TextChanged
        If TbxConfirmDeletion.Text = "CREATEABAKE" Then
            BtnDeleteCustomer.Enabled = True
        Else
            BtnDeleteCustomer.Enabled = False
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnDeleteCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteCustomer.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete Customer") = vbYes Then
            DatabaseHandling.deletecustomer(TempCustomer)
            MainMenu.LoadAll()
            Me.Close()
        End If
    End Sub

    Private Sub DeleteCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class