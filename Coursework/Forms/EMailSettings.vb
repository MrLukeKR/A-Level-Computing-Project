Public Class EMailSettings

    Private Sub EMailSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSaveEMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveEMail.Click
        Variables.EMailUser = TbxEMailAddress.Text
        Variables.EMailPort = TbxEMailPort.Text
        Variables.EMailPassword = TbxEMailPassword.Text
        Variables.EMailServer = TbxEMailServer.Text
        SetupWizard.SaveSettings()
        MainMenu.LoadAll()
        Me.Close()
    End Sub
End Class