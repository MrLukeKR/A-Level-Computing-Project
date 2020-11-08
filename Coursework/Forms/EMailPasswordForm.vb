Public Class EMailPasswordForm

    Private Sub EMailPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TbxEMailAddress.Text = EMailUser
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Variables.EMailPassword = TbxEMailPassword.Text
        PasswordEntered = True
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class