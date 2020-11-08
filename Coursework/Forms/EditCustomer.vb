Public Class EditCustomer
    Dim TempCustomer As Customer
    Dim CustomerIndex() As Integer
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
        Try
            TempCustomer = FindCustomer(CustomerIndex(LbxSelectCustomer.SelectedIndex))
            TbxCustomerID.Text = TempCustomer.CustomerID
            TbxForename.Text = TempCustomer.Forename
            TbxSurname.Text = TempCustomer.Surname
            TbxHouse.Text = TempCustomer.HouseNumber
            TbxStreet.Text = TempCustomer.Street
            TbxTown.Text = TempCustomer.Town
            TbxPostcode.Text = TempCustomer.Postcode
            TbxPhone.Text = TempCustomer.PhoneNumber
            TbxEMail.Text = TempCustomer.EMailAddress
        Catch err As Exception
        End Try
    End Sub

    Private Sub TbxForename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxForename.TextChanged
        If TbxForename.Text <> Nothing Then
            TempCustomer.Forename = AntiSQLInjection(TbxForename.Text)
        Else
            MsgBox("Forename cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If

    End Sub

    Private Sub TbxSurname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSurname.TextChanged
        If TbxSurname.Text <> Nothing Then
            TempCustomer.Surname = AntiSQLInjection(TbxSurname.Text)
        Else
            MsgBox("Surname cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub TbxHouse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxHouse.TextChanged
        If TbxHouse.Text <> Nothing Then
            TempCustomer.HouseNumber = AntiSQLInjection(TbxHouse.Text)
        Else
            MsgBox("House cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub TbxStreet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxStreet.TextChanged
        If TbxStreet.Text <> Nothing Then
            TempCustomer.Street = AntiSQLInjection(TbxStreet.Text)
        Else
            MsgBox("Street cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub TbxTown_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxTown.TextChanged
        If TbxTown.Text <> Nothing Then
            TempCustomer.Town = AntiSQLInjection(TbxTown.Text)
        Else
            MsgBox("Town cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub TbxPostcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxPostcode.TextChanged
        If TbxPostcode.Text <> Nothing Then
            TempCustomer.Postcode = AntiSQLInjection(TbxPostcode.Text)
        Else
            MsgBox("Postcode cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub TbxPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxPhone.TextChanged
        If TbxPhone.Text <> Nothing Then
            TempCustomer.PhoneNumber = AntiSQLInjection(TbxPhone.Text)
        Else
            MsgBox("Phone cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub TbxEMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxEMail.TextChanged
        If TbxEMail.Text <> Nothing Then
            TempCustomer.EMailAddress = AntiSQLInjection(TbxEMail.Text)
        Else
            MsgBox("E-Mail cannot be empty!", MsgBoxStyle.Exclamation, "Unaccepatable Input")
        End If
    End Sub

    Private Sub BtnUpdateCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateCustomer.Click
        UpdateCustomer(TempCustomer)
        MainMenu.LoadAll()
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class