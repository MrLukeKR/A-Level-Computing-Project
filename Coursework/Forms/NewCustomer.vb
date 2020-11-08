Public Class NewCustomer
    Dim TempCustomer As Customer
    Private Sub NewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSaveCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveCustomer.Click
        TempCustomer.Forename = TbxForename.Text
        TempCustomer.Surname = TbxSurname.Text
        TempCustomer.HouseNumber = TbxHouseNumber.Text
        TempCustomer.Street = TbxStreet.Text
        TempCustomer.Town = TbxTown.Text
        TempCustomer.Postcode = tbxpostcode.text
        TempCustomer.PhoneNumber = TbxContactNumber.Text
        TempCustomer.EMailAddress = TbxEMailAddress.Text

        AddCustomer(TempCustomer)
        MainMenu.LoadAll()
        Me.Close()
    End Sub

    Private Sub BtnCancelCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelCustomer.Click
        Me.Close()
    End Sub

    Private Sub TbxForename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxForename.TextChanged
        TbxForename.Text = AntiSQLInjection(TbxForename.Text)
    End Sub

    Private Sub TbxSurname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSurname.TextChanged
        TbxSurname.Text = AntiSQLInjection(TbxSurname.Text)
    End Sub

    Private Sub TbxHouseNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxHouseNumber.TextChanged
        TbxHouseNumber.Text = AntiSQLInjection(TbxHouseNumber.Text)
    End Sub

    Private Sub TbxStreet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxStreet.TextChanged
        TbxStreet.Text = AntiSQLInjection(TbxStreet.Text)
    End Sub

    Private Sub TbxTown_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxTown.TextChanged
        TbxTown.Text = AntiSQLInjection(TbxTown.Text)
    End Sub

    Private Sub TbxPostcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxPostcode.TextChanged
        TbxPostcode.Text = AntiSQLInjection(TbxPostcode.Text)
    End Sub

    Private Sub TbxContactNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxContactNumber.TextChanged
        TbxContactNumber.Text = AntiSQLInjection(TbxContactNumber.Text)
    End Sub

    Private Sub TbxEMailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxEMailAddress.TextChanged
        TbxEMailAddress.Text = AntiSQLInjection(TbxEMailAddress.Text)
    End Sub
End Class