Public Class SetupWizard
    Public Sub SaveSettings()
        FileOpen(1, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Createabake\Settings.cbm", OpenMode.Output)
        PrintLine(1, DatabaseProvider)
        PrintLine(1, AdminEncryptedPassword)
        PrintLine(1, DatabaseDirectory)
        PrintLine(1, MapDirectory)
        PrintLine(1, SpongeMultiplier)
        PrintLine(1, FruitMultiplier)
        PrintLine(1, ChocolateMultiplier)
        PrintLine(1, CostPerServingMultiplier)
        PrintLine(1, DepositPercent)
        PrintLine(1, VAT)
        PrintLine(1, SupplierURL)
        PrintLine(1, SupplierEMail)
        PrintLine(1, LowStockThreshold)
        PrintLine(1, DeliveryOrigin.Name)
        PrintLine(1, FuelCostPerMile)
        PrintLine(1, EMailServer)
        PrintLine(1, EMailPort)
        PrintLine(1, EMailUser)
        FileClose(1)
    End Sub

    Sub CompleteWizard()
        My.Settings.FirstRun = False
        My.Settings.Save()
        SaveSettings()
        MsgBox("Setup needs to apply settings before you can run the program." & vbCr & "Please restart the program.", MsgBoxStyle.Information, "Restart Software")
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFinish.Click
        CompleteWizard()
    End Sub

    Private Sub BtnBackToDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackToAdmin.Click
        MapPanel.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        DatabaseProvider = "Microsoft.ACE.OLEDB.12.0;"
    End Sub

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        OpenFileDialog.ShowDialog()
        TbxDatabaseDirectory.Text = OpenFileDialog.FileName
    End Sub

    Private Sub BtnNextFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextVariables.Click
        DatabaseDirectory = TbxDatabaseDirectory.Text
        DatabasePanel.Hide()
        VariablesPanel.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextDatabase.Click
        MapDirectory = TbxMapDirectory.Text
        DatabasePanel.Show()
        MapPanel.Hide()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog.ShowDialog()
        TbxMapDirectory.Text = OpenFileDialog.FileName
        DatabasePanel.Show()
    End Sub

    Private Sub BtnViewPassword_Down(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPassword.MouseDown
        TbxPassword.PasswordChar = ""
    End Sub
    Private Sub BtnViewPassword_Up(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPassword.MouseUp
        TbxPassword.PasswordChar = "•"
    End Sub

    Private Sub BtnBackMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackMap.Click
        DatabasePanel.Hide()
        MapPanel.Show()
    End Sub

    Private Sub BtnBackAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackAdmin.Click
        MapPanel.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub BtnNextMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextMap.Click
        AdminEncryptedPassword = Encrypt(TbxPassword.Text)
        AdminPanel.Hide()
        MapPanel.Show()
    End Sub

    Private Sub TbxPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxPassword.TextChanged
        Dim PlainText As String
        PlainText = TbxPassword.Text
        TbxEncryptedPassword.Text = Encrypt(PlainText)
    End Sub



    Private Sub SetupWizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainMenu.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub BtnNextFinish_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextEmail.Click
        VariablesPanel.Hide()
        EMailPanel.Show()
    End Sub

    Private Sub TbxSpongeMultiplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSpongeMultiplier.TextChanged
        If IsNumeric(TbxSpongeMultiplier.Text) = True Then
            SpongeMultiplier = TbxSpongeMultiplier.Text
        Else
            TbxSpongeMultiplier.Clear()
        End If
    End Sub

    Private Sub TbxChocolateMultiplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxChocolateMultiplier.TextChanged
        If IsNumeric(TbxChocolateMultiplier.Text) = True Then
            ChocolateMultiplier = TbxChocolateMultiplier.Text
        Else
            TbxChocolateMultiplier.Clear()
        End If

    End Sub

    Private Sub TbxFruitMultiplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxFruitMultiplier.TextChanged

        If IsNumeric(TbxFruitMultiplier.Text) = True And TbxFruitMultiplier.Text <> Nothing Then
            FruitMultiplier = TbxFruitMultiplier.Text
        Else
            TbxFruitMultiplier.Clear()
        End If

    End Sub
    Private Sub TbxCostPerServing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxCostPerServing.TextChanged
        If IsNumeric(TbxCostPerServing.Text) = True Then
            CostPerServingMultiplier = TbxCostPerServing.Text
        Else
            TbxCostPerServing.Clear()
        End If
    End Sub

    Private Sub TbxDeposit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxDeposit.TextChanged
        If IsNumeric(TbxDeposit.Text) = True Then
            DepositPercent = TbxDeposit.Text
        Else
            TbxDeposit.Clear()
        End If

    End Sub

    Private Sub TbxVAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxVAT.TextChanged
        If IsNumeric(TbxVAT.Text) = True Then
            VAT = TbxVAT.Text
        Else
            TbxVAT.Clear()
        End If

    End Sub
    Private Sub TbxSupplierURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSupplierURL.TextChanged
        SupplierURL = TbxSupplierURL.Text
    End Sub

    Private Sub TbxSupplierEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSupplierEmail.TextChanged
        SupplierEMail = TbxSupplierEmail.Text
    End Sub

    Private Sub TbxLowStockThreshold_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxLowStockThreshold.TextChanged
        If IsNumeric(TbxLowStockThreshold.Text) Then
            LowStockThreshold = TbxLowStockThreshold.Text
        End If

    End Sub

    Private Sub BtnBackToDatabase_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackToDatabase.Click
        VariablesPanel.Hide()
        DatabasePanel.Show()
    End Sub

    Private Sub TbxMapDirectory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxMapDirectory.TextChanged
        If TbxMapDirectory.Text <> Nothing Then
            BtnLoadMap.Enabled = True
        Else
            BtnLoadMap.Enabled = False
        End If
    End Sub

    Private Sub BtnLoadMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadMap.Click

        Try
            InitialiseMap(Map, TbxMapDirectory.Text)
        Catch er As Exception
            MsgBox("File was not recognised as a map file!", MsgBoxStyle.Exclamation, "File Type Error")
        End Try
        Try
            For count = 0 To Map.Vertex.Length - 1
                CbxPossibleOrigins.Items.Add(Map.Vertex(count).Name)
            Next
        Catch er As Exception
            MsgBox("No vertices were found in the file given", MsgBoxStyle.Exclamation, "Map Error")
        End Try
    End Sub

    Private Sub CbxPossibleOrigins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPossibleOrigins.SelectedIndexChanged
        DeliveryOrigin = FindVertex(Map, CbxPossibleOrigins.Text)
    End Sub

    Private Sub NudFuelCost_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NudFuelCost.ValueChanged
        FuelCostPerMile = NudFuelCost.Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackToVariables.Click
        VariablesPanel.Show()
        EMailPanel.Hide()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToFinish.Click
        FinishPanel.Show()
        EMailPanel.Hide()
    End Sub

    Private Sub TbxEMailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxEMailAddress.TextChanged
        Variables.EMailUser = TbxEMailAddress.Text
    End Sub

    Private Sub TbxEMailPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxEMailPassword.TextChanged
        Variables.EMailPassword = TbxEMailPassword.Text
    End Sub

    Private Sub TbxEMailServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxEMailServer.TextChanged
        Variables.EMailServer = TbxEMailServer.Text
    End Sub

    Private Sub TbxEMailPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxEMailPort.TextChanged
        If IsNumeric(TbxEMailPort.Text) Then
            Variables.EMailPort = TbxEMailPort.Text
        Else
            TbxEMailPort.Clear()
        End If

    End Sub
End Class